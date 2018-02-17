namespace LSUTVGraphicsControl {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.filePanel = new System.Windows.Forms.Panel();
            this.connectServerBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.serverAddressField = new System.Windows.Forms.TextBox();
            this.programTime = new System.Windows.Forms.Label();
            this.clearChannelBtn = new System.Windows.Forms.Button();
            this.dissolveGraphicsBtn = new System.Windows.Forms.Button();
            this.serverStatus = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.updateTimerBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.programTitleField = new System.Windows.Forms.TextBox();
            this.showCountdownL3Btn = new System.Windows.Forms.Button();
            this.showTitleCardBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.programStartField = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.statusStrip1 = new System.Windows.Forms.Panel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.listView1 = new System.Windows.Forms.ListView();
            this.filePanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // filePanel
            // 
            this.filePanel.Controls.Add(this.connectServerBtn);
            this.filePanel.Controls.Add(this.label1);
            this.filePanel.Controls.Add(this.serverAddressField);
            this.filePanel.Controls.Add(this.programTime);
            this.filePanel.Controls.Add(this.clearChannelBtn);
            this.filePanel.Controls.Add(this.dissolveGraphicsBtn);
            this.filePanel.Controls.Add(this.serverStatus);
            this.filePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.filePanel.Location = new System.Drawing.Point(0, 0);
            this.filePanel.Name = "filePanel";
            this.filePanel.Size = new System.Drawing.Size(1059, 29);
            this.filePanel.TabIndex = 0;
            // 
            // connectServerBtn
            // 
            this.connectServerBtn.Location = new System.Drawing.Point(250, 4);
            this.connectServerBtn.Name = "connectServerBtn";
            this.connectServerBtn.Size = new System.Drawing.Size(144, 21);
            this.connectServerBtn.TabIndex = 2;
            this.connectServerBtn.Text = "Connect";
            this.connectServerBtn.UseVisualStyleBackColor = true;
            this.connectServerBtn.Click += new System.EventHandler(this.connectServerBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(596, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "PROGRAM TIME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // serverAddressField
            // 
            this.serverAddressField.Location = new System.Drawing.Point(91, 5);
            this.serverAddressField.Name = "serverAddressField";
            this.serverAddressField.Size = new System.Drawing.Size(153, 20);
            this.serverAddressField.TabIndex = 1;
            this.serverAddressField.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // programTime
            // 
            this.programTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.programTime.AutoSize = true;
            this.programTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.programTime.Location = new System.Drawing.Point(693, 3);
            this.programTime.Name = "programTime";
            this.programTime.Size = new System.Drawing.Size(80, 24);
            this.programTime.TabIndex = 3;
            this.programTime.Text = "00:00:00";
            this.programTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // clearChannelBtn
            // 
            this.clearChannelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearChannelBtn.Location = new System.Drawing.Point(916, 3);
            this.clearChannelBtn.Name = "clearChannelBtn";
            this.clearChannelBtn.Size = new System.Drawing.Size(131, 23);
            this.clearChannelBtn.TabIndex = 2;
            this.clearChannelBtn.Text = "Clear Channel (ESC)";
            this.clearChannelBtn.UseVisualStyleBackColor = true;
            this.clearChannelBtn.Click += new System.EventHandler(this.clearChannelBtn_Click);
            // 
            // dissolveGraphicsBtn
            // 
            this.dissolveGraphicsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dissolveGraphicsBtn.Location = new System.Drawing.Point(779, 3);
            this.dissolveGraphicsBtn.Name = "dissolveGraphicsBtn";
            this.dissolveGraphicsBtn.Size = new System.Drawing.Size(131, 23);
            this.dissolveGraphicsBtn.TabIndex = 1;
            this.dissolveGraphicsBtn.Text = "Dissolve Graphics (F1)";
            this.dissolveGraphicsBtn.UseVisualStyleBackColor = true;
            this.dissolveGraphicsBtn.Click += new System.EventHandler(this.dissolveGraphicsBtn_Click);
            // 
            // serverStatus
            // 
            this.serverStatus.AutoSize = true;
            this.serverStatus.Location = new System.Drawing.Point(11, 8);
            this.serverStatus.Name = "serverStatus";
            this.serverStatus.Size = new System.Drawing.Size(74, 13);
            this.serverStatus.TabIndex = 0;
            this.serverStatus.Text = "Caspar Server";
            this.serverStatus.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1059, 634);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(877, 442);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Setup";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.updateTimerBtn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.programTitleField);
            this.panel1.Controls.Add(this.showCountdownL3Btn);
            this.panel1.Controls.Add(this.showTitleCardBtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.programStartField);
            this.panel1.Location = new System.Drawing.Point(11, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 218);
            this.panel1.TabIndex = 2;
            // 
            // updateTimerBtn
            // 
            this.updateTimerBtn.Location = new System.Drawing.Point(22, 150);
            this.updateTimerBtn.Name = "updateTimerBtn";
            this.updateTimerBtn.Size = new System.Drawing.Size(320, 48);
            this.updateTimerBtn.TabIndex = 6;
            this.updateTimerBtn.Text = "Save changes";
            this.updateTimerBtn.UseVisualStyleBackColor = true;
            this.updateTimerBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Program Title";
            // 
            // programTitleField
            // 
            this.programTitleField.Location = new System.Drawing.Point(142, 54);
            this.programTitleField.Name = "programTitleField";
            this.programTitleField.Size = new System.Drawing.Size(200, 20);
            this.programTitleField.TabIndex = 2;
            // 
            // showCountdownL3Btn
            // 
            this.showCountdownL3Btn.Location = new System.Drawing.Point(184, 89);
            this.showCountdownL3Btn.Name = "showCountdownL3Btn";
            this.showCountdownL3Btn.Size = new System.Drawing.Size(158, 44);
            this.showCountdownL3Btn.TabIndex = 4;
            this.showCountdownL3Btn.Text = "Countdown L3";
            this.showCountdownL3Btn.UseVisualStyleBackColor = true;
            this.showCountdownL3Btn.Click += new System.EventHandler(this.showCountdownL3Btn_Click);
            // 
            // showTitleCardBtn
            // 
            this.showTitleCardBtn.Location = new System.Drawing.Point(22, 89);
            this.showTitleCardBtn.Name = "showTitleCardBtn";
            this.showTitleCardBtn.Size = new System.Drawing.Size(155, 44);
            this.showTitleCardBtn.TabIndex = 3;
            this.showTitleCardBtn.Text = "Title Card";
            this.showTitleCardBtn.UseVisualStyleBackColor = true;
            this.showTitleCardBtn.Click += new System.EventHandler(this.showTitleCardBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Program Start Time";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // programStartField
            // 
            this.programStartField.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.programStartField.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.programStartField.Location = new System.Drawing.Point(142, 15);
            this.programStartField.Name = "programStartField";
            this.programStartField.Size = new System.Drawing.Size(200, 20);
            this.programStartField.TabIndex = 1;
            this.programStartField.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1051, 608);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listView1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1045, 602);
            this.splitContainer1.SplitterDistance = 227;
            this.splitContainer1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Controls.Add(this.toolStripStatusLabel1);
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusStrip1.Location = new System.Drawing.Point(0, 633);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1059, 30);
            this.statusStrip1.TabIndex = 3;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = true;
            this.toolStripStatusLabel1.Location = new System.Drawing.Point(7, 8);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(73, 13);
            this.toolStripStatusLabel1.TabIndex = 0;
            this.toolStripStatusLabel1.Text = "Disconnected";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(224, 584);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 663);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.filePanel);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "Form1";
            this.Text = "LSUTV Graphics Control";
            this.filePanel.ResumeLayout(false);
            this.filePanel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel filePanel;
        private System.Windows.Forms.Label serverStatus;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button clearChannelBtn;
        private System.Windows.Forms.Button dissolveGraphicsBtn;
        private System.Windows.Forms.Label programTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker programStartField;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox serverAddressField;
        private System.Windows.Forms.Button connectServerBtn;
        private System.Windows.Forms.Button showCountdownL3Btn;
        private System.Windows.Forms.Button showTitleCardBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox programTitleField;
        private System.Windows.Forms.Panel statusStrip1;
        private System.Windows.Forms.Label toolStripStatusLabel1;
        private System.Windows.Forms.Button updateTimerBtn;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ImageList imageList1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.ListView listView1;
    }
}

