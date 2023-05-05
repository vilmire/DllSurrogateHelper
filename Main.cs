using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace DllSurrogateHelper
{
    public partial class Main : Form
    {
        public List<string> clsIDs = new List<string>();

        public static List<string> tmpStringDatas = new List<string>();

        const uint LOAD_LIBRARY_AS_DATAFILE = 0x00000002;

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        static extern IntPtr LoadLibraryEx(string lpFileName, IntPtr hFile, uint dwFlags);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr LoadLibrary(string dllToLoad);

        [DllImport("kernel32.dll")]
        static extern IntPtr FindResource(IntPtr hModule, IntPtr lpName, IntPtr lpType);

        [DllImport("kernel32.dll")]
        static extern IntPtr LoadResource(IntPtr hModule, IntPtr hResInfo);

        [DllImport("kernel32.dll")]
        static extern uint SizeofResource(IntPtr hModule, IntPtr hResInfo);

        [DllImport("kernel32.dll")]
        static extern IntPtr LockResource(IntPtr hResData);

        [DllImport("kernel32.dll")]
        static extern bool EnumResourceTypes(IntPtr hModule, EnumResTypesProc lpEnumFunc, IntPtr lParam);

        [DllImport("kernel32.dll")]
        static extern bool EnumResourceNames(IntPtr hModule, IntPtr lpszType, EnumResNamesProc lpEnumFunc, IntPtr lParam);

        delegate bool EnumResTypesProc(IntPtr hModule, IntPtr lpType, IntPtr lParam);

        delegate bool EnumResNamesProc(IntPtr hModule, IntPtr lpszType, IntPtr lpszName, IntPtr lParam);


        static bool EnumResTypesCallback(IntPtr hModule, IntPtr lpType, IntPtr lParam)
        {
            Console.WriteLine("Resource Type: " + lpType);

            EnumResourceNames(hModule, lpType, new EnumResNamesProc(EnumResNamesCallback), IntPtr.Zero);

            return true;
        }

        static bool EnumResNamesCallback(IntPtr hModule, IntPtr lpszType, IntPtr lpszName, IntPtr lParam)
        {
            Console.WriteLine("Resource Name: " + lpszName);

            IntPtr hResInfo = FindResource(hModule, lpszName, lpszType);

            if (hResInfo != IntPtr.Zero)
            {
                uint resSize = SizeofResource(hModule, hResInfo);
                IntPtr hResData = LoadResource(hModule, hResInfo);
                IntPtr pResData = LockResource(hResData);

                byte[] resBytes = new byte[resSize];
                Marshal.Copy(pResData, resBytes, 0, (int)resSize);
                lock (tmpStringDatas)
                {
                    tmpStringDatas.Add(System.Text.Encoding.ASCII.GetString(resBytes));
                }
                //Console.WriteLine("Resource Data: " + );
            }

            return true;
        }


        static List<string> GetClsidFromDll(string dllPath)
        {
            try
            {
                tmpStringDatas.Clear();
                // Load the DLL file
                IntPtr hModule = LoadLibraryEx(dllPath, IntPtr.Zero, LOAD_LIBRARY_AS_DATAFILE);

                if (hModule != IntPtr.Zero)
                {
                    EnumResourceTypes(hModule, new EnumResTypesProc(EnumResTypesCallback), IntPtr.Zero);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return tmpStringDatas;
        }

        public Main()
        {
            InitializeComponent();
        }

        private void openDllBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                foreach (string fileName in openFileDialog1.FileNames)
                {
                    List<string> stringDatas = GetClsidFromDll(fileName);
                    Regex regex = new Regex(regExTextBox.Text);
                    foreach (string stringdata in stringDatas)
                    {
                        Match match = regex.Match(stringdata);
                        if (match.Success)
                        {
                            string clsid = match.Value;
                            if (clsIDs.Contains(clsid) == false)
                            {
                                clsIDs.Add(clsid);
                            }
                        }
                        else
                        {
                            Console.WriteLine("CLSID not found.");
                        }
                    }
                }
                clsidListBox.DataSource = clsIDs;
                clsidListBox.DataSource = null;
                clsidListBox.DataSource = clsIDs;
            }
        }

        private void regExTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            guidTextBox.Text = Guid.NewGuid().ToString().ToUpper();

            if (clsidListBox.Items.Count > 0)
            {
                foreach (var item in clsidListBox.Items)
                {
                    if (item is string stringItem)
                    {
                        clsIDs.Add(stringItem);
                    }
                }
            }

            clsidListBox.DataSource = null;
            clsidListBox.DataSource = clsIDs;
        }

        private void refreshGuidBtn_Click(object sender, EventArgs e)
        {
            guidTextBox.Text = Guid.NewGuid().ToString().ToUpper();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            string appId = guidTextBox.Text;

            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{appId}.txt");
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (string cls in clsIDs)
                {
                    writer.WriteLine(cls);
                }
            }

            Process.Start("reg.exe", $"add HKCR\\AppID\\{{{appId}}} /v DllSurrogate /d \"\"");
            Parallel.ForEach(clsIDs, cls =>
            {
                ProcessStartInfo startInfo = new ProcessStartInfo("c:\\windows\\syswow64\\reg.exe", $"add HKCR\\CLSID\\{{{cls}}} /v AppID /d {{{appId}}}");
                startInfo.CreateNoWindow = true;
                startInfo.RedirectStandardInput = true;
                startInfo.RedirectStandardOutput = true;
                Process process = Process.Start(startInfo);
                process.StandardInput.WriteLine("Yes");
            });

            MessageBox.Show($"{appId} Regested!");
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string appId = guidTextBox.Text;
            Process.Start("reg.exe", $"delete HKCR\\AppID\\{{{appId}}} /v DllSurrogate /d \"\"");

            Parallel.ForEach(clsIDs, cls =>
            {
                ProcessStartInfo startInfo = new ProcessStartInfo("c:\\windows\\syswow64\\reg.exe", $"delete HKCR\\CLSID\\{{{cls}}} /v AppID");                
                startInfo.CreateNoWindow = true;
                startInfo.RedirectStandardInput = true;
                startInfo.RedirectStandardOutput = true;
                Process process = Process.Start(startInfo);
                process.StandardInput.WriteLine("Yes");
            });

            MessageBox.Show("Deleted!");
        }

        private void clsidListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (clsidListBox.SelectedItem != null && clsidListBox.SelectedItem is string stringItem)
            {
                clsIDs.Remove(stringItem);
                clsidListBox.DataSource = null;
                clsidListBox.DataSource = clsIDs;
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            clsIDs.Clear();
            clsidListBox.DataSource = null;
            clsidListBox.DataSource = clsIDs;
        }

        private void appendBtn_Click(object sender, EventArgs e)
        {
            clsIDs.Add(appendTextBox.Text);
            clsidListBox.DataSource = null;
            clsidListBox.DataSource = clsIDs;
        }
    }
}