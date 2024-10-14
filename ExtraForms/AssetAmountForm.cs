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
    public partial class AssetAmountForm : Form
    {
        public int Amount { get; private set; }

        public AssetAmountForm()
        {
            InitializeComponent();
            doneButton3.Click += DoneButton3_Click;
        }

        private void DoneButton3_Click(object sender, EventArgs e)
        {
            Amount = (int)numericUpDown1.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
