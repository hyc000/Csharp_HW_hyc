using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HW_OneStudentScore
{
    public partial class Frm_StructFrm : Form
    {
        public Frm_StructFrm()
        {
            InitializeComponent();
        }

        Stu stu;

        internal void btnSave_Click(object sender, EventArgs e)
        {
            stu.setValues(txtName.Text, Int32.Parse(txtCh.Text), Int32.Parse(txtEn.Text), Int32.Parse(txtMath.Text));
        }

        internal void btnShow_Click(object sender, EventArgs e)
        {
            labShowAll.Text = $"姓名：{stu.StuName} ；\n國文：{stu.ChScore}；\n英文：{stu.EnScore}；\n數學：{stu.MaScore}；";
        }

        private void btnHighLow_Click(object sender, EventArgs e)
        {
            GetHigh();
            GetLow();
        }
         struct Stu
        {
            internal string StuName;
            internal int ChScore;
            internal int EnScore;
            internal int MaScore;
            public void setValues(string txtSName, int txtCh, int txtEn, int txtMa)
            {
                StuName = txtSName;
                ChScore = txtCh;
                EnScore = txtEn;
                MaScore = txtMa;
            }
           
        }
        private void GetHigh()
        {
            if (stu.MaScore >= stu.ChScore && stu.MaScore >= stu.EnScore)
            {
                labShowHighLow.Text = $"最高科目成績為：數學{stu.MaScore}分。\n";
            }
            else if (stu.ChScore >= stu.EnScore && stu.ChScore >= stu.MaScore)
            {
                labShowHighLow.Text = $"最高科目成績為：國文{stu.ChScore}分。\n";
            }
            else if (stu.EnScore >= stu.MaScore && stu.EnScore >= stu.ChScore)
            {
                labShowHighLow.Text = $"最高科目成績為：英文{stu.EnScore}分。\n";

            }
            //else if(stu.MaScore >= stu.ChScore && stu.MaScore >= stu.EnScore)
            //{
            //    labShowHighLow.Text = $"最高科目成績為：數學{stu.MaScore}分。\n";
            //}
           
        }
        
        private void GetLow()
        {
            if (stu.MaScore <= stu.ChScore && stu.MaScore <= stu.EnScore)
            {
                labShowHighLow.Text += $"最低科目成績為：數學{stu.MaScore}分。\n";
            }
            else if (stu.ChScore <= stu.EnScore && stu.ChScore <= stu.MaScore)
            {
                labShowHighLow.Text += $"最低科目成績為：國文{stu.ChScore}分。\n";
            }
            else if (stu.EnScore <= stu.MaScore && stu.EnScore <= stu.ChScore)
            {
                labShowHighLow.Text += $"最低科目成績為：英文{stu.EnScore}分。\n";
            }
            //else if (stu.MaScore <= stu.ChScore && stu.MaScore <= stu.EnScore)
            //{
            //    labShowHighLow.Text += $"最低科目成績為：數學{stu.MaScore}分。\n";
            //}
        }
    }
    
}

