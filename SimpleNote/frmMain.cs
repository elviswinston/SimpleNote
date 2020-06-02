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

       

        private void pictureBoxSlideMenu_Click(object sender, EventArgs e)
        {
            if (this.panelSlideMenu.Visible)
            {
                this.panelSlideMenu.Hide();
            }
            else
            {
                this.panelSlideMenu.Show();
            }
        }

        private void pictureBoxToggleSidebar_Click(object sender, EventArgs e)
        {
            if (this.panelNoteReview.Visible)
            {
                this.panelNoteReview.Hide();
            }
            else
            {
                this.panelNoteReview.Show();
            }
        }

        private void pictureBoxAllNote_Click(object sender, EventArgs e)
        {
            this.panelSlideMenu.Hide();
        }
    }
}
