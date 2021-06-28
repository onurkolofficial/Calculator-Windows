using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;

namespace Calculator.Properties.Forms
{
    public partial class CalculatorPage1 : Form
    {
        // Resources
        private ComponentResourceManager langResource = new ComponentResourceManager(typeof(Locales.Language));
        // Elements
        private static TextBox getValueTextBox, geHistoryTextBox;
        // Variables
        public static Boolean PROCESS_RESET_COLON=true;
        public CalculatorPage1(){
            InitializeComponent();
            // Set Texts
            deleteButton.Text = langResource.GetString("del_text");
            // Init Button Click Handlers
            equalsButton.Click += new EventHandler(equalsButtonClick);
        }
        private void CalculatorPage1_Load(object sender, EventArgs e){
            // Get Element
            getValueTextBox = Form1.calculatorMain.valueTextPublic;
            geHistoryTextBox = Form1.calculatorMain.historyTextPublic;
        }
        private void buttonKey1_Click(object sender, EventArgs e){
            getValueTextBox.Paste("1");
        }
        private void buttonKey2_Click(object sender, EventArgs e){
            getValueTextBox.Paste("2");
        }
        private void buttonKey3_Click(object sender, EventArgs e){
            getValueTextBox.Paste("3");
            // Check Navigation Menu
            Form1.checkNavigationIsShowingHandler(sender, e);
        }
        private void buttonKey4_Click(object sender, EventArgs e){
            getValueTextBox.Paste("4");
        }
        private void buttonKey5_Click(object sender, EventArgs e){
            getValueTextBox.Paste("5");
        }
        private void buttonKey6_Click(object sender, EventArgs e){
            getValueTextBox.Paste("6");
            // Check Navigation Menu
            Form1.checkNavigationIsShowingHandler(sender, e);
        }
        private void buttonKey7_Click(object sender, EventArgs e){
            getValueTextBox.Paste("7");
        }
        private void buttonKey8_Click(object sender, EventArgs e){
            getValueTextBox.Paste("8");
        }
        private void buttonKey9_Click(object sender, EventArgs e){
            getValueTextBox.Paste("9");
            // Check Navigation Menu
            Form1.checkNavigationIsShowingHandler(sender, e);
        }
        private void buttonKey0_Click(object sender, EventArgs e){
            getValueTextBox.Paste("0");
        }

        private void clearButton_Click(object sender, EventArgs e){
            // Reset Variables
            PROCESS_RESET_COLON = true;
            // Clear Text
            getValueTextBox.Text = "";
            geHistoryTextBox.Text = "";
            // Check Navigation Menu
            Form1.checkNavigationIsShowingHandler(sender, e);
        }

        private void deleteButton_Click(object sender, EventArgs e){
            // Check Length
            if (getValueTextBox.TextLength > 0){
                int selectPos = getValueTextBox.SelectionStart;
                if (selectPos > 0){
                    String valOut = getValueTextBox.Text.Remove(selectPos-1, 1);
                    getValueTextBox.Text = valOut;
                    // ReSelect
                    getValueTextBox.SelectionStart = (selectPos-1);
                }
            }
            else
                PROCESS_RESET_COLON = true;
            // Check Navigation Menu
            Form1.checkNavigationIsShowingHandler(sender, e);
        }

        private void colonButton_Click(object sender, EventArgs e){
            // Check Length
            if (getValueTextBox.TextLength > 0) {
                if (PROCESS_RESET_COLON) {
                    // Reset Variable
                    PROCESS_RESET_COLON = false;
                    // Add Text
                    getValueTextBox.Text += ".";
                    // Set Selection
                    getValueTextBox.SelectionStart = getValueTextBox.TextLength;
                }
            }
        }

        private void negPosButton_Click(object sender, EventArgs e){
            // Get String
            String valueText = getValueTextBox.Text;
            // Check Length
            if (getValueTextBox.TextLength > 0){
                Regex regex = new Regex("([0-9]{1,100})");
                Match matcher = regex.Match(valueText);

                String val = "";
                int i = 0;
                while (matcher.Success){
                    // Get Value
                    val = matcher.Groups[1].Value;
                    matcher = matcher.NextMatch();
                    i++;
                }
                // Find Match
                if (valueText.Contains("-"+val))
                    getValueTextBox.Text = valueText.Replace("-"+val, val);
                else
                    getValueTextBox.Text = valueText.Replace(val, "-"+val);
                // Set Selection
                getValueTextBox.SelectionStart = getValueTextBox.TextLength;
            }
        }

        public static void equalsButtonClick(object sender, EventArgs e){
            String expressString = getValueTextBox.Text;
            String convertExpressString = expressString.Replace("x", "*");
            // Expression
            Expression expression = new Expression(convertExpressString);
            // Get Value
            String value = expression.calculate().ToString();
            // Print Values
            getValueTextBox.Text = value;
            geHistoryTextBox.Text = expressString;
            // Check Navigation Menu
            Form1.checkNavigationIsShowingHandler(sender, e);
        }

        private void processButtonClick(object sender, EventArgs e){
            // Get Process Symbol
            String getProcess = ((Button)sender).Text;
            // Process Clicked to Reset Variables
            PROCESS_RESET_COLON = true;
            // Check Length
            if (getValueTextBox.TextLength > 0){
                // Get Value TextBox End Char
                String ckValue = getValueTextBox.Text.Substring(getValueTextBox.TextLength-1, 1);
                // Regex
                Regex regex = new Regex("[0-9i()]");
                Match matcher=regex.Match(ckValue);
                if (matcher.Success)
                    getValueTextBox.Text += getProcess;
                else{
                    // Update New Process
                    String newProcValue = getValueTextBox.Text
                        .Remove(getValueTextBox.TextLength-1)
                        .Insert((getValueTextBox.TextLength-1), getProcess);
                    getValueTextBox.Text = newProcValue;
                }
            }
            // Reset Selection
            getValueTextBox.SelectionStart = getValueTextBox.TextLength;
            // Check Navigation Menu
            Form1.checkNavigationIsShowingHandler(sender, e);
        }
    }
}
