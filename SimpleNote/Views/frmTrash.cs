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
        public static List<Note> lstTrash;

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
            if (this.richTextBoxTrashDescription.ReadOnly == true)
            {
                this.richTextBoxTrashDescription.BackColor = Color.White;
            }
            for (int i = 0; i < frmMain.lstTrash.Count; i++)
            {
                this.checkedListBox1.Items.Add(frmMain.lstTrash[i].description);
            }
            
        }

        

        private void btnDeleteTrash_Click(object sender, EventArgs e)
        {
            if(this.checkedListBox1.CheckedItems.Count == 0)
            {
                frmMain.lstTrash.RemoveAt(this.checkedListBox1.SelectedIndex);
                this.checkedListBox1.Items.RemoveAt(this.checkedListBox1.SelectedIndex);
                this.richTextBoxTrashDescription.Clear();
            }
            else
            {
                foreach (var item in this.checkedListBox1.CheckedItems.OfType<string>().ToList())
                {
                    int a = this.checkedListBox1.Items.IndexOf(item);
                    frmMain.lstTrash.RemoveAt(a);
                    this.checkedListBox1.Items.Remove(item);
                    this.richTextBoxTrashDescription.Clear();
                }
            }
        }

        private void checkedListBox1_Click(object sender, EventArgs e)
        {
            this.richTextBoxTrashDescription.Text = frmMain.lstTrash[this.checkedListBox1.SelectedIndex].description;
        }

        private void btnRestoreTrash_Click(object sender, EventArgs e)
        {
            frmMain.lstNote.Add(frmMain.lstTrash[this.checkedListBox1.SelectedIndex]);
            frmMain.lstTrash.RemoveAt(this.checkedListBox1.SelectedIndex);
            this.checkedListBox1.Items.RemoveAt(this.checkedListBox1.SelectedIndex);
            this.richTextBoxTrashDescription.Clear();
        }
    }
}
