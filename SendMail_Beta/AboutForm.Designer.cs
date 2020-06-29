namespace SendMail_Beta
{
    partial class AboutForm
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
            this.btnFacebook = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // btnFacebook
            // 
            this.btnFacebook.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnFacebook.Font = new System.Drawing.Font("Arial Narrow", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacebook.IconChar = FontAwesome.Sharp.IconChar.Facebook;
            this.btnFacebook.IconColor = System.Drawing.Color.Black;
            this.btnFacebook.IconSize = 80;
            this.btnFacebook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacebook.Location = new System.Drawing.Point(87, 53);
            this.btnFacebook.Name = "btnFacebook";
            this.btnFacebook.Rotation = 0D;
            this.btnFacebook.Size = new System.Drawing.Size(390, 85);
            this.btnFacebook.TabIndex = 0;
            this.btnFacebook.Text = "Facebook";
            this.btnFacebook.UseVisualStyleBackColor = true;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 656);
            this.Controls.Add(this.btnFacebook);
            this.Name = "AboutForm";
            this.Text = "About";
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnFacebook;
    }
}