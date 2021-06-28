using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.Properties.Forms
{
    public partial class CalculatorContentForm : Form
    {
        public Panel closeNavigationPanelPublic;
        public TextBox valueTextPublic, historyTextPublic;
        public CalculatorContentForm(){
            InitializeComponent();
            // Get Buttons
            getCalculatorButtonPage();

            // Init Public Elements
            valueTextPublic = valueText;
            historyTextPublic = historyText;

            // Click Events
            inputPanel.Click += new EventHandler(Form1.checkNavigationIsShowingHandler);
            valueText.Click += new EventHandler(Form1.checkNavigationIsShowingHandler);
        }

        private void CalculatorContentForm_Load(object sender, EventArgs e){
            // Show Ads
            bannerAds1.ShowAd(320, 50, "av94q66j9zgc");
        }

        private void CalculatorContentForm_Click(object sender, EventArgs e){
            // Check Navigation Menu
            Form1.checkNavigationIsShowingHandler(sender, e);
        }

        private void valueText_KeyPress(object sender, KeyPressEventArgs e){
            String getKeyChar = e.KeyChar.ToString();

            if (getKeyChar.Equals("+") ||
                getKeyChar.Equals("-") || 
                getKeyChar.Equals("/") ||
                getKeyChar.Equals("*") ||
                getKeyChar.Equals("%") ||
                getKeyChar.Equals(".")){
                if (valueText.TextLength > 0){
                    if (getKeyChar.Equals("*")){
                        e.Handled = true;
                        // Convert * symbol to x
                        valueText.Paste("x");
                        //valueText.Text = valueText.Text.Replace("*", "");
                        // Reset Variables for Next
                        CalculatorPage1.PROCESS_RESET_COLON = true;
                    }
                    else if (getKeyChar.Equals(".")){
                        e.Handled = true;
                        if (CalculatorPage1.PROCESS_RESET_COLON){
                            CalculatorPage1.PROCESS_RESET_COLON = false;
                            valueText.Paste(".");
                        }
                    }
                    else{
                        e.Handled = false;
                        // Reset Variables for Next
                        CalculatorPage1.PROCESS_RESET_COLON = true;
                    }
                }
                else
                    e.Handled = true;
            }
            else if(!char.IsDigit(e.KeyChar) && 
                !char.IsControl(e.KeyChar)){
                e.Handled = true;
            }
        }

        private void valueText_KeyDown(object sender, KeyEventArgs e){
            if (e.KeyCode == Keys.Enter)
                CalculatorPage1.equalsButtonClick(sender, e);
        }

        

        private void getCalculatorButtonPage(){
            // Get Calculator Buttons
            CalculatorPage1 calcButtonsPage1 = new CalculatorPage1();
            calcButtonsPage1.TopLevel = false;
            // Added form in panel.
            calcButtonPanel.Controls.Add(calcButtonsPage1);
            // Set Dock 'Fill'
            calcButtonsPage1.Dock = DockStyle.Fill;
            // Show Button Forms
            calcButtonsPage1.Show();
        }
    }
}
