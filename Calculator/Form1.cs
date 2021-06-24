using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        // Variables
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        // DLLs
        // Drag/Drop Dll
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        // Resources
        public static readonly ComponentResourceManager langResource = new ComponentResourceManager(typeof(Properties.Locales.Language));

        public Form1(){
            // Init
            InitializeComponent();
            getCalculatorButtonPage();

            // Get String
            String appName = langResource.GetString("app_name");
            // Set Form Title
            Text = appName;
            // Set Texts
            app_title.Text = appName;
        }

        private void getCalculatorButtonPage(){
            // Get Calculator Buttons
            Properties.Forms.CalculatorPage1 calcButtonsPage1 = new Properties.Forms.CalculatorPage1();
            calcButtonsPage1.TopLevel = false;
            // Added form in panel.
            calcButtonPanel.Controls.Add(calcButtonsPage1);
            // Set Dock 'Fill'
            calcButtonsPage1.Dock = DockStyle.Fill;
            // Show Button Forms
            calcButtonsPage1.Show();
        }

        private void button1_Click(object sender, EventArgs e){
            // Close Application
            Application.Exit();
        }

        private void dragPanel_MouseDown(object sender, MouseEventArgs e){
            // Release Mouse Drag
            if(e.Button == MouseButtons.Left){
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
