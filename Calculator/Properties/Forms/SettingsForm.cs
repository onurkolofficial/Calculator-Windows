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
    public partial class SettingsForm : Form
    {

        public int testval;
        public SettingsForm(){
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e){
            initToolbarButtons();
        }

        private void initToolbarButtons(){
            // Button Clicks
            Form1.toolbarBackButtonStatic.Click += new EventHandler(closeSettingsClick);
        }

        private void closeSettingsClick(object sender, EventArgs e){
            Form1.getMainPage();
        }

    }
}
