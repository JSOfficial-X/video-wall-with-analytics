namespace Remote_Manager
{
    partial class frmRemoteManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnSeniorFemale = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCurrentSelection = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnAdultFemale = new System.Windows.Forms.Button();
            this.btnYouthFemale = new System.Windows.Forms.Button();
            this.btnSeniorMale = new System.Windows.Forms.Button();
            this.btnAdultMale = new System.Windows.Forms.Button();
            this.btnYouthMale = new System.Windows.Forms.Button();
            this.btnDefaultVideos = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkFemaleFirst = new System.Windows.Forms.CheckBox();
            this.chkMaleFirst = new System.Windows.Forms.CheckBox();
            this.btnFemaleFirst = new System.Windows.Forms.Button();
            this.btnMaleFirst = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.richTxtMessage = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1212, 675);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(1204, 646);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Content Manager";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(2, 2);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnSeniorFemale);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.lblCurrentSelection);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.btnDelete);
            this.splitContainer1.Panel1.Controls.Add(this.btnUpload);
            this.splitContainer1.Panel1.Controls.Add(this.btnAdultFemale);
            this.splitContainer1.Panel1.Controls.Add(this.btnYouthFemale);
            this.splitContainer1.Panel1.Controls.Add(this.btnSeniorMale);
            this.splitContainer1.Panel1.Controls.Add(this.btnAdultMale);
            this.splitContainer1.Panel1.Controls.Add(this.btnYouthMale);
            this.splitContainer1.Panel1.Controls.Add(this.btnDefaultVideos);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Size = new System.Drawing.Size(1200, 642);
            this.splitContainer1.SplitterDistance = 287;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnSeniorFemale
            // 
            this.btnSeniorFemale.Location = new System.Drawing.Point(2, 444);
            this.btnSeniorFemale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSeniorFemale.Name = "btnSeniorFemale";
            this.btnSeniorFemale.Size = new System.Drawing.Size(283, 51);
            this.btnSeniorFemale.TabIndex = 12;
            this.btnSeniorFemale.Text = "Senior Female";
            this.btnSeniorFemale.UseVisualStyleBackColor = true;
            this.btnSeniorFemale.Click += new System.EventHandler(this.btnSeniorFemale_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(69, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Current Selection:";
            // 
            // lblCurrentSelection
            // 
            this.lblCurrentSelection.AutoSize = true;
            this.lblCurrentSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblCurrentSelection.Location = new System.Drawing.Point(86, 89);
            this.lblCurrentSelection.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentSelection.Name = "lblCurrentSelection";
            this.lblCurrentSelection.Size = new System.Drawing.Size(103, 18);
            this.lblCurrentSelection.TabIndex = 10;
            this.lblCurrentSelection.Text = "Default Videos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(29, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 48);
            this.label1.TabIndex = 9;
            this.label1.Text = "Categories";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 499);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 73);
            this.panel1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.Location = new System.Drawing.Point(18, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 39);
            this.label4.TabIndex = 12;
            this.label4.Text = "Upload/Delete";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(2, 630);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(283, 51);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(2, 575);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(283, 51);
            this.btnUpload.TabIndex = 6;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnAdultFemale
            // 
            this.btnAdultFemale.Location = new System.Drawing.Point(1, 390);
            this.btnAdultFemale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdultFemale.Name = "btnAdultFemale";
            this.btnAdultFemale.Size = new System.Drawing.Size(283, 51);
            this.btnAdultFemale.TabIndex = 5;
            this.btnAdultFemale.Text = "Adult Female";
            this.btnAdultFemale.UseVisualStyleBackColor = true;
            this.btnAdultFemale.Click += new System.EventHandler(this.btnAdultFemale_Click);
            // 
            // btnYouthFemale
            // 
            this.btnYouthFemale.Location = new System.Drawing.Point(2, 335);
            this.btnYouthFemale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnYouthFemale.Name = "btnYouthFemale";
            this.btnYouthFemale.Size = new System.Drawing.Size(283, 51);
            this.btnYouthFemale.TabIndex = 4;
            this.btnYouthFemale.Text = "Youth Female";
            this.btnYouthFemale.UseVisualStyleBackColor = true;
            this.btnYouthFemale.Click += new System.EventHandler(this.btnYouthFemale_Click);
            // 
            // btnSeniorMale
            // 
            this.btnSeniorMale.Location = new System.Drawing.Point(1, 281);
            this.btnSeniorMale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSeniorMale.Name = "btnSeniorMale";
            this.btnSeniorMale.Size = new System.Drawing.Size(283, 51);
            this.btnSeniorMale.TabIndex = 3;
            this.btnSeniorMale.Text = "Senior Male";
            this.btnSeniorMale.UseVisualStyleBackColor = true;
            this.btnSeniorMale.Click += new System.EventHandler(this.btnSeniorMale_Click);
            // 
            // btnAdultMale
            // 
            this.btnAdultMale.Location = new System.Drawing.Point(2, 227);
            this.btnAdultMale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdultMale.Name = "btnAdultMale";
            this.btnAdultMale.Size = new System.Drawing.Size(283, 51);
            this.btnAdultMale.TabIndex = 2;
            this.btnAdultMale.Text = "Adult Male";
            this.btnAdultMale.UseVisualStyleBackColor = true;
            this.btnAdultMale.Click += new System.EventHandler(this.btnAdultMale_Click);
            // 
            // btnYouthMale
            // 
            this.btnYouthMale.Location = new System.Drawing.Point(2, 172);
            this.btnYouthMale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnYouthMale.Name = "btnYouthMale";
            this.btnYouthMale.Size = new System.Drawing.Size(283, 51);
            this.btnYouthMale.TabIndex = 1;
            this.btnYouthMale.Text = "Youth Male";
            this.btnYouthMale.UseVisualStyleBackColor = true;
            this.btnYouthMale.Click += new System.EventHandler(this.btnYouthMale_Click);
            // 
            // btnDefaultVideos
            // 
            this.btnDefaultVideos.Location = new System.Drawing.Point(2, 118);
            this.btnDefaultVideos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDefaultVideos.Name = "btnDefaultVideos";
            this.btnDefaultVideos.Size = new System.Drawing.Size(283, 51);
            this.btnDefaultVideos.TabIndex = 0;
            this.btnDefaultVideos.Text = "Default Videos";
            this.btnDefaultVideos.UseVisualStyleBackColor = true;
            this.btnDefaultVideos.Click += new System.EventHandler(this.btnDefaultVideos_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Window;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(910, 642);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(1204, 646);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Emergency Remote";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkFemaleFirst);
            this.groupBox3.Controls.Add(this.chkMaleFirst);
            this.groupBox3.Controls.Add(this.btnFemaleFirst);
            this.groupBox3.Controls.Add(this.btnMaleFirst);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(711, 419);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(471, 316);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gender Preference";
            // 
            // chkFemaleFirst
            // 
            this.chkFemaleFirst.AutoSize = true;
            this.chkFemaleFirst.Enabled = false;
            this.chkFemaleFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkFemaleFirst.Location = new System.Drawing.Point(223, 214);
            this.chkFemaleFirst.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkFemaleFirst.Name = "chkFemaleFirst";
            this.chkFemaleFirst.Size = new System.Drawing.Size(18, 17);
            this.chkFemaleFirst.TabIndex = 6;
            this.chkFemaleFirst.UseVisualStyleBackColor = true;
            // 
            // chkMaleFirst
            // 
            this.chkMaleFirst.AutoSize = true;
            this.chkMaleFirst.Checked = true;
            this.chkMaleFirst.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMaleFirst.Enabled = false;
            this.chkMaleFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkMaleFirst.Location = new System.Drawing.Point(223, 147);
            this.chkMaleFirst.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkMaleFirst.Name = "chkMaleFirst";
            this.chkMaleFirst.Size = new System.Drawing.Size(18, 17);
            this.chkMaleFirst.TabIndex = 5;
            this.chkMaleFirst.UseVisualStyleBackColor = true;
            // 
            // btnFemaleFirst
            // 
            this.btnFemaleFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnFemaleFirst.Location = new System.Drawing.Point(41, 195);
            this.btnFemaleFirst.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFemaleFirst.Name = "btnFemaleFirst";
            this.btnFemaleFirst.Size = new System.Drawing.Size(166, 52);
            this.btnFemaleFirst.TabIndex = 4;
            this.btnFemaleFirst.Text = "Female First";
            this.btnFemaleFirst.UseVisualStyleBackColor = true;
            this.btnFemaleFirst.Click += new System.EventHandler(this.btnFemaleFirst_Click);
            // 
            // btnMaleFirst
            // 
            this.btnMaleFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnMaleFirst.Location = new System.Drawing.Point(41, 128);
            this.btnMaleFirst.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMaleFirst.Name = "btnMaleFirst";
            this.btnMaleFirst.Size = new System.Drawing.Size(166, 49);
            this.btnMaleFirst.TabIndex = 3;
            this.btnMaleFirst.Text = "Male First";
            this.btnMaleFirst.UseVisualStyleBackColor = true;
            this.btnMaleFirst.Click += new System.EventHandler(this.btnMaleFirst_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 46);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(362, 34);
            this.label8.TabIndex = 2;
            this.label8.Text = "Please check one of the button to select the preference \r\nwhen equal number of ma" +
    "le and female are detected";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblConnectionStatus);
            this.groupBox2.Controls.Add(this.btnConnect);
            this.groupBox2.Location = new System.Drawing.Point(740, 17);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(443, 247);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Press this button to connect to video wall with analytics";
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.Location = new System.Drawing.Point(253, 131);
            this.lblConnectionStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(94, 17);
            this.lblConnectionStatus.TabIndex = 9;
            this.lblConnectionStatus.Text = "Disconnected";
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnConnect.Location = new System.Drawing.Point(12, 67);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(166, 154);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.richTxtMessage);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnReturn);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Location = new System.Drawing.Point(21, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(645, 728);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 264);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(291, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Stop the video wall with analytics immediately";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(378, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Shut down the emergency message and return to analytics";
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSend.Location = new System.Drawing.Point(259, 638);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(123, 86);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // richTxtMessage
            // 
            this.richTxtMessage.Location = new System.Drawing.Point(26, 403);
            this.richTxtMessage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTxtMessage.Name = "richTxtMessage";
            this.richTxtMessage.Size = new System.Drawing.Size(607, 233);
            this.richTxtMessage.TabIndex = 6;
            this.richTxtMessage.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 367);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(584, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "To send an emergency message, please type the message in the white box and press " +
    "send";
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnReturn.Location = new System.Drawing.Point(15, 35);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(139, 104);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnStop.Location = new System.Drawing.Point(15, 220);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(139, 104);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(48, 48);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // frmRemoteManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1212, 675);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmRemoteManager";
            this.Text = "Remote Manager";
            this.Load += new System.EventHandler(this.frmRemoteManager_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnSeniorFemale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCurrentSelection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnAdultFemale;
        private System.Windows.Forms.Button btnYouthFemale;
        private System.Windows.Forms.Button btnSeniorMale;
        private System.Windows.Forms.Button btnAdultMale;
        private System.Windows.Forms.Button btnYouthMale;
        private System.Windows.Forms.Button btnDefaultVideos;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox richTxtMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkFemaleFirst;
        private System.Windows.Forms.CheckBox chkMaleFirst;
        private System.Windows.Forms.Button btnFemaleFirst;
        private System.Windows.Forms.Button btnMaleFirst;
    }
}

