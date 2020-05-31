using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleNote
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.panelSlideMenu.Hide();
        }

        

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tableLayoutPanelNoteView_Paint(object sender, PaintEventArgs e)
        {

        }
        bool isShow;
        private void pictureBoxShowSlideMenu_Click(object sender, EventArgs e)
        {
            if (this.panelSlideMenu.Visible)
            {
                isShow = false;

                timer1.Start();
            }
            else
            {
                isShow= true;
                this.panelSlideMenu.Show();
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isShow)
            {
                if (this.panelSlideMenu.Width >= 205)
                    timer1.Stop();
                this.panelSlideMenu.Width += 50;
            }
            else
            {
                if (this.panelSlideMenu.Width <= 0)
                {
                    this.panelSlideMenu.Hide();
                    timer1.Stop();
                }
                this.panelSlideMenu.Width -= 50;
            }

        }
    }
}
