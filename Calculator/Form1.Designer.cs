
namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dragPanel = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.exitAppButton = new System.Windows.Forms.Button();
            this.toolbar_title = new System.Windows.Forms.Label();
            this.appContentPanel = new System.Windows.Forms.Panel();
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.settingsButton = new System.Windows.Forms.Button();
            this.dragPanel.SuspendLayout();
            this.appContentPanel.SuspendLayout();
            this.navigationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dragPanel
            // 
            this.dragPanel.Controls.Add(this.backButton);
            this.dragPanel.Controls.Add(this.menuButton);
            this.dragPanel.Controls.Add(this.exitAppButton);
            this.dragPanel.Controls.Add(this.toolbar_title);
            this.dragPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dragPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dragPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.dragPanel.Location = new System.Drawing.Point(0, 0);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.Size = new System.Drawing.Size(350, 46);
            this.dragPanel.TabIndex = 1;
            this.dragPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolbarScrollMouseDown);
            // 
            // backButton
            // 
            this.backButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Image = global::Calculator.Properties.AppResources.back_button;
            this.backButton.Location = new System.Drawing.Point(46, 0);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(46, 46);
            this.backButton.TabIndex = 3;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Visible = false;
            // 
            // menuButton
            // 
            this.menuButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuButton.FlatAppearance.BorderSize = 0;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Image = global::Calculator.Properties.AppResources.menu_button;
            this.menuButton.Location = new System.Drawing.Point(0, 0);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(46, 46);
            this.menuButton.TabIndex = 2;
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // exitAppButton
            // 
            this.exitAppButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitAppButton.FlatAppearance.BorderSize = 0;
            this.exitAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitAppButton.Image = global::Calculator.Properties.AppResources.close_button;
            this.exitAppButton.Location = new System.Drawing.Point(304, 0);
            this.exitAppButton.Name = "exitAppButton";
            this.exitAppButton.Size = new System.Drawing.Size(46, 46);
            this.exitAppButton.TabIndex = 2;
            this.exitAppButton.UseVisualStyleBackColor = true;
            this.exitAppButton.Click += new System.EventHandler(this.exitAppButton_Click);
            // 
            // toolbar_title
            // 
            this.toolbar_title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolbar_title.AutoSize = true;
            this.toolbar_title.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolbar_title.Location = new System.Drawing.Point(52, 9);
            this.toolbar_title.Name = "toolbar_title";
            this.toolbar_title.Size = new System.Drawing.Size(150, 25);
            this.toolbar_title.TabIndex = 0;
            this.toolbar_title.Text = "TOOLBAR_NAME";
            this.toolbar_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolbarScrollMouseDown);
            // 
            // appContentPanel
            // 
            this.appContentPanel.Controls.Add(this.navigationPanel);
            this.appContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appContentPanel.Location = new System.Drawing.Point(0, 46);
            this.appContentPanel.Name = "appContentPanel";
            this.appContentPanel.Size = new System.Drawing.Size(350, 454);
            this.appContentPanel.TabIndex = 5;
            this.appContentPanel.Click += new System.EventHandler(this.checkNavigationIsShowing);
            // 
            // navigationPanel
            // 
            this.navigationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.navigationPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.navigationPanel.Controls.Add(this.settingsButton);
            this.navigationPanel.Location = new System.Drawing.Point(0, 0);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(179, 454);
            this.navigationPanel.TabIndex = 4;
            // 
            // settingsButton
            // 
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Image = global::Calculator.Properties.AppResources.app_settings_light;
            this.settingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.Location = new System.Drawing.Point(0, 0);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(179, 32);
            this.settingsButton.TabIndex = 0;
            this.settingsButton.Text = "SETTINGS_TEXT";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(350, 500);
            this.Controls.Add(this.appContentPanel);
            this.Controls.Add(this.dragPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.dragPanel.ResumeLayout(false);
            this.dragPanel.PerformLayout();
            this.appContentPanel.ResumeLayout(false);
            this.navigationPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel dragPanel;
        public System.Windows.Forms.Label toolbar_title;
        private System.Windows.Forms.Button exitAppButton;
        private System.Windows.Forms.Panel appContentPanel;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Button settingsButton;
        public System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.Button backButton;
    }
}

