
namespace Calculator.Properties.Forms
{
    partial class CalculatorContentForm
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
            this.valueText = new System.Windows.Forms.TextBox();
            this.historyText = new System.Windows.Forms.TextBox();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.calcButtonPanel = new System.Windows.Forms.Panel();
            this.inputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // valueText
            // 
            this.valueText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valueText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.valueText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valueText.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.valueText.Location = new System.Drawing.Point(12, 47);
            this.valueText.Name = "valueText";
            this.valueText.Size = new System.Drawing.Size(326, 32);
            this.valueText.TabIndex = 1;
            this.valueText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.valueText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.valueText_KeyDown);
            this.valueText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valueText_KeyPress);
            // 
            // historyText
            // 
            this.historyText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.historyText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.historyText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.historyText.Cursor = System.Windows.Forms.Cursors.Default;
            this.historyText.Enabled = false;
            this.historyText.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.historyText.Location = new System.Drawing.Point(12, 16);
            this.historyText.Name = "historyText";
            this.historyText.Size = new System.Drawing.Size(326, 20);
            this.historyText.TabIndex = 0;
            this.historyText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // inputPanel
            // 
            this.inputPanel.Controls.Add(this.historyText);
            this.inputPanel.Controls.Add(this.valueText);
            this.inputPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.inputPanel.Location = new System.Drawing.Point(0, 0);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(350, 100);
            this.inputPanel.TabIndex = 5;
            // 
            // calcButtonPanel
            // 
            this.calcButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.calcButtonPanel.Location = new System.Drawing.Point(0, 144);
            this.calcButtonPanel.Name = "calcButtonPanel";
            this.calcButtonPanel.Size = new System.Drawing.Size(350, 310);
            this.calcButtonPanel.TabIndex = 4;
            // 
            // CalculatorContentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(350, 454);
            this.Controls.Add(this.inputPanel);
            this.Controls.Add(this.calcButtonPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CalculatorContentForm";
            this.Text = "CalculatorContentForm";
            this.Click += new System.EventHandler(this.CalculatorContentForm_Click);
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox valueText;
        private System.Windows.Forms.TextBox historyText;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.Panel calcButtonPanel;
    }
}