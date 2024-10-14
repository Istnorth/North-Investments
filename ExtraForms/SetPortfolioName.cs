using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace North_Investments.ExtraForms
{
    public partial class SetPortfolioName : Form
    {
        public string PortfolioName { get; private set; }

        public SetPortfolioName()
        {
            InitializeComponent();
            doneButton3.Click += DoneButton3_Click;
        }

        private void DoneButton3_Click(object sender, EventArgs e)
        {
            PortfolioName = textBox1.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}