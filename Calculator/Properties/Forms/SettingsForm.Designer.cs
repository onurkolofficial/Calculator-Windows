
namespace Calculator.Properties.Forms
{
    partial class SettingsForm
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
            this.aboutFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aboutFormButton
            // 
            this.aboutFormButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.aboutFormButton.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aboutFormButton.Image = global::Calculator.Properties.AppResources.app_about_light;
            this.aboutFormButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutFormButton.Location = new System.Drawing.Point(0, 0);
            this.aboutFormButton.Name = "aboutFormButton";
            this.aboutFormButton.Size = new System.Drawing.Size(350, 50);
            this.aboutFormButton.TabIndex = 0;
            this.aboutFormButton.Text = "ABOUT_TEXT";
            this.aboutFormButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutFormButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.aboutFormButton.UseVisualStyleBackColor = true;
            this.aboutFormButton.Click += new System.EventHandler(this.aboutFormButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(350, 454);
            this.Controls.Add(this.aboutFormButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button aboutFormButton;
    }
}