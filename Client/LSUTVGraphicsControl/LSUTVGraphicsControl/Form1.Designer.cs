﻿namespace LSUTVGraphicsControl {
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
            this.filePanel = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.serverStatus = new System.Windows.Forms.Label();
            this.dissolveGraphicsBtn = new System.Windows.Forms.Button();
            this.clearChannelBtn = new System.Windows.Forms.Button();
            this.programTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.programStartField = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.serverAddressField = new System.Windows.Forms.TextBox();
            this.connectServerBtn = new System.Windows.Forms.Button();
            this.showTitleCardBtn = new System.Windows.Forms.Button();
            this.showCountdownL3Btn = new System.Windows.Forms.Button();
            this.programTitleField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.Panel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.Label();
            this.filePanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.filePanel.Size = new System.Drawing.Size(885, 29);
            this.filePanel.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(885, 468);
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(877, 442);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // dissolveGraphicsBtn
            // 
            this.dissolveGraphicsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dissolveGraphicsBtn.Location = new System.Drawing.Point(605, 3);
            this.dissolveGraphicsBtn.Name = "dissolveGraphicsBtn";
            this.dissolveGraphicsBtn.Size = new System.Drawing.Size(131, 23);
            this.dissolveGraphicsBtn.TabIndex = 1;
            this.dissolveGraphicsBtn.Text = "Dissolve Graphics (F1)";
            this.dissolveGraphicsBtn.UseVisualStyleBackColor = true;
            this.dissolveGraphicsBtn.Click += new System.EventHandler(this.dissolveGraphicsBtn_Click);
            // 
            // clearChannelBtn
            // 
            this.clearChannelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearChannelBtn.Location = new System.Drawing.Point(742, 3);
            this.clearChannelBtn.Name = "clearChannelBtn";
            this.clearChannelBtn.Size = new System.Drawing.Size(131, 23);
            this.clearChannelBtn.TabIndex = 2;
            this.clearChannelBtn.Text = "Clear Channel (ESC)";
            this.clearChannelBtn.UseVisualStyleBackColor = true;
            this.clearChannelBtn.Click += new System.EventHandler(this.clearChannelBtn_Click);
            // 
            // programTime
            // 
            this.programTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.programTime.AutoSize = true;
            this.programTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.programTime.Location = new System.Drawing.Point(519, 3);
            this.programTime.Name = "programTime";
            this.programTime.Size = new System.Drawing.Size(80, 24);
            this.programTime.TabIndex = 3;
            this.programTime.Text = "00:00:00";
            this.programTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(422, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "PROGRAM TIME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // programStartField
            // 
            this.programStartField.CustomFormat = "yyyy-MM-dd HH:mm";
            this.programStartField.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.programStartField.Location = new System.Drawing.Point(142, 15);
            this.programStartField.Name = "programStartField";
            this.programStartField.Size = new System.Drawing.Size(200, 20);
            this.programStartField.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.programTitleField);
            this.panel1.Controls.Add(this.showCountdownL3Btn);
            this.panel1.Controls.Add(this.showTitleCardBtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.programStartField);
            this.panel1.Location = new System.Drawing.Point(11, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 150);
            this.panel1.TabIndex = 2;
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
            // serverAddressField
            // 
            this.serverAddressField.Location = new System.Drawing.Point(91, 5);
            this.serverAddressField.Name = "serverAddressField";
            this.serverAddressField.Size = new System.Drawing.Size(153, 20);
            this.serverAddressField.TabIndex = 1;
            this.serverAddressField.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // showTitleCardBtn
            // 
            this.showTitleCardBtn.Location = new System.Drawing.Point(22, 89);
            this.showTitleCardBtn.Name = "showTitleCardBtn";
            this.showTitleCardBtn.Size = new System.Drawing.Size(155, 44);
            this.showTitleCardBtn.TabIndex = 2;
            this.showTitleCardBtn.Text = "Title Card";
            this.showTitleCardBtn.UseVisualStyleBackColor = true;
            this.showTitleCardBtn.Click += new System.EventHandler(this.showTitleCardBtn_Click);
            // 
            // showCountdownL3Btn
            // 
            this.showCountdownL3Btn.Location = new System.Drawing.Point(184, 89);
            this.showCountdownL3Btn.Name = "showCountdownL3Btn";
            this.showCountdownL3Btn.Size = new System.Drawing.Size(158, 44);
            this.showCountdownL3Btn.TabIndex = 3;
            this.showCountdownL3Btn.Text = "Countdown L3";
            this.showCountdownL3Btn.UseVisualStyleBackColor = true;
            this.showCountdownL3Btn.Click += new System.EventHandler(this.showCountdownL3Btn_Click);
            // 
            // programTitleField
            // 
            this.programTitleField.Location = new System.Drawing.Point(142, 54);
            this.programTitleField.Name = "programTitleField";
            this.programTitleField.Size = new System.Drawing.Size(200, 20);
            this.programTitleField.TabIndex = 4;
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
            // statusStrip1
            // 
            this.statusStrip1.Controls.Add(this.toolStripStatusLabel1);
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusStrip1.Location = new System.Drawing.Point(0, 467);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(885, 30);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 497);
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
    }
}
