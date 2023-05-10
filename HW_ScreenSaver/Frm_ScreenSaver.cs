using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_ScreenSaver
{
    public partial class Frm_ScreenSaver : Form
    {
        public Frm_ScreenSaver()
        {
            InitializeComponent();
        }
        int picSpeedX = 15;
        int picSpeedY = 10;
        private Point isMouseMove;

        private void Frm_ScreenSaver_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            isMouseMove = Control.MousePosition;
            timerGo.Start();
        }

        private void timerGo_Tick(object sender, EventArgs e)
        {
            picPika.Left += picSpeedX;
            picPika.Top += picSpeedY;
            if (picPika.Right > this.ClientSize.Width || picPika.Left < 0)
            {
                picSpeedX = -picSpeedX;
            }
            if (picPika.Bottom > this.ClientSize.Height || picPika.Top < 0)
            {
                picSpeedY = -picSpeedY;
            }
        }

        private void timerEnd_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_ScreenSaver_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseMove != Control.MousePosition)
            {
                timerEnd.Start();
            }
        }
    }
}
