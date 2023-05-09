using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FrmHW_Loan
{
    public partial class Frm_Loan : Form
    {
        public Frm_Loan()
        {
            InitializeComponent();
        }


        internal void btnPMT_Click(object sender, EventArgs e)
        {
            int LoanNum = Convert.ToInt32(txtLoanNum.Text);
            int Period = Convert.ToInt32(txtPeriod.Text);
            float percentage = Convert.ToSingle(txtRate.Text) / 1200;
            int FirstPay = Convert.ToInt32(txtFirstPay.Text);
            float Rate = 1 + percentage;
            float RateDividend = (float)(Math.Pow(Rate, Period * 12)) * percentage;
            float RateDivisor = (float)(Math.Pow(Rate, Period * 12)) - 1;
            float MonthRate = RateDividend / RateDivisor;
            int PMT = Convert.ToInt32((LoanNum - FirstPay)* MonthRate);
            int Total = PMT * Period * 12;
            /*每月應付本息金額之平均攤還率＝{ [(1＋月利率)^月數]×月利率}÷{ [(1＋月利率)^月數]－1}
             * 月利率 ＝ 年利率／12 
             * 平均每月應攤付本息金額＝貸款本金×每月應付本息金額之平均攤還率＝每月應還本金金額＋每 月應付利息金額
             貸款總金額是總金額欄位減掉頭期款@@*/
            MessageBox.Show("月付額: " + PMT + "元。");
        }

        internal void btnTotal_Click(object sender, EventArgs e)
        {
            int LoanNum = Convert.ToInt32(txtLoanNum.Text);
            int Period = Convert.ToInt32(txtPeriod.Text);
            float percentage = Convert.ToSingle(txtRate.Text) / 1200;
            int FirstPay = Convert.ToInt32(txtFirstPay.Text);
            float Rate = 1 + percentage;
            float RateDividend = (float)(Math.Pow(Rate, Period * 12)) * percentage;
            float RateDivisor = (float)(Math.Pow(Rate, Period * 12)) - 1;
            float MonthRate = RateDividend / RateDivisor;
            int PMT = Convert.ToInt32((LoanNum - FirstPay) * MonthRate);
            int Total = PMT * Period * 12;
            MessageBox.Show("總付款: " + Total + "元。");
        }

        internal void btnReport_Click(object sender, EventArgs e)
        {
            Frm_LoanReport LR = new Frm_LoanReport();
            LR.Show();
            LR.txtLoanNumRP.Text =txtLoanNum.Text;
            LR.txtPeriodRP.Text =txtPeriod.Text;
            LR.txtRateRP.Text =txtRate.Text;
            LR.txtFirstPayRP.Text =txtFirstPay.Text;
            int LoanNum = Convert.ToInt32(txtLoanNum.Text);
            int Period = Convert.ToInt32(txtPeriod.Text);
            float percentage = Convert.ToSingle(txtRate.Text) / 1200;
            int FirstPay = Convert.ToInt32(txtFirstPay.Text);
            float Rate = 1 + percentage;
            float RateDividend = (float)(Math.Pow(Rate, Period * 12)) * percentage;
            float RateDivisor = (float)(Math.Pow(Rate, Period * 12)) - 1;
            float MonthRate = RateDividend / RateDivisor;
            int PMT = Convert.ToInt32((LoanNum - FirstPay) * MonthRate);
            int Total = PMT * Period * 12;
            LR.txtPmtRP.Text = Convert.ToString(PMT);
            LR.txtTotalRP.Text = Convert.ToString(Total);

        }
    }
}
