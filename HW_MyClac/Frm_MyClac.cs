using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_MyClac
{
    public partial class Frm_MyClac : Form
    {
        public Frm_MyClac()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(txtNum1.Text);
            float num2 = float.Parse(txtNum2.Text);
            float ans = num1 + num2;
            txtAns.Text = ans.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(txtNum1.Text);
            float num2 = float.Parse(txtNum2.Text);
            float ans = num1 - num2;
            txtAns.Text = ans.ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(txtNum1.Text);
            float num2 = float.Parse(txtNum2.Text);
            float ans = num1 * num2;
            txtAns.Text = ans.ToString();
        }

        private void btnDivided_Click(object sender, EventArgs e)
        {
            decimal num1 = decimal.Parse(txtNum1.Text);
            decimal num2 = decimal.Parse(txtNum2.Text);
            decimal ans = decimal.Round(num1 / num2, 4, MidpointRounding.AwayFromZero);
            txtAns.Text = ans.ToString("0.0000");
            //decimalValue = decimal.Round(decimalValue, 2, MidpointRounding.ToEven);
        }
    }
}
