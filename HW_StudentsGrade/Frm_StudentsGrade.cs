using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace HW_StudentsGrade
{
    public partial class Frm_StudentsGrade : Form
    {
        public Frm_StudentsGrade()
        {
            InitializeComponent();
        }
        
        //class StuInfo
        //{
        //    string StuName;
        //    int StuCh;
        //    int StuEn;
        //    int StuMa;
        //    int StuTotal;
        //    double StuAve;
        //    int StuHigh;
        //    int StuLow;
        //}

        //this.labShowAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        //this.panelShow.AutoScroll = true;
        struct Stu
        {
            internal string StuName;
            internal int ChScore;
            internal int EnScore;
            internal int MaScore;
            internal int TotalScore;
            internal double ScoreAve;
            internal int HighScore;
            internal int LowScore;

            public void setValues(string txtSName, int txtCh, int txtEn, int txtMa)
            {
                StuName = txtSName;
                ChScore = txtCh;
                EnScore = txtEn;
                MaScore = txtMa;
                TotalScore = ChScore + EnScore + MaScore;
                ScoreAve = TotalScore / 3d;
                int[] ScArray = new int[] { ChScore, EnScore, MaScore };
                HighScore = ScArray.Max();
                LowScore = ScArray.Min();

            }

        }

        void ShowingTxt()
        {
            txtShowAll.Text = "";
            for (int i = 0; i < StuInfo.Count; i++)
            {
                txtShowAll.Text += $"{((Stu)StuInfo[i]).StuName}\t{((Stu)StuInfo[i]).ChScore}\t{((Stu)StuInfo[i]).EnScore}\t{((Stu)StuInfo[i]).MaScore}\t" +
                    $"{((Stu)StuInfo[i]).TotalScore}\t{ ((Stu)StuInfo[i]).ScoreAve:F}\t{((Stu)StuInfo[i]).LowScore}\t{((Stu)StuInfo[i]).HighScore}\t\n";
            }
        }

        ArrayList StuInfo = new ArrayList();
        Stu stu = new Stu();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            stu.setValues(txtStuName.Text, Int32.Parse(txtCh.Text), Int32.Parse(txtEn.Text), Int32.Parse(txtMath.Text));
            
            StuInfo.Add(stu);
            ShowingTxt();
            //txtShowAll.Text += $"{stu.StuName}\t{stu.ChScore}\t{stu.EnScore}\t{stu.MaScore}\t{stu.TotalScore}\t{stu.ScoreAve:F}\t{stu.LowScore}\t{stu.HighScore}\t\n";

        }

        private void btnAddRandem_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int a = StuInfo.Count + 1;
            stu.setValues(a.ToString(), random.Next(0,100), random.Next(0, 100), random.Next(0, 100));
            StuInfo.Add(stu);
            ShowingTxt();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            int ChScoreAll=0, EnScoreAll=0, MaScoreAll=0,  ChScoreHigh=0, EnScoreHigh=0, MaScoreHigh=0, ChScoreLow=0, EnScoreLow=0, MaScoreLow=0;
            double ChScoreAllAve=0, EnScoreAllAve =0, MaScoreAllAve = 0;

            labShowReport.Text = $"總分\t{ChScoreAll}\t{EnScoreAll}\t{MaScoreAll}\t\n" +
                $"平均\t{ChScoreAllAve}\t{EnScoreAllAve}\t{MaScoreAllAve}\t\n" +
                $"最高\t{ChScoreHigh}\t{EnScoreHigh}\t{MaScoreHigh}\t\n" +
                $"最低\t{ChScoreLow}\t{EnScoreLow}\t{MaScoreLow}\t\n";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            StuInfo.Clear();
            txtShowAll.Text = "";
            labShowReport.Text = "";
        }

        private void btnRendom20_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 20; i++)
            {
                
                Random random = new Random();
                int a = StuInfo.Count+1;
                stu.setValues(a.ToString(), random.Next(0, 100), random.Next(0, 100), random.Next(0, 100));
                StuInfo.Add(stu);
                
            }
            ShowingTxt();
        }
    }
}
