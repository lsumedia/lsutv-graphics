namespace LSUTVGraphicsControl {
    partial class ControlForm {
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
            this.connectServerBtn = new System.Windows.Forms.Button();
            this.serverAddressField = new System.Windows.Forms.TextBox();
            this.clearChannelBtn = new System.Windows.Forms.Button();
            this.dissolveGraphicsBtn = new System.Windows.Forms.Button();
            this.serverStatus = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.Panel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.Label();
            this.filePanel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // filePanel
            // 
            this.filePanel.Controls.Add(this.connectServerBtn);
            this.filePanel.Controls.Add(this.serverAddressField);
            this.filePanel.Controls.Add(this.clearChannelBtn);
            this.filePanel.Controls.Add(this.dissolveGraphicsBtn);
            this.filePanel.Controls.Add(this.serverStatus);
            this.filePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.filePanel.Location = new System.Drawing.Point(0, 0);
            this.filePanel.Name = "filePanel";
            this.filePanel.Size = new System.Drawing.Size(1014, 29);
            this.filePanel.TabIndex = 1;
            // 
            // connectServerBtn
            // 
            this.connectServerBtn.Location = new System.Drawing.Point(250, 4);
            this.connectServerBtn.Name = "connectServerBtn";
            this.connectServerBtn.Size = new System.Drawing.Size(144, 21);
            this.connectServerBtn.TabIndex = 2;
            this.connectServerBtn.Text = "Connect";
            this.connectServerBtn.UseVisualStyleBackColor = true;
            // 
            // serverAddressField
            // 
            this.serverAddressField.Location = new System.Drawing.Point(91, 5);
            this.serverAddressField.Name = "serverAddressField";
            this.serverAddressField.Size = new System.Drawing.Size(153, 20);
            this.serverAddressField.TabIndex = 1;
            // 
            // clearChannelBtn
            // 
            this.clearChannelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearChannelBtn.Location = new System.Drawing.Point(871, 3);
            this.clearChannelBtn.Name = "clearChannelBtn";
            this.clearChannelBtn.Size = new System.Drawing.Size(131, 23);
            this.clearChannelBtn.TabIndex = 2;
            this.clearChannelBtn.Text = "Clear Channel (ESC)";
            this.clearChannelBtn.UseVisualStyleBackColor = true;
            // 
            // dissolveGraphicsBtn
            // 
            this.dissolveGraphicsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dissolveGraphicsBtn.Location = new System.Drawing.Point(734, 3);
            this.dissolveGraphicsBtn.Name = "dissolveGraphicsBtn";
            this.dissolveGraphicsBtn.Size = new System.Drawing.Size(131, 23);
            this.dissolveGraphicsBtn.TabIndex = 1;
            this.dissolveGraphicsBtn.Text = "Dissolve Graphics (F1)";
            this.dissolveGraphicsBtn.UseVisualStyleBackColor = true;
            // 
            // serverStatus
            // 
            this.serverStatus.AutoSize = true;
            this.serverStatus.Location = new System.Drawing.Point(11, 8);
            this.serverStatus.Name = "serverStatus";
            this.serverStatus.Size = new System.Drawing.Size(74, 13);
            this.serverStatus.TabIndex = 0;
            this.serverStatus.Text = "Caspar Server";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Controls.Add(this.toolStripStatusLabel1);
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusStrip1.Location = new System.Drawing.Point(0, 567);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1014, 30);
            this.statusStrip1.TabIndex = 4;
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
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 597);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.filePanel);
            this.Name = "ControlForm";
            this.Text = "ControlForm";
            this.filePanel.ResumeLayout(false);
            this.filePanel.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel filePanel;
        private System.Windows.Forms.Button connectServerBtn;
        private System.Windows.Forms.TextBox serverAddressField;
        private System.Windows.Forms.Button clearChannelBtn;
        private System.Windows.Forms.Button dissolveGraphicsBtn;
        private System.Windows.Forms.Label serverStatus;
        private System.Windows.Forms.Panel statusStrip1;
        private System.Windows.Forms.Label toolStripStatusLabel1;
    }
}