namespace SendMail_Beta
{
    partial class MailForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxTo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.btnAtt = new System.Windows.Forms.Button();
            this.btnCancelAtt = new System.Windows.Forms.Button();
            this.tbxMessage = new System.Windows.Forms.TextBox();
            this.tbxAtt = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbxPass = new System.Windows.Forms.TextBox();
            this.tbxSubject = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "To:";
            // 
            // tbxTo
            // 
            this.tbxTo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTo.Location = new System.Drawing.Point(184, 34);
            this.tbxTo.Multiline = true;
            this.tbxTo.Name = "tbxTo";
            this.tbxTo.Size = new System.Drawing.Size(331, 34);
            this.tbxTo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "Subject:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 35);
            this.label3.TabIndex = 0;
            this.label3.Text = "User:";
            // 
            // tbxUser
            // 
            this.tbxUser.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUser.Location = new System.Drawing.Point(184, 163);
            this.tbxUser.Multiline = true;
            this.tbxUser.Name = "tbxUser";
            this.tbxUser.Size = new System.Drawing.Size(331, 34);
            this.tbxUser.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 35);
            this.label4.TabIndex = 0;
            this.label4.Text = "Pass:";
            // 
            // btnBrowser
            // 
            this.btnBrowser.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBrowser.Location = new System.Drawing.Point(433, 45);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(82, 23);
            this.btnBrowser.TabIndex = 2;
            this.btnBrowser.Text = "Browser";
            this.btnBrowser.UseVisualStyleBackColor = false;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // btnAtt
            // 
            this.btnAtt.BackColor = System.Drawing.Color.Aquamarine;
            this.btnAtt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtt.Location = new System.Drawing.Point(383, 282);
            this.btnAtt.Name = "btnAtt";
            this.btnAtt.Size = new System.Drawing.Size(132, 45);
            this.btnAtt.TabIndex = 2;
            this.btnAtt.Text = "Attach";
            this.btnAtt.UseVisualStyleBackColor = false;
            this.btnAtt.Click += new System.EventHandler(this.btnAtt_Click);
            // 
            // btnCancelAtt
            // 
            this.btnCancelAtt.BackColor = System.Drawing.Color.Aquamarine;
            this.btnCancelAtt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAtt.Location = new System.Drawing.Point(245, 282);
            this.btnCancelAtt.Name = "btnCancelAtt";
            this.btnCancelAtt.Size = new System.Drawing.Size(132, 45);
            this.btnCancelAtt.TabIndex = 2;
            this.btnCancelAtt.Text = "Cancel Attach";
            this.btnCancelAtt.UseVisualStyleBackColor = false;
            this.btnCancelAtt.Click += new System.EventHandler(this.btnCancelAtt_Click);
            // 
            // tbxMessage
            // 
            this.tbxMessage.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMessage.Location = new System.Drawing.Point(184, 343);
            this.tbxMessage.Multiline = true;
            this.tbxMessage.Name = "tbxMessage";
            this.tbxMessage.Size = new System.Drawing.Size(331, 158);
            this.tbxMessage.TabIndex = 3;
            // 
            // tbxAtt
            // 
            this.tbxAtt.Location = new System.Drawing.Point(184, 507);
            this.tbxAtt.Multiline = true;
            this.tbxAtt.Name = "tbxAtt";
            this.tbxAtt.ReadOnly = true;
            this.tbxAtt.Size = new System.Drawing.Size(331, 59);
            this.tbxAtt.TabIndex = 1;
            this.tbxAtt.Text = "Đính kèm...";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(184, 582);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(331, 45);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send Message";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbxPass
            // 
            this.tbxPass.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPass.Location = new System.Drawing.Point(184, 226);
            this.tbxPass.Multiline = true;
            this.tbxPass.Name = "tbxPass";
            this.tbxPass.Size = new System.Drawing.Size(331, 34);
            this.tbxPass.TabIndex = 4;
            this.tbxPass.UseSystemPasswordChar = true;
            // 
            // tbxSubject
            // 
            this.tbxSubject.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSubject.Location = new System.Drawing.Point(184, 97);
            this.tbxSubject.Multiline = true;
            this.tbxSubject.Name = "tbxSubject";
            this.tbxSubject.Size = new System.Drawing.Size(331, 34);
            this.tbxSubject.TabIndex = 5;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(181, 298);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(56, 17);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Chờ gửi";
            // 
            // MailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(599, 656);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.tbxSubject);
            this.Controls.Add(this.tbxPass);
            this.Controls.Add(this.tbxMessage);
            this.Controls.Add(this.btnCancelAtt);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnAtt);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.tbxAtt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxTo);
            this.Controls.Add(this.label1);
            this.Name = "MailForm";
            this.Text = "Send Mail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.Button btnAtt;
        private System.Windows.Forms.Button btnCancelAtt;
        private System.Windows.Forms.TextBox tbxMessage;
        private System.Windows.Forms.TextBox tbxAtt;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbxPass;
        private System.Windows.Forms.TextBox tbxSubject;
        private System.Windows.Forms.Label lblStatus;
    }
}