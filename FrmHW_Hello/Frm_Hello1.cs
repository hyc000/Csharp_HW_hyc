using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmHW_Hello
{
    public partial class Frm_Hello1 : Form
    {
        public Frm_Hello1()
        {
            InitializeComponent();
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            string NameZh = txtNameZh.Text;
            string NameEn = txtNameEn.Text;
            string Gender = txtGender.Text;
            string StarSign = txtStarSign.Text;
            MessageBox.Show("Hello, 我是" + NameZh + "," + Environment.NewLine +
                "英文名字是" + NameEn + "," + Environment.NewLine +
                "性別是" + Gender + "," + Environment.NewLine +
                "星座是" + StarSign + "," + Environment.NewLine +
                "很高興認識你。");
        }

        private void btnSayHi_Click(object sender, EventArgs e)
        {
            string NameZh = txtNameZh.Text;
            string NameEn = txtNameEn.Text;
            string Gender = txtGender.Text;
            string StarSign = txtStarSign.Text;
            MessageBox.Show("Hi, 我是" + NameZh + "," + Environment.NewLine +
                "英文名字是" + NameEn + "," + Environment.NewLine +
                "性別是" + Gender + "," + Environment.NewLine +
                "星座是" + StarSign + "," + Environment.NewLine +
                "很高興認識你。");
        }
    }
}
