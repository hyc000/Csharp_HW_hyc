using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace HW_Alarm
{
    public partial class Frm_Alarm : Form
    {
        public Frm_Alarm()
        {
            InitializeComponent();
            labTimeShow.Text = DateTime.Now.ToString("T");
        }

        private void timerForNow_Tick(object sender, EventArgs e)
        {

            labTimeShow.Text = DateTime.Now.ToString("T");

            if (chkBoxSet.Checked == true)
            {
                DateTime Time = Convert.ToDateTime(txtTime.Text);
                TimeSpan diff = Time - DateTime.Now;
                if (diff.TotalSeconds < 0.15 && diff.TotalSeconds > -0.5)
                {
                    this.timerForChangeCol.Enabled = true;
                }
                if (diff.TotalSeconds > -4 && diff.TotalSeconds < -3)
                {
                    this.timerForChangeCol.Enabled = false;
                }
            }
            else if (chkBoxSet.Checked == false)
            {
                this.BackColor = System.Drawing.SystemColors.Control;
            }
        }
        bool light = true;
        private void timerForChangeCol_Tick(object sender, EventArgs e)
        {
            if (light)
            {
                this.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                this.BackColor = System.Drawing.Color.Black;
            }
            light = !light;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime Time = Convert.ToDateTime(txtTime.Text);
            TimeSpan diff = Time - DateTime.Now;
            MessageBox.Show(diff+"\n"+Time.ToString()+"\n"+DateTime.Now);
        }

       
    }
}
