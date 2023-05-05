namespace DllSurrogateHelper
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            clsidListBox = new ListBox();
            guidTextBox = new TextBox();
            createBtn = new Button();
            DeleteBtn = new Button();
            refreshGuidBtn = new Button();
            openDllBtn = new Button();
            openFileDialog1 = new OpenFileDialog();
            regExTextBox = new TextBox();
            ClearBtn = new Button();
            DelBtn = new Button();
            appendBtn = new Button();
            appendTextBox = new TextBox();
            SuspendLayout();
            // 
            // clsidListBox
            // 
            clsidListBox.FormattingEnabled = true;
            clsidListBox.ItemHeight = 25;
            clsidListBox.Items.AddRange(new object[] { "9FF543E2-FB11-11D3-8224-00105A7C4F8C", "85934405-08FD-11D4-8231-00105A7C4F8C", "55D0C6E5-0966-11D4-8232-00105A7C4F8C", "55D0C6E7-0966-11D4-8232-00105A7C4F8C", "D6122124-0B4C-11D4-8234-00105A7C4F8C", "48096137-0B62-11D4-8234-00105A7C4F8C", "4809613A-0B62-11D4-8234-00105A7C4F8C", "4809613F-0B62-11D4-8234-00105A7C4F8C", "5B886BA4-0B8E-11D4-8235-00105A7C4F8C", "02CAF560-0C31-11D4-8236-00105A7C4F8C", "02CAF55C-0C31-11D4-8236-00105A7C4F8C", "7C79B1F6-0E74-11D4-823A-00105A7C4F8C", "8A1D75A5-0F42-11D4-823D-00105A7C4F8C", "1583EA45-B4D3-4B3A-8018-A0FDF8334619", "8F101465-F973-4601-ABF6-7B281A79C93C", "B28635B1-FF2B-4E03-98CC-427D71AA5AC4", "9D5B7EF6-30C3-43F7-B9F5-6AD9A3CE6A26", "8F86C563-8079-47FD-979E-6C4C7D647786", "B040FF23-27CD-46B2-BDC8-E7E793509C65", "2A90886E-86C7-4E37-94BF-D66FD36426F9", "505B3ED8-392F-482D-A0C4-6D40F9E7EA72", "F39298B4-74D1-4699-AE7D-82C2CC428E25", "309CFF13-AE6E-48BD-8BE0-13B75D33D3E7", "0E581B11-5E74-4A79-8609-AF117BDB88E0", "1C95CC46-DDC7-4015-8D06-7028FACDE801", "354E2635-A0AB-4511-BCD9-13C187A37C89", "12A49893-A2E9-42A0-9DD4-C28851E597D0", "92372A60-C14C-4B8B-A656-1BB5C17F84AC", "A8341025-9D81-467C-8D44-5F569BF37842", "1D9E7343-8C92-430A-9C8D-F8C6DCF3D635", "CEE55BF3-DE0B-46B9-AD5E-108D875E54FE", "70A9C960-FBFF-4981-A081-3F323B3A439F", "1EF6F3EE-F43F-4FEC-845A-44D4CF769272", "65735FE8-5B16-4285-A832-532E5FFC9B38", "44F25C73-57E6-4BAA-9369-9B6F42CD5D55", "C12D47E0-BACB-47AE-BC6C-4BD5744A8680", "5CBBF6AD-6896-40A2-BC7F-630C274627BE", "7630F872-FDF8-4880-BE46-C7B912CA5CC1", "72FDAF04-F87B-47E1-9396-0A7C98F4E5C5", "859343F1-08FD-11D4-8231-00105A7C4F8C", "0D60B192-F361-4353-8B23-44514911FA6F", "C517AF9D-F297-449F-BECA-7B59F1DB845B", "EEA6A7D7-1E8C-4D90-8ACB-7BD391694978", "7163F981-6552-49E9-84AF-EC1E62FEC867", "76F545B3-CAD9-4474-BA39-F67352924174", "3116500C-0DC1-4C63-B760-043903A463C5", "4FF1F71F-0D95-46F1-80D2-C62E50D46995", "A2570BF0-8BF3-4AB8-A4B9-200741A16A11", "484427BE-E0C6-45DD-9368-DEF8DB3EFC9D", "21123F9D-FFFC-49B2-ACC1-B89B4EE50A18", "DC9ECD73-16FE-4AA3-BEC9-2A8D1E9A8B72", "06CD6CE2-CC6E-46A3-B1DF-FB51DEA97A77", "E1017E1F-F779-4624-88FD-97381687E54F", "8113D43D-FCCB-4521-A13D-B7CCA8EBF378", "FD0CCD4E-3E44-4288-A42C-606D9703373B", "F5075466-0FB5-45CC-85AA-D902F1D173C3", "8CE1E3A6-F42C-4959-B747-287A06921D4A", "5E64D7D7-D393-4326-95AD-3FCBA4A4BF46", "8B4FF082-FB67-4A38-868B-B1583D0C5AD2", "6F491767-5800-4E11-B454-E3270FCBBD17", "55896A25-A1DF-4BBA-96BD-9598EF5AD9D6", "3B532417-7AE8-4434-84F2-814AB8D6435B", "D35E3898-4C51-47A6-B044-CCA217AFCEC0", "10C45173-F22A-4037-AEF9-0A13BA3FA146", "DF4AF880-ED67-4825-A61C-24D1E5D62BF1", "B5F48DBB-14A4-4346-966C-35187E1390B6", "CDB1D9C6-C6DF-4004-8BB7-E6D282BBF938", "C5082D47-B750-4F6B-A71B-2FFF2BECEFB9", "13C7321A-77F2-46EA-8330-405553D0EB44", "D99B83AA-06D4-4944-81BC-7B18C0FCC491", "1FF05E16-3C49-49F1-A8C9-A6AFB5E89162", "9DFA90BB-7BD9-4F2A-8777-34CB94781FBF", "029CD802-DCCD-4D4E-B765-0F9E70BFEEFC", "9C31B76A-7189-49A3-9781-3C6DD6ED5AD3", "9FDCED6B-F909-4633-9985-15A45BFC85F2", "60EE7DC7-ECEC-4CA1-A098-2EDF4DC726F2", "FB254BEA-3D92-4F02-A910-6EBBFE8725CF", "52E939B5-8360-4494-9264-17830B270078", "D717CA73-B58D-4496-9D75-2939819313F3", "66EE26F0-BA01-4095-B7A4-48316E9130A5", "E8931FA7-2E91-416F-85B8-F80351FD5C24", "AF38F980-ABC8-4C99-8B95-19A1CC39ACB7", "DB6CADF4-515A-4845-BE7B-ECA2D93DAB26", "942C11D6-2DA7-4119-8D4F-493F0623C1B7", "8A0FAF47-A6A1-4518-B66A-61B7143C389C", "6B0B7CB1-03BC-44CB-8768-79FFC699B41A", "8DB220EA-04E0-4272-9AED-6B1550F6DBAB", "79A10F99-442F-472D-8088-816B25F85523", "C6CE0564-B055-46AA-A406-DF1AF0A549C2", "9FA37D6D-1E16-442C-8EDD-A3E423E8FEA1", "D6633FD4-D339-4782-B337-2A6C9ED3CA47", "13173568-9547-4910-B040-9168A5DC950C", "AF9498CB-FFBC-45FA-A5B5-3BE5E48146E5", "49EC4E41-32D5-4994-8B0C-BC7AAB238E6A", "4E793A3C-DFD4-499A-93F6-B2CEC3DC151B", "BE5F7180-7E74-4F44-8C67-700811BAD363", "10674C56-4ACC-4104-BC8D-42F855EBA17D", "C8C73E26-6C02-46CB-B8B6-1600E5A86A6B", "75CCA696-16F2-459D-9F73-9EE5B92D60B3", "DAAF202A-393E-4353-A4EA-092733536C64", "42A23EE1-5CB9-4F9F-8467-208ED8602665", "1B54A2E7-8F72-4825-B109-7E2DD61D6C8E", "923667A7-245E-44E2-AB39-CB224F5B913E", "EF251164-0FC9-4582-A6EE-7C6A3B981111", "7E291B7A-D229-4741-A8C1-C33B0DBBF6FB", "BC2B7C0D-8481-4067-B1A4-5D7BDCA9DCBA", "348306A3-8692-4758-AE08-883CF96B0B4C", "1C6B4381-B00C-4529-ABA1-FF705BFA342F", "DC43995C-F264-4ECA-B88A-20B4FD238DAF", "23DEEA4C-FCF5-49B6-B1A8-07EF1D6D4AD4", "D9A23D4E-624D-43E8-9FDA-F9174A073209", "9B08D6BE-4DE0-4F6A-B32A-22C9F0B182F7", "8195B34A-E25A-4174-A41E-3283BFD0CBD6", "E7FBCAA1-E01F-4CD5-B215-DB77D3AF5448", "09832FA6-1662-4EE3-9F91-6C8CD66EB3B2", "2ADC5BB3-40A2-450C-A503-51084AD15D99", "75FDB7F9-6B05-49E7-B7BD-80DA111FF3D5", "70C14953-D33B-454B-856F-9464B7D7BAB5", "D14D1214-71D0-4207-9780-6DAC389EAE85", "D3825EE2-C49F-4756-890D-530CDAA25EC5", "3014C34B-46C3-4440-B6F5-93997817047B", "A45C67C3-53B6-4740-92AF-A04338D9215B", "A0696F58-8C6B-4E3B-8F7B-9EB4CC094EBB", "3626A621-23F1-409F-BDD0-5AE10FF924E0", "65950801-9C94-4756-A92A-B20F319CDE2E", "D07D7BAC-7FDD-4AA1-9FEB-156EC5344B8E", "EF88BBDC-8403-41C7-9FA1-2E0B5D52FEB4", "AAFD418D-0D1A-41C1-9E70-E91962002932", "100A7E1E-1B72-4622-A4CF-FFBA1336A30C", "C3DE1C2F-54FE-4B1E-B433-4F42A4929618", "62FBF818-C088-40C1-9B6E-D7CBA632405C", "250EDB54-764B-4015-979A-2B1819C8F4BA", "3438271B-2E14-4DCB-B64A-CAD75B5016C5", "A92FDBCE-E9F7-425D-8FB7-3ACCDE09264F", "37001E74-5FAA-4502-94FA-3AE9FC102DEB", "249A0E5B-2FB1-4762-96DE-D7D0C7927796", "0F5B7F6F-A5B6-4296-94DB-98373EEE1598", "D44D2789-F23F-4E3D-959C-E6A399413492", "302903C9-49D8-4D47-9A3F-A2FA150350E7", "0651A2B7-0F47-4233-ACBF-DDEFA06C57E9", "C8F097B8-BF52-419B-8430-084B596B4AD3", "5A7EB1B7-BDB3-45E6-9CAA-A75F8C534685", "ACAD853E-9FA9-4165-9CE9-166BF4414AA3", "8203C86A-2282-4225-A79E-A9559357A3BC", "1497FD6D-0439-47BC-95B3-B838CD32D00F", "CB3DDA0D-E824-4008-8E69-CF168ABB6361", "15110F2E-4E3A-4921-AF52-EE6BF85AAD6E", "1E090CEF-B084-4961-93C3-92360F4D2226", "4E87EAB5-DB31-4FA6-AE19-47FFFE0672B9", "ED55E435-4C27-48A0-9033-309EF9D88E1F", "91875829-5FDE-4254-BA35-52272D546F8F", "60D268EF-1D95-49B2-9E83-35B5DCD2A241", "1F7D5E5A-05AB-4236-B6F3-3D383B09203A", "BB347FF1-D974-4A50-85FB-C751235AE061", "0BF841E1-849B-4AB9-8D85-5821458A437C", "99EE8587-50FE-4520-8551-BEE017B3C16F", "FB214CC6-2265-4078-9405-FEF5D909B227", "4DE84A1D-FB39-4B57-8E61-0216777A1B31", "DA92E1FD-717F-4549-BB5C-90391302E84F", "D178011D-1CEB-4250-BB80-F9D42776BB46", "63A29BB8-469C-4965-B4E2-FC1A545E4E2B", "C9410BA8-F7DB-4433-BEBA-670FC9D71C74", "DEAC8F35-DD30-4C02-B105-9F558863D797", "CE7160AC-297A-4274-9AEB-26F9D1312DF8", "F415CACE-CCFF-4F7A-8ACD-4C3045DDD2D1", "6C242F93-DE5E-4039-961F-4C116D74BE66", "1D18474B-29CA-45B5-A3A5-A75B3593888B", "47FA1A84-D56E-4AC7-A176-D9A2BCF01C72", "C822BB56-2BB3-412F-BFD7-9DE5E42E2A48", "62055D8A-2A2C-482A-AB61-4B6808A6B95F", "2E24A4D5-749A-4E08-98B7-081897BF6612", "81C12AD3-D154-4908-81FF-01C6D65A052E", "DED73E82-8BC5-44CF-8B68-6D4D0A629D4F", "BB483629-435C-4852-AF05-7B37A80F7661", "86551C2A-9893-4DB6-A917-AF2D048BA13A", "8D794BED-A116-471A-8298-AAB673C3CC58", "8F3408DA-8936-4902-AA2D-13AFBEB2561A", "F93732D1-FC68-4C04-A0F2-4A66971D581B", "6C7B3B4E-7D8B-4598-AE1A-518E8FD459C2", "1C5CD253-54F6-4175-AD38-0F9BFE7B7B5A", "2297F381-FFB1-45C6-AA80-4C6913F45E91", "15A37730-A973-47D7-9058-2686097642F8", "7566755F-36AD-43EF-B388-4CC62CA94279", "19A11288-2B28-45C4-8CD4-3A12B60C3BD7", "2DA9C35C-FE59-4A32-A942-325EE8A6F659", "995B5ABE-ED4B-4D04-B46D-6238AB66EA71", "3AB3C774-9971-4BD3-9393-183641A5028D", "1172DA0D-1235-4348-880B-10F95AC86E46" });
            clsidListBox.Location = new Point(12, 138);
            clsidListBox.Name = "clsidListBox";
            clsidListBox.Size = new Size(402, 304);
            clsidListBox.TabIndex = 0;
            clsidListBox.SelectedIndexChanged += clsidListBox_SelectedIndexChanged;
            // 
            // guidTextBox
            // 
            guidTextBox.Location = new Point(17, 492);
            guidTextBox.Name = "guidTextBox";
            guidTextBox.Size = new Size(374, 31);
            guidTextBox.TabIndex = 1;
            // 
            // createBtn
            // 
            createBtn.Location = new Point(17, 529);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(374, 114);
            createBtn.TabIndex = 2;
            createBtn.Text = "CreateDllSurrogate";
            createBtn.UseVisualStyleBackColor = true;
            createBtn.Click += createBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(397, 532);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(91, 111);
            DeleteBtn.TabIndex = 3;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // refreshGuidBtn
            // 
            refreshGuidBtn.Location = new Point(397, 492);
            refreshGuidBtn.Name = "refreshGuidBtn";
            refreshGuidBtn.Size = new Size(91, 34);
            refreshGuidBtn.TabIndex = 4;
            refreshGuidBtn.Text = "Refresh";
            refreshGuidBtn.UseVisualStyleBackColor = true;
            refreshGuidBtn.Click += refreshGuidBtn_Click;
            // 
            // openDllBtn
            // 
            openDllBtn.Location = new Point(12, 12);
            openDllBtn.Name = "openDllBtn";
            openDllBtn.Size = new Size(476, 67);
            openDllBtn.TabIndex = 5;
            openDllBtn.Text = "Select Dll";
            openDllBtn.UseVisualStyleBackColor = true;
            openDllBtn.Click += openDllBtn_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Multiselect = true;
            // 
            // regExTextBox
            // 
            regExTextBox.Location = new Point(17, 85);
            regExTextBox.Name = "regExTextBox";
            regExTextBox.Size = new Size(471, 31);
            regExTextBox.TabIndex = 6;
            regExTextBox.Text = "[0-9A-F]{8}-([0-9A-F]{4}-){3}[0-9A-F]{12}";
            regExTextBox.TextChanged += regExTextBox_TextChanged;
            // 
            // ClearBtn
            // 
            ClearBtn.Location = new Point(420, 138);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(68, 34);
            ClearBtn.TabIndex = 7;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // DelBtn
            // 
            DelBtn.Location = new Point(420, 178);
            DelBtn.Name = "DelBtn";
            DelBtn.Size = new Size(68, 34);
            DelBtn.TabIndex = 8;
            DelBtn.Text = "Del";
            DelBtn.UseVisualStyleBackColor = true;
            DelBtn.Click += DelBtn_Click;
            // 
            // appendBtn
            // 
            appendBtn.Location = new Point(420, 448);
            appendBtn.Name = "appendBtn";
            appendBtn.Size = new Size(68, 34);
            appendBtn.TabIndex = 9;
            appendBtn.Text = "Add";
            appendBtn.UseVisualStyleBackColor = true;
            appendBtn.Click += appendBtn_Click;
            // 
            // appendTextBox
            // 
            appendTextBox.Location = new Point(17, 450);
            appendTextBox.Name = "appendTextBox";
            appendTextBox.Size = new Size(397, 31);
            appendTextBox.TabIndex = 10;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 655);
            Controls.Add(appendTextBox);
            Controls.Add(appendBtn);
            Controls.Add(DelBtn);
            Controls.Add(ClearBtn);
            Controls.Add(regExTextBox);
            Controls.Add(openDllBtn);
            Controls.Add(refreshGuidBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(createBtn);
            Controls.Add(guidTextBox);
            Controls.Add(clsidListBox);
            Name = "Main";
            Text = "DllSurrogateHelper";
            Load += Main_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox clsidListBox;
        private TextBox guidTextBox;
        private Button createBtn;
        private Button DeleteBtn;
        private Button refreshGuidBtn;
        private Button openDllBtn;
        private OpenFileDialog openFileDialog1;
        private TextBox regExTextBox;
        private Button ClearBtn;
        private Button DelBtn;
        private Button appendBtn;
        private TextBox appendTextBox;
    }
}