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
        public CalculatorContentForm(){
            InitializeComponent();
            // Get Buttons
            getCalculatorButtonPage();

            // Focus Input
            ActiveControl = valueText;
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

        private static void checkNavigationIsShowing(object sender, EventArgs e){
            if (Form1.showNavigationStart){
                // Hide Navigation
                Form1.showNavigationStart = false;
                // Get Effect
                Tools.Animation.Effect effect = Tools.Animation.Effect.Roll;
                // Set Animation
                Tools.Animation.Animate(Form1.navigationPanelStatic, effect, 100, 360);
            }
        }
    }
}
