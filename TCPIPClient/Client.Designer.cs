namespace TCPIPClient
{
    partial class Client
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
            this.messageTxt = new System.Windows.Forms.TextBox();
            this.portTxt = new System.Windows.Forms.TextBox();
            this.hostPortLabel = new System.Windows.Forms.Label();
            this.sendBtn = new System.Windows.Forms.Button();
            this.hostIPTextBox = new System.Windows.Forms.TextBox();
            this.hostLabel = new System.Windows.Forms.Label();
            this.connectBtn = new System.Windows.Forms.Button();
            this.statusTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // messageTxt
            // 
            this.messageTxt.Location = new System.Drawing.Point(86, 101);
            this.messageTxt.Multiline = true;
            this.messageTxt.Name = "messageTxt";
            this.messageTxt.Size = new System.Drawing.Size(633, 63);
            this.messageTxt.TabIndex = 13;
            this.messageTxt.UseWaitCursor = true;
            // 
            // portTxt
            // 
            this.portTxt.Location = new System.Drawing.Point(439, 53);
            this.portTxt.Name = "portTxt";
            this.portTxt.Size = new System.Drawing.Size(99, 26);
            this.portTxt.TabIndex = 12;
            this.portTxt.Text = "8910";
            this.portTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.portTxt.UseWaitCursor = true;
            // 
            // hostPortLabel
            // 
            this.hostPortLabel.AutoSize = true;
            this.hostPortLabel.Location = new System.Drawing.Point(378, 56);
            this.hostPortLabel.Name = "hostPortLabel";
            this.hostPortLabel.Size = new System.Drawing.Size(42, 20);
            this.hostPortLabel.TabIndex = 11;
            this.hostPortLabel.Text = "Port:";
            this.hostPortLabel.UseWaitCursor = true;
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(626, 182);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(93, 36);
            this.sendBtn.TabIndex = 10;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.UseWaitCursor = true;
            this.sendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // hostIPTextBox
            // 
            this.hostIPTextBox.Location = new System.Drawing.Point(143, 53);
            this.hostIPTextBox.Name = "hostIPTextBox";
            this.hostIPTextBox.Size = new System.Drawing.Size(214, 26);
            this.hostIPTextBox.TabIndex = 9;
            this.hostIPTextBox.Text = "127.0.0.1";
            this.hostIPTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hostIPTextBox.UseWaitCursor = true;
            // 
            // hostLabel
            // 
            this.hostLabel.AutoSize = true;
            this.hostLabel.Location = new System.Drawing.Point(82, 56);
            this.hostLabel.Name = "hostLabel";
            this.hostLabel.Size = new System.Drawing.Size(47, 20);
            this.hostLabel.TabIndex = 8;
            this.hostLabel.Text = "Host:";
            this.hostLabel.UseWaitCursor = true;
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(563, 48);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(104, 36);
            this.connectBtn.TabIndex = 7;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.UseWaitCursor = true;
            this.connectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // statusTxt
            // 
            this.statusTxt.Location = new System.Drawing.Point(86, 236);
            this.statusTxt.Multiline = true;
            this.statusTxt.Name = "statusTxt";
            this.statusTxt.Size = new System.Drawing.Size(633, 253);
            this.statusTxt.TabIndex = 14;
            this.statusTxt.UseWaitCursor = true;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.statusTxt);
            this.Controls.Add(this.messageTxt);
            this.Controls.Add(this.portTxt);
            this.Controls.Add(this.hostPortLabel);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.hostIPTextBox);
            this.Controls.Add(this.hostLabel);
            this.Controls.Add(this.connectBtn);
            this.Name = "Client";
            this.Text = "Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Client_FormClosed);
            this.Load += new System.EventHandler(this.Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox messageTxt;
        private System.Windows.Forms.TextBox portTxt;
        private System.Windows.Forms.Label hostPortLabel;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.TextBox hostIPTextBox;
        private System.Windows.Forms.Label hostLabel;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.TextBox statusTxt;
    }
}

