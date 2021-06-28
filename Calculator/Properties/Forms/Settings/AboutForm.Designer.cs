
namespace Calculator.Properties.Forms.Settings
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.app_name_title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.app_version_title = new System.Windows.Forms.Label();
            this.app_version = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.app_contact_title = new System.Windows.Forms.Label();
            this.web_button = new System.Windows.Forms.Button();
            this.github_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Calculator.Properties.AppResources.app_icon_image;
            this.pictureBox1.Location = new System.Drawing.Point(15, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // app_name_title
            // 
            this.app_name_title.AutoSize = true;
            this.app_name_title.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.app_name_title.Location = new System.Drawing.Point(12, 97);
            this.app_name_title.Name = "app_name_title";
            this.app_name_title.Size = new System.Drawing.Size(116, 30);
            this.app_name_title.TabIndex = 1;
            this.app_name_title.Text = "APP_NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Onur KOL";
            // 
            // app_version_title
            // 
            this.app_version_title.AutoSize = true;
            this.app_version_title.Location = new System.Drawing.Point(3, 7);
            this.app_version_title.Name = "app_version_title";
            this.app_version_title.Size = new System.Drawing.Size(84, 15);
            this.app_version_title.TabIndex = 3;
            this.app_version_title.Text = "VERSION_TEXT";
            // 
            // app_version
            // 
            this.app_version.AutoSize = true;
            this.app_version.Location = new System.Drawing.Point(93, 7);
            this.app_version.Name = "app_version";
            this.app_version.Size = new System.Drawing.Size(54, 15);
            this.app_version.TabIndex = 4;
            this.app_version.Text = "VERSION";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.app_version_title);
            this.panel1.Controls.Add(this.app_version);
            this.panel1.Location = new System.Drawing.Point(12, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 29);
            this.panel1.TabIndex = 5;
            // 
            // app_contact_title
            // 
            this.app_contact_title.AutoSize = true;
            this.app_contact_title.Location = new System.Drawing.Point(15, 221);
            this.app_contact_title.Name = "app_contact_title";
            this.app_contact_title.Size = new System.Drawing.Size(90, 15);
            this.app_contact_title.TabIndex = 6;
            this.app_contact_title.Text = "CONTACT_TEXT";
            // 
            // web_button
            // 
            this.web_button.Location = new System.Drawing.Point(15, 254);
            this.web_button.Name = "web_button";
            this.web_button.Size = new System.Drawing.Size(323, 39);
            this.web_button.TabIndex = 7;
            this.web_button.Text = "Web";
            this.web_button.UseVisualStyleBackColor = true;
            this.web_button.Click += new System.EventHandler(this.web_button_Click);
            // 
            // github_button
            // 
            this.github_button.Location = new System.Drawing.Point(15, 299);
            this.github_button.Name = "github_button";
            this.github_button.Size = new System.Drawing.Size(323, 39);
            this.github_button.TabIndex = 8;
            this.github_button.Text = "Github";
            this.github_button.UseVisualStyleBackColor = true;
            this.github_button.Click += new System.EventHandler(this.github_button_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(-1, 205);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 1);
            this.panel2.TabIndex = 9;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(350, 454);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.github_button);
            this.Controls.Add(this.web_button);
            this.Controls.Add(this.app_contact_title);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.app_name_title);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AboutForm";
            this.Text = "AboutForm";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label app_name_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label app_version_title;
        private System.Windows.Forms.Label app_version;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label app_contact_title;
        private System.Windows.Forms.Button web_button;
        private System.Windows.Forms.Button github_button;
        private System.Windows.Forms.Panel panel2;
    }
}