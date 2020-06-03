using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleNote.Models;

namespace SimpleNote.Views
{
    public partial class frmTrash : Form
    {
        public frmTrash()
        {
            InitializeComponent();
        }

        private void textBoxTrashNoteSearch_Enter(object sender, EventArgs e)
        {
            if (this.textBoxTrashNoteSearch.Text == "Trash")
            {
                this.textBoxTrashNoteSearch.Text = "";
                this.textBoxTrashNoteSearch.ForeColor = Color.Black;
            }
        }

        private void textBoxTrashNoteSearch_Leave(object sender, EventArgs e)
        {
            if (this.textBoxTrashNoteSearch.Text == "")
            {
                this.textBoxTrashNoteSearch.ForeColor = Color.LightGray;
                this.textBoxTrashNoteSearch.Text = "Trash";
            }
        }

        private void frmTrash_Load(object sender, EventArgs e)
        {
            if(this.richTextBoxTrashDescription.ReadOnly == true)
            {
                this.richTextBoxTrashDescription.BackColor = Color.White;
            }
        }
    }
}
