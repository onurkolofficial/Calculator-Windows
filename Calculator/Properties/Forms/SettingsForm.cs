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
        private Form thisForm;
        public SettingsForm(){
            InitializeComponent();
        }
        private void SettingsForm_Load(object sender, EventArgs e){
            // Set Current Form
            thisForm = Form1.settingsPage;
            // Set Button Text
            aboutFormButton.Text = Form1.langResource.GetString("about_app_text") + 
                Environment.NewLine + Form1.langResource.GetString("about_app_summary");
        }

        public void onMenuBackPressed(){
            Form1.invalidatePage(thisForm, Form1.calculatorMain, 0);
        }
       
        private void aboutFormButton_Click(object sender, EventArgs e){
            // Open About Page
            Form1.invalidatePage(thisForm, Form1.settingsAboutPage, 2);
        }
    }
}
