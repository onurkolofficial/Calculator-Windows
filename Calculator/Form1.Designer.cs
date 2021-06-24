
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
            this.button1 = new System.Windows.Forms.Button();
            this.app_title = new System.Windows.Forms.Label();
            this.appContentPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.valueText = new System.Windows.Forms.TextBox();
            this.historyText = new System.Windows.Forms.TextBox();
            this.calcButtonPanel = new System.Windows.Forms.Panel();
            this.dragPanel.SuspendLayout();
            this.appContentPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dragPanel
            // 
            this.dragPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dragPanel.Controls.Add(this.button1);
            this.dragPanel.Controls.Add(this.app_title);
            this.dragPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dragPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.dragPanel.Location = new System.Drawing.Point(0, 0);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.Size = new System.Drawing.Size(338, 46);
            this.dragPanel.TabIndex = 1;
            this.dragPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseDown);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(291, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 42);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // app_title
            // 
            this.app_title.AutoSize = true;
            this.app_title.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.app_title.Location = new System.Drawing.Point(12, 9);
            this.app_title.Name = "app_title";
            this.app_title.Size = new System.Drawing.Size(103, 25);
            this.app_title.TabIndex = 0;
            this.app_title.Text = "APP_NAME";
            // 
            // appContentPanel
            // 
            this.appContentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appContentPanel.Controls.Add(this.panel2);
            this.appContentPanel.Controls.Add(this.calcButtonPanel);
            this.appContentPanel.Location = new System.Drawing.Point(0, 49);
            this.appContentPanel.Name = "appContentPanel";
            this.appContentPanel.Size = new System.Drawing.Size(338, 401);
            this.appContentPanel.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.valueText);
            this.panel2.Controls.Add(this.historyText);
            this.panel2.Location = new System.Drawing.Point(3, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 88);
            this.panel2.TabIndex = 4;
            // 
            // valueText
            // 
            this.valueText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.valueText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valueText.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.valueText.Location = new System.Drawing.Point(12, 42);
            this.valueText.Name = "valueText";
            this.valueText.Size = new System.Drawing.Size(314, 32);
            this.valueText.TabIndex = 1;
            this.valueText.Text = "TEST";
            this.valueText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // historyText
            // 
            this.historyText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.historyText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.historyText.Cursor = System.Windows.Forms.Cursors.Default;
            this.historyText.Enabled = false;
            this.historyText.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.historyText.Location = new System.Drawing.Point(12, 13);
            this.historyText.Name = "historyText";
            this.historyText.Size = new System.Drawing.Size(314, 16);
            this.historyText.TabIndex = 0;
            this.historyText.Text = "TEST";
            this.historyText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // calcButtonPanel
            // 
            this.calcButtonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calcButtonPanel.Location = new System.Drawing.Point(3, 95);
            this.calcButtonPanel.Name = "calcButtonPanel";
            this.calcButtonPanel.Size = new System.Drawing.Size(332, 304);
            this.calcButtonPanel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(338, 450);
            this.Controls.Add(this.appContentPanel);
            this.Controls.Add(this.dragPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.dragPanel.ResumeLayout(false);
            this.dragPanel.PerformLayout();
            this.appContentPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel dragPanel;
        private System.Windows.Forms.Label app_title;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel appContentPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox valueText;
        private System.Windows.Forms.TextBox historyText;
        private System.Windows.Forms.Panel calcButtonPanel;
    }
}

