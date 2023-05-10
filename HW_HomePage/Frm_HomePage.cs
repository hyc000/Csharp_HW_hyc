using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrmHW_Hello;
using FrmHW_Loan;
using HW_POS;
using HW_OneStudentScore;
using HW_MyClac;
using HW_Alarm;
using HW_ScreenSaver;

namespace HW_HomePage
{
    public partial class Frn_HomePage : Form
    {
        public Frn_HomePage()
        {
            InitializeComponent();
        }
        private Form currentForm = null;

        private void btnOpenHelloFrm_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            Frm_Hello1 frm = new Frm_Hello1();
            frm.TopLevel = false;
            panelShow.Controls.Add(frm);
            frm.Show();
            currentForm = frm;
        }

        private void btnOpenLoan_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            Frm_Loan frm = new Frm_Loan();
            frm.TopLevel = false;
            panelShow.Controls.Add(frm);
            frm.Show();
            currentForm = frm;
        }

        private void btnOpenPOS_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            Frm_POS frm = new Frm_POS();
            frm.TopLevel = false;
            panelShow.Controls.Add(frm);
            frm.Show();
            currentForm = frm;
        }

        private void btnOpenStuStruct_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            Frm_StructFrm frm = new Frm_StructFrm();
            frm.TopLevel = false;
            panelShow.Controls.Add(frm);
            frm.Show();
            currentForm = frm;
        }

        private void btnOpenClac_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            Frm_MyClac frm = new Frm_MyClac();
            frm.TopLevel = false;
            panelShow.Controls.Add(frm);
            frm.Show();
            currentForm = frm;
        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            Frm_Alarm frm = new Frm_Alarm();
            frm.TopLevel = false;
            panelShow.Controls.Add(frm);
            frm.Show();
            currentForm = frm;
        }

        private void btnScrSaver_Click(object sender, EventArgs e)
        {
            Frm_ScreenSaver frm = new Frm_ScreenSaver();
            frm.Show();
        }
    }
}
