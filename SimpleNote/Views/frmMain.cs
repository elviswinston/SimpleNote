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

        

        public static List<Note> lstNote;
        public static List<Note> lstTrash;

        

        string s = "New Note...";

        FontStyle fItalic = new FontStyle();
        FontStyle fRegular = new FontStyle();

        public frmMain()
        {
            InitializeComponent();
            this.ID = 0;

            lstNote = new List<Note>();
            lstTrash = new List<Note>();

            

            fRegular = FontStyle.Regular;
            fItalic = FontStyle.Italic;


        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.panelSlideMenu.Hide();

            this.ID = 1;

            this.richTextBoxDescription.BackColor = Color.White;

            formReload();
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

        private void formReload()
        {
            for (int i = 0; i < lstNote.Count; i++)
            {
                this.checkedListBoxNote.Items.Add(lstNote[i].description);
                this.richTextBoxDescription.Text = lstNote[i].description;
            }
        }

        private void pictureBoxAllNote_Click(object sender, EventArgs e)
        {
            
            this.panelSlideMenu.Hide();
            //trash.Hide();
            formReload();
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
            frmTrash trash = new frmTrash();
            //this.trash.MdiParent = this;
            trash.Show();
        }

        private void pictureBoxNewNote_Click(object sender, EventArgs e)
        {
            Note note = new Note();
            
            this.richTextBoxDescription.ReadOnly = false;

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
                this.richTextBoxDescription.ReadOnly = true;

                this.ID += 1;
                note.ID = this.ID;

                lstNote.Add(note);
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
            if (this.checkedListBoxNote.SelectedIndex < 0)
                return;
            else
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

        private void pictureBoxTrash_Click(object sender, EventArgs e)
        {
            if (this.checkedListBoxNote.CheckedItems.Count == 0)
            {
                lstTrash.Add(lstNote[this.checkedListBoxNote.SelectedIndex]);
                lstNote.RemoveAt(this.checkedListBoxNote.SelectedIndex);
                this.checkedListBoxNote.Items.Remove(this.checkedListBoxNote.SelectedItem);
                this.richTextBoxDescription.Clear();
            }
            else
            {
                foreach (var item in this.checkedListBoxNote.CheckedItems.OfType<string>().ToList())
                {
                    int a = this.checkedListBoxNote.Items.IndexOf(item);
                    lstTrash.Add(lstNote[a]);
                    this.checkedListBoxNote.Items.RemoveAt(a);
                    lstNote.RemoveAt(a);

                    this.richTextBoxDescription.Clear();

                }
            }
            

        }

        private void frmMain_MdiChildActivate(object sender, EventArgs e)
        {
        }

        private void newNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Note note = new Note();

            this.richTextBoxDescription.ReadOnly = false;
            this.richTextBoxDescription.BackColor = Color.White;

            this.checkedListBoxNote.ForeColor = Color.Black;
            this.checkedListBoxNote.Font = new Font(checkedListBoxNote.Font, fRegular);
            if (this.richTextBoxDescription.Text == "Note text..." || this.richTextBoxDescription.Text == "")
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
                this.richTextBoxDescription.ReadOnly = true;

                this.ID += 1;
                note.ID = this.ID;

                lstNote.Add(note);
            }



            for (int i = 0; i < this.checkedListBoxNote.Items.Count; i++)
            {
                if (this.checkedListBoxNote.Items[i].ToString() == s)
                    this.checkedListBoxNote.Items.RemoveAt(i);
            }
        }

        private void trashNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTrash trash = new frmTrash();
            trash.Show();
        }
    }
}
