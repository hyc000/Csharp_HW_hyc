using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_POS
{
    public partial class Frm_POS : Form
    {
        public Frm_POS()
        {
            InitializeComponent();
        }

        int Total = 0;
        int BeerNum, TequilaNum, WhiskeyNum, WineNum = 0;
        int BeerPrice = 120, TequilaPrice = 180, WhiskeyPrice = 350, WinePrice = 320;
        int BeerTotalPrice, TequilaTotalPrice, WhiskeyTotalPrice, WineTotalPrice = 0;
        string BeerShow, TequilaShow, WhiskeyShow, WineShow;

        private void btnBeer_Click(object sender, EventArgs e)
        {
            Total += BeerPrice;
            BeerNum++;
            BeerTotalPrice = BeerNum * BeerPrice;
            labTotalShow.Text = "NT $ "+Total.ToString();
            BeerShow = $"啤酒Beer x {BeerNum}, 共NT$ {BeerTotalPrice}元\n";
            labShowShopList.Text = BeerShow+ TequilaShow+ WhiskeyShow+ WineShow;
            

        }

        private void btnTequila_Click(object sender, EventArgs e)
        {
            Total += TequilaPrice;
            TequilaNum++;
            TequilaTotalPrice = TequilaNum * TequilaPrice;
            labTotalShow.Text = "NT $ " + Total.ToString();
            TequilaShow = $"龍舌蘭Tequila x {TequilaNum}, 共NT$ {TequilaTotalPrice}元\n";
            labShowShopList.Text = BeerShow + TequilaShow + WhiskeyShow + WineShow;

        }

        private void btnWiskey_Click(object sender, EventArgs e)
        {
            Total += WhiskeyPrice;
            WhiskeyNum++;
            WhiskeyTotalPrice = WhiskeyNum * WhiskeyPrice;
            labTotalShow.Text = "NT $ " + Total.ToString();
            WhiskeyShow = $"威士忌Whiskey x {WhiskeyNum}, 共NT$ {WhiskeyTotalPrice}元\n";
            labShowShopList.Text = BeerShow + TequilaShow + WhiskeyShow + WineShow;

        }

        private void btnWine_Click(object sender, EventArgs e)
        {
            Total += WinePrice;
            WineNum++;
            WineTotalPrice = WineNum * WinePrice;
            labTotalShow.Text = "NT $ " + Total.ToString();
            WineShow = $"紅酒Wine x {WineNum}, 共NT$ {WineTotalPrice}元\n";
            labShowShopList.Text = BeerShow + TequilaShow + WhiskeyShow + WineShow;

        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            if (Total > 0)
            {
                MessageBox.Show("總金額: NT$ " + Total, "確認付款");
            }
            else
            {
                MessageBox.Show("尚未點餐!! ", "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnCreditCard_Click(object sender, EventArgs e)
        {
            int Total_Credit = Total * 9 / 10;
            if (Total_Credit > 0)
            {
                MessageBox.Show("總金額: NT$ " + Total_Credit, "確認付款");
            }
            else
            {
                MessageBox.Show("尚未點餐!! ", "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void btnAllDel_Click(object sender, EventArgs e)
        {
            Total = 0;
            BeerNum = TequilaNum = WhiskeyNum = WineNum = 0;
            BeerShow = TequilaShow = WhiskeyShow = WineShow = "";
            labTotalShow.Text = "NT $ " + Total.ToString();
            labShowShopList.Text = "尚未購買";
        }

        
        
    }
}
