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
        // Resources
        private ComponentResourceManager langResource = new ComponentResourceManager(typeof(Locales.Language));

        public CalculatorPage1(){
            InitializeComponent();

            // Set Texts
            deleteButton.Text = langResource.GetString("del_text");
        }
    }
}
