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
    public partial class frmMain : Form
    {
        private uint ID;

        frmTrash trash = new frmTrash();
        List<Note> lstNote = new List<Note>();
        List<Note> lstTrash = new List<Note>();

        string s = "New Note...";

        FontStyle fItalic = new FontStyle();
        FontStyle fRegular = new FontStyle();

        public frmMain()
        {
            InitializeComponent();
            this.ID = 0;

            fRegular = FontStyle.Regular;
            fItalic = FontStyle.Italic;

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.panelSlideMenu.Hide();

            this.ID = 1;
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
            trash.Hide();
        }

        private void textBoxNoteSearch_Enter(object sender, EventArgs e)
        {
            if(this.textBoxNoteSearch.Text == " All Note")
            {
                this.textBoxNoteSearch.Text = "";
                this.textBoxNoteSearch.ForeColor = Color.Black;
            }
        }

        private void textBoxNoteSearch_Leave(object sender, EventArgs e)
        {
            if (this.textBoxNoteSearch.Text == "")
            {
                this.textBoxNoteSearch.ForeColor = Color.LightGray;
                this.textBoxNoteSearch.Text = " All Note";
            }
        }

        private void richTextBoxDescription_Enter(object sender, EventArgs e)
        {
            
            if(this.richTextBoxDescription.Text == "Note text...")
            {
                this.richTextBoxDescription.Text = "";
                this.richTextBoxDescription.Font = new Font(this.richTextBoxDescription.Font, fRegular);
                this.richTextBoxDescription.ForeColor = Color.Black;
            }
        }

        private void richTextBoxDescription_Leave(object sender, EventArgs e)
        {
            if (this.richTextBoxDescription.Text == "")
            {
                this.richTextBoxDescription.Text = "Note text...";
                this.richTextBoxDescription.Font = new Font(this.richTextBoxDescription.Font, fItalic);
                this.richTextBoxDescription.ForeColor = Color.LightGray;
            }

            
        }

        private void pictureBoxTrashNote_Click(object sender, EventArgs e)
        {

            trash.Show();
        }

        private void pictureBoxNewNote_Click(object sender, EventArgs e)
        {
            Note note = new Note();
            
            this.richTextBoxDescription.Enabled = true;

            this.checkedListBoxNote.ForeColor = Color.Black;
            this.checkedListBoxNote.Font = new Font(checkedListBoxNote.Font, fRegular);
            if (this.richTextBoxDescription.Text == "Note text..." || this.richTextBoxDescription.Text =="")
            {
                this.checkedListBoxNote.ForeColor = Color.LightGray;
                this.checkedListBoxNote.Font = new Font(checkedListBoxNote.Font, fItalic);
                this.checkedListBoxNote.Items.Add(s);
                return;
            }

            // add note by button new note (cannot save changes to existed note)
            else
            {
                note.description = this.richTextBoxDescription.Text.Trim();
                note.dateCreated = DateTime.Now;

                this.checkedListBoxNote.Items.Add(this.richTextBoxDescription.Text.Trim());
                this.richTextBoxDescription.Clear();
                this.richTextBoxDescription.Enabled = false;

                this.ID += 1;
                note.ID = this.ID;

                this.lstNote.Add(note);
            }



            for (int i = 0; i < this.checkedListBoxNote.Items.Count; i++)
            {
                if (this.checkedListBoxNote.Items[i].ToString() == s)
                    this.checkedListBoxNote.Items.RemoveAt(i);
            }

        }


        private void checkedListBoxNote_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBoxNote_Click(object sender, EventArgs e)
        {
            this.richTextBoxDescription.Enabled = true;

            this.richTextBoxDescription.Font = new Font(this.richTextBoxDescription.Font, fRegular);
            this.richTextBoxDescription.ForeColor = Color.Black;
            this.richTextBoxDescription.Text = lstNote[this.checkedListBoxNote.SelectedIndex].description;
        }

        private void richTextBoxDescription_TextChanged(object sender, EventArgs e)
        {
            // add note & save note by changing text (?)
            
            //Note note = new Note();

            //note.description = this.richTextBoxDescription.Text.Trim();
            //note.dateCreated = DateTime.Now;
            ////this.richTextBoxDescription.Clear();

            //this.lstNote.Add(note);

            //this.checkedListBoxNote.Items.Add(note.description);


            //for (int i = 1; i < this.checkedListBoxNote.Items.Count; i++)
            //{
            //    if (this.checkedListBoxNote.Items[i].ToString() == s)
            //        this.checkedListBoxNote.Items.RemoveAt(i);
            //}
        }


    }
}
