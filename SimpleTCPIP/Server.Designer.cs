using System;

namespace SimpleTCPIP
{
    partial class Server
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
            this.startBtn = new System.Windows.Forms.Button();
            this.hostLabel = new System.Windows.Forms.Label();
            this.hostIPTxt = new System.Windows.Forms.TextBox();
            this.stopBtn = new System.Windows.Forms.Button();
            this.hostPortTxt = new System.Windows.Forms.TextBox();
            this.hostPortLabel = new System.Windows.Forms.Label();
            this.statusTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(527, 34);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 36);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.UseWaitCursor = true;
            this.startBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // hostLabel
            // 
            this.hostLabel.AutoSize = true;
            this.hostLabel.Location = new System.Drawing.Point(46, 42);
            this.hostLabel.Name = "hostLabel";
            this.hostLabel.Size = new System.Drawing.Size(47, 20);
            this.hostLabel.TabIndex = 1;
            this.hostLabel.Text = "Host:";
            this.hostLabel.UseWaitCursor = true;
            // 
            // hostIPTxt
            // 
            this.hostIPTxt.Location = new System.Drawing.Point(107, 39);
            this.hostIPTxt.Name = "hostIPTxt";
            this.hostIPTxt.Size = new System.Drawing.Size(214, 26);
            this.hostIPTxt.TabIndex = 2;
            this.hostIPTxt.Text = "127.0.0.1";
            this.hostIPTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hostIPTxt.UseWaitCursor = true;
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(608, 34);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(75, 36);
            this.stopBtn.TabIndex = 3;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.UseWaitCursor = true;
            this.stopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // hostPortTxt
            // 
            this.hostPortTxt.Location = new System.Drawing.Point(403, 39);
            this.hostPortTxt.Name = "hostPortTxt";
            this.hostPortTxt.Size = new System.Drawing.Size(99, 26);
            this.hostPortTxt.TabIndex = 5;
            this.hostPortTxt.Text = "8910";
            this.hostPortTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hostPortTxt.UseWaitCursor = true;
            // 
            // hostPortLabel
            // 
            this.hostPortLabel.AutoSize = true;
            this.hostPortLabel.Location = new System.Drawing.Point(342, 42);
            this.hostPortLabel.Name = "hostPortLabel";
            this.hostPortLabel.Size = new System.Drawing.Size(42, 20);
            this.hostPortLabel.TabIndex = 4;
            this.hostPortLabel.Text = "Port:";
            this.hostPortLabel.UseWaitCursor = true;
            // 
            // statusTxt
            // 
            this.statusTxt.Location = new System.Drawing.Point(50, 87);
            this.statusTxt.Multiline = true;
            this.statusTxt.Name = "statusTxt";
            this.statusTxt.Size = new System.Drawing.Size(633, 301);
            this.statusTxt.TabIndex = 6;
            this.statusTxt.UseWaitCursor = true;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 423);
            this.Controls.Add(this.statusTxt);
            this.Controls.Add(this.hostPortTxt);
            this.Controls.Add(this.hostPortLabel);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.hostIPTxt);
            this.Controls.Add(this.hostLabel);
            this.Controls.Add(this.startBtn);
            this.Name = "Server";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server";
            this.UseWaitCursor = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Server_FormClosed);
            this.Load += new System.EventHandler(this.ServerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label hostLabel;
        private System.Windows.Forms.TextBox hostIPTxt;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.TextBox hostPortTxt;
        private System.Windows.Forms.Label hostPortLabel;
        private System.Windows.Forms.TextBox statusTxt;
    }
}

