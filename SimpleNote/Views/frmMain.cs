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
        private int ID;
        

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

            this.ID = -1;

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
            for (int i = 0; i < flpNote.Controls.Count; i++)
                flpNote.Controls[i].Dispose();

            foreach (Note note in lstNote)
            {
                Button btn = new Button();
                btn.Dock = DockStyle.Top;
                btn.Width = 340;
                btn.Height = 50;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.TextAlign = ContentAlignment.MiddleLeft;

                btn.Text = note.description;
                btn.Click += Btn_Click;

                this.flpNote.Controls.Add(btn);
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
            /*
            if (this.textBoxNoteSearch.Text == "")
            {
                this.textBoxNoteSearch.ForeColor = Color.LightGray;
                this.textBoxNoteSearch.Text = " All Note";
            }
            */
        }

        private void richTextBoxDescription_Enter(object sender, EventArgs e)
        {
            /*
            if(this.richTextBoxDescription.Text == "Note text...")
            {
                this.richTextBoxDescription.Text = "";
                this.richTextBoxDescription.Font = new Font(this.richTextBoxDescription.Font, fRegular);
                this.richTextBoxDescription.ForeColor = Color.Black;
            }
            */
        }

        private void richTextBoxDescription_Leave(object sender, EventArgs e)
        {
            /*
            if (this.richTextBoxDescription.Text == "")
            {
                this.richTextBoxDescription.Text = "Note text...";
                this.richTextBoxDescription.Font = new Font(this.richTextBoxDescription.Font, fItalic);
                this.richTextBoxDescription.ForeColor = Color.LightGray;
            }
            */
            
        }

        private void pictureBoxTrashNote_Click(object sender, EventArgs e)
        {
            frmTrash trash = new frmTrash();
            //this.trash.MdiParent = this;
            trash.Show();
        }

        private void pictureBoxNewNote_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < flpNote.Controls.Count; i++)
                if (flpNote.Controls[i].Text == "New Note")
                    return;
            Button btn = new Button();
            btn.Dock = DockStyle.Top;
            btn.Width = 330;
            btn.Height = 40;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Font = new Font("Open Sans", 12, FontStyle.Regular);
            btn.AutoEllipsis = true;
           
            btn.Text = "New Note";
            
            this.richTextBoxDescription.Text = "";
            for (int i = 0; i < flpNote.Controls.Count; i++)
                flpNote.Controls[i].BackColor = Color.White;

            
            btn.BackColor = Color.LightGray;
            btn.Select();
            btn.Click += new EventHandler(this.Btn_Click);
            flpNote.Controls.Add(btn);
            this.richTextBoxDescription.ForeColor = Color.Black;
            this.richTextBoxDescription.Font = new Font(this.richTextBoxDescription.Font, FontStyle.Regular);
            this.ID++;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            for (int i = 0; i < flpNote.Controls.Count; i++)
                flpNote.Controls[i].BackColor = Color.White;
                    
            btn.BackColor = Color.LightGray;
            //for (int i = 0; i < flpNote.Controls.Count; i++)
              //  if (flpNote.Controls[i].BackColor == Color.LightGray)
                    richTextBoxDescription.Text = btn.Text;
        }

        private void checkedListBoxNote_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBoxNote_Click(object sender, EventArgs e)
        {
 
        }

        private void richTextBoxDescription_TextChanged(object sender, EventArgs e)
        {
            if (flpNote.Controls.Count <= 0)
                return;
            // add note & save note by changing text (?)
            if (richTextBoxDescription.Text.Length > 0)
            {
                Note note = new Note();
                note.ID = this.ID;
                note.description = this.richTextBoxDescription.Text.Trim();
                note.dateCreated = DateTime.Now;

                int index = 0;

                for (int i = 0; i < flpNote.Controls.Count; i++)
                    if (flpNote.Controls[i].BackColor == Color.LightGray)
                    {
                        index = i;
                        break;
                    }
                flpNote.Controls[index].Text = note.description;
                foreach (Note n in lstNote)
                    if (n.ID == note.ID)
                    {
                        n.description = note.description;
                        return;
                    }
                        
                lstNote.Add(note);
            }
            
        }

        private void pictureBoxTrash_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < flpNote.Controls.Count; i++)
                if (flpNote.Controls[i].BackColor == Color.LightGray)
                {
                    frmTrash.lstTrash.Add(lstNote[i]);
                    lstNote.Remove(lstNote[i]);
                    flpNote.Controls.Remove(flpNote.Controls[i]);
                    this.richTextBoxDescription.Text = "";
                }         
        }

        private void frmMain_MdiChildActivate(object sender, EventArgs e)
        {
        }

        private void newNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < flpNote.Controls.Count; i++)
                if (flpNote.Controls[i].Text == "New Note")
                    return;
            Button btn = new Button();
            btn.Dock = DockStyle.Top;
            btn.Width = 340;
            btn.Height = 50;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.TextAlign = ContentAlignment.MiddleLeft;

            btn.Text = "New Note";

            this.richTextBoxDescription.Text = "";
            for (int i = 0; i < flpNote.Controls.Count; i++)
                flpNote.Controls[i].BackColor = Color.White;


            btn.BackColor = Color.LightGray;
            btn.Select();
            btn.Click += new EventHandler(this.Btn_Click);
            flpNote.Controls.Add(btn);
            this.richTextBoxDescription.ForeColor = Color.Black;
            this.richTextBoxDescription.Font = new Font(this.richTextBoxDescription.Font, FontStyle.Regular);
            this.ID++;
        }

        private void trashNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTrash trash = new frmTrash();
            trash.Show();
        }

        private void textBoxNoteSearch_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < flpNote.Controls.Count; i++)
                if (flpNote.Controls[i].Text.Length > 0)
                    if (!flpNote.Controls[i].Text.Contains(textBoxNoteSearch.Text))
                        flpNote.Controls[i].Hide();
                    else flpNote.Controls[i].Show();
        }
    }
}
