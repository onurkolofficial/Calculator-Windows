using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace Calculator.Properties.Forms.Settings
{
    public partial class AboutForm : Form
    {
        private Form thisForm;
        public AboutForm(){
            InitializeComponent(); 
        }
        private void AboutForm_Load(object sender, EventArgs e){
            // Set Current Form
            thisForm = Form1.settingsAboutPage;
            // Set Text
            app_name_title.Text = Form1.langResource.GetString("app_name");
            app_contact_title.Text = Form1.langResource.GetString("contact_text");
            app_version_title.Text = Form1.langResource.GetString("version_text");

            // Get App Version
            app_version.Text = Application.ProductVersion;
        }

        public void onMenuBackPressed(){
            Form1.invalidatePage(thisForm, Form1.settingsPage, 1);
        }

        private void web_button_Click(object sender, EventArgs e){
            openWebLink("https://onurkolofficial.cf/");
        }

        private void github_button_Click(object sender, EventArgs e){
            openWebLink("https://github.com/onurkolofficial/");
        }

        private void openWebLink(String url){
            Process.Start(new ProcessStartInfo(url){
                UseShellExecute = true
            });
            // Windows method 2
            //Process.Start("cmd", "/c start "+url);
        }
    }
}
