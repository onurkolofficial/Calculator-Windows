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
    public partial class CalculatorPage1 : Form
    {
        public CalculatorPage1()
        {
            InitializeComponent();

            // Set Texts
            deleteButton.Text = Form1.langResource.GetString("del_text");
        }
    }
}
