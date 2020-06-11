﻿using System;
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
        public static List<Note> lstTrash = new List<Note>();

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
            
            foreach (Note note in lstTrash)
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

                this.flpTrash.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            for (int i = 0; i < flpTrash.Controls.Count; i++)
                flpTrash.Controls[i].BackColor = Color.White;

            btn.BackColor = Color.LightGray;
            this.richTextBoxTrashDescription.Text = btn.Text;
        }

        private void btnDeleteTrash_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.flpTrash.Controls.Count; i++)
                if (this.flpTrash.Controls[i].BackColor == Color.LightGray)
                {
                    this.flpTrash.Controls.Remove(this.flpTrash.Controls[i]);
                    lstTrash.Remove(lstTrash[i]);
                }
            this.richTextBoxTrashDescription.Text = "";
        }

        private void checkedListBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRestoreTrash_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < flpTrash.Controls.Count; i++)
                if (flpTrash.Controls[i].BackColor == Color.LightGray)
                {
                    frmMain.lstNote.Add(lstTrash[i]);
                    lstTrash.Remove(lstTrash[i]);
                    flpTrash.Controls.Remove(flpTrash.Controls[i]);
                    this.richTextBoxTrashDescription.Text = "";
                }
        }

        private void textBoxTrashNoteSearch_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < flpTrash.Controls.Count; i++)
                if (flpTrash.Controls[i].Text.Length > 0)
                    if (!flpTrash.Controls[i].Text.Contains(textBoxTrashNoteSearch.Text))
                        flpTrash.Controls[i].Hide();
                    else flpTrash.Controls[i].Show();
        }
    }
}
