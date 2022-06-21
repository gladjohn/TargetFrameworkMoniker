using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsNetFwk472
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertToMiles_Click(object sender, EventArgs e)
        {
            lblResult.Text = KmstoMiles.Convert.ToMiles(System.Convert.ToDouble(cmbKms.Text)).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbKms.SelectedIndex = 0;
        }
    }
}
