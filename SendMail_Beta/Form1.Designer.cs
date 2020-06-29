namespace SendMail_Beta
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnAbout = new FontAwesome.Sharp.IconButton();
            this.btnMail = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnAbout);
            this.panelMenu.Controls.Add(this.btnMail);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 792);
            this.panelMenu.TabIndex = 0;
            // 
            // btnAbout
            // 
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAbout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAbout.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.btnAbout.IconColor = System.Drawing.Color.White;
            this.btnAbout.IconSize = 42;
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(0, 214);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAbout.Rotation = 0D;
            this.btnAbout.Size = new System.Drawing.Size(220, 74);
            this.btnAbout.TabIndex = 1;
            this.btnAbout.Text = "About";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnMail
            // 
            this.btnMail.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMail.FlatAppearance.BorderSize = 0;
            this.btnMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMail.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMail.IconChar = FontAwesome.Sharp.IconChar.EnvelopeOpenText;
            this.btnMail.IconColor = System.Drawing.Color.White;
            this.btnMail.IconSize = 42;
            this.btnMail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMail.Location = new System.Drawing.Point(0, 140);
            this.btnMail.Name = "btnMail";
            this.btnMail.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMail.Rotation = 0D;
            this.btnMail.Size = new System.Drawing.Size(220, 74);
            this.btnMail.TabIndex = 0;
            this.btnMail.Text = "Send Mail";
            this.btnMail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMail.UseVisualStyleBackColor = true;
            this.btnMail.Click += new System.EventHandler(this.btnMail_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitle.Controls.Add(this.lblTitleChildForm);
            this.panelTitle.Controls.Add(this.iconCurrentChildForm);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(220, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(597, 80);
            this.panelTitle.TabIndex = 1;
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(73, 37);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(45, 17);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.Gainsboro;
            this.iconCurrentChildForm.IconSize = 44;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(16, 23);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(51, 44);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 80);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(597, 10);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 90);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(597, 702);
            this.panelDesktop.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 792);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnAbout;
        private FontAwesome.Sharp.IconButton btnMail;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTitle;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
    }
}

