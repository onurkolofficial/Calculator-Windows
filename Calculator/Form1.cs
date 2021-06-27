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
        public static Boolean showNavigationStart = false;
        // Scroll Form Variables
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        // DLLs
        // Drag/Drop Dll
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        // Static Elements
        public static Panel navigationPanelStatic,appContentPanelStatic;
        public static Button toolbarBackButtonStatic, toolbarMenuButtonStatic;
        public static Label toolbarTitleStatic;

        // Forms
        public static Properties.Forms.CalculatorContentForm calculatorMain = new Properties.Forms.CalculatorContentForm();
        public static Properties.Forms.SettingsForm settingsPage = new Properties.Forms.SettingsForm();

        // Resources
        public static ComponentResourceManager langResource = new ComponentResourceManager(typeof(Properties.Locales.Language));
        public Form1(){
            // Init
            InitializeComponent();

            // Set Static Elements
            navigationPanelStatic = navigationPanel;
            toolbarBackButtonStatic = backButton;
            toolbarMenuButtonStatic = menuButton;
            toolbarTitleStatic = toolbar_title;
            appContentPanelStatic = appContentPanel;

            // Get String
            String appName = langResource.GetString("app_name");
            // Set Form Title
            Text = appName;
            // Set Texts
            settingsButton.Text = langResource.GetString("settings_text");

            // Hide Navigation
            navigationPanel.Visible = false;
            // Init App
            getMainPage();
        }

        private void Form1_Load(object sender, EventArgs e){
            // Focus Control
            ActiveControl = calculatorMain.valueTextPublic;
        }

        // Get Calculator Main Page
        public static void getMainPage(){
            calculatorMain.TopLevel = false;
            // Remove Another Control
            appContentPanelStatic.Controls.Remove(settingsPage);
            // Added form in panel.
            appContentPanelStatic.Controls.Add(calculatorMain);
            // Set Dock 'Fill'
            calculatorMain.Dock = DockStyle.Fill;
            // Show Button Forms
            calculatorMain.Show();
            // Init Main Page Toolbar
            setToolbarMode(0);
        }
        // Get Setting Page
        private void getSettingsPage(){
            settingsPage.TopLevel = false;
            // Remove Main Control
            appContentPanel.Controls.Remove(calculatorMain);
            // Added form in panel.
            appContentPanel.Controls.Add(settingsPage);
            // Set Dock 'Fill'
            settingsPage.Dock = DockStyle.Fill;
            // Show Button Forms
            settingsPage.Show();
            // Init Settings Page Toolbar
            setToolbarMode(1);
        }

        private void toolbarScrollMouseDown(object sender, MouseEventArgs e){
            // Release Mouse Drag
            if (e.Button == MouseButtons.Left){
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private static void setToolbarMode(int mode){
            if (mode == 0){
                // Main Page
                toolbarBackButtonStatic.Visible = false;
                toolbarMenuButtonStatic.Visible = true;
                // Set Toolbar Title
                toolbarTitleStatic.Text = langResource.GetString("app_name");
            }
            else if (mode == 1){
                // Main Page
                toolbarBackButtonStatic.Visible = true;
                toolbarMenuButtonStatic.Visible = false;
                // Set Toolbar Title
                toolbarTitleStatic.Text = langResource.GetString("settings_text");
            }
        }

        private void exitAppButton_Click(object sender, EventArgs e){
            // Close Application
            Application.Exit();
        }

        private void menuButton_Click(object sender, EventArgs e){
            // Get Effect
            Properties.Tools.Animation.Effect effect = Properties.Tools.Animation.Effect.Roll;
            // Check Navigation Status
            if (!showNavigationStart){
                // Show Navigation
                showNavigationStart = true;
                // Set Animation
                Properties.Tools.Animation.Animate(navigationPanel,effect,100,0);
            }
            else{
                // Hide Navigation
                showNavigationStart = false;
                // Set Animation
                Properties.Tools.Animation.Animate(navigationPanel, effect, 100, 360);
            }
        }

        public static void checkNavigationIsShowingHandler(object sender, EventArgs e){
            if (showNavigationStart){
                // Hide Navigation
                showNavigationStart = false;
                // Get Effect
                Properties.Tools.Animation.Effect effect = Properties.Tools.Animation.Effect.Roll;
                // Set Animation
                Properties.Tools.Animation.Animate(navigationPanelStatic, effect, 100, 360);
            }
        }

        private void settingsButton_Click(object sender, EventArgs e){
            // Open Settings
            getSettingsPage();
            // Dismiss Navigation
            checkNavigationIsShowingHandler(sender, e);
        }
    }
}
