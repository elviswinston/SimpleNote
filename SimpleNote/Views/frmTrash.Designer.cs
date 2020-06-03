namespace SimpleNote.Views
{
    partial class frmTrash
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrash));
            this.panelAllNote = new System.Windows.Forms.Panel();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.panelNoteDescription = new System.Windows.Forms.Panel();
            this.richTextBoxTrashDescription = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRestoreTrash = new System.Windows.Forms.Button();
            this.btnDeleteTrash = new System.Windows.Forms.Button();
            this.panelTrashNoteReview = new System.Windows.Forms.Panel();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxNewNote = new System.Windows.Forms.PictureBox();
            this.textBoxTrashNoteSearch = new System.Windows.Forms.TextBox();
            this.panelAllNote.SuspendLayout();
            this.panelNoteDescription.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelTrashNoteReview.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNewNote)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAllNote
            // 
            this.panelAllNote.Controls.Add(this.splitter3);
            this.panelAllNote.Controls.Add(this.panelNoteDescription);
            this.panelAllNote.Controls.Add(this.panelTrashNoteReview);
            this.panelAllNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAllNote.Location = new System.Drawing.Point(0, 0);
            this.panelAllNote.Name = "panelAllNote";
            this.panelAllNote.Size = new System.Drawing.Size(915, 565);
            this.panelAllNote.TabIndex = 5;
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(343, 0);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(1, 565);
            this.splitter3.TabIndex = 5;
            this.splitter3.TabStop = false;
            // 
            // panelNoteDescription
            // 
            this.panelNoteDescription.BackColor = System.Drawing.Color.White;
            this.panelNoteDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNoteDescription.Controls.Add(this.richTextBoxTrashDescription);
            this.panelNoteDescription.Controls.Add(this.tableLayoutPanel1);
            this.panelNoteDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNoteDescription.Location = new System.Drawing.Point(343, 0);
            this.panelNoteDescription.Name = "panelNoteDescription";
            this.panelNoteDescription.Size = new System.Drawing.Size(572, 565);
            this.panelNoteDescription.TabIndex = 4;
            // 
            // richTextBoxTrashDescription
            // 
            this.richTextBoxTrashDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxTrashDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxTrashDescription.Font = new System.Drawing.Font("Calibri", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxTrashDescription.ForeColor = System.Drawing.Color.Black;
            this.richTextBoxTrashDescription.Location = new System.Drawing.Point(0, 35);
            this.richTextBoxTrashDescription.Name = "richTextBoxTrashDescription";
            this.richTextBoxTrashDescription.ReadOnly = true;
            this.richTextBoxTrashDescription.Size = new System.Drawing.Size(570, 528);
            this.richTextBoxTrashDescription.TabIndex = 3;
            this.richTextBoxTrashDescription.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Azure;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.tableLayoutPanel1.Controls.Add(this.btnRestoreTrash, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDeleteTrash, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(570, 35);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnRestoreTrash
            // 
            this.btnRestoreTrash.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRestoreTrash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRestoreTrash.FlatAppearance.BorderSize = 0;
            this.btnRestoreTrash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestoreTrash.Font = new System.Drawing.Font("Calibri", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestoreTrash.ForeColor = System.Drawing.Color.White;
            this.btnRestoreTrash.Location = new System.Drawing.Point(432, 3);
            this.btnRestoreTrash.Name = "btnRestoreTrash";
            this.btnRestoreTrash.Size = new System.Drawing.Size(135, 29);
            this.btnRestoreTrash.TabIndex = 0;
            this.btnRestoreTrash.Text = "Restore Note";
            this.btnRestoreTrash.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRestoreTrash.UseVisualStyleBackColor = false;
            this.btnRestoreTrash.Click += new System.EventHandler(this.btnRestoreTrash_Click);
            // 
            // btnDeleteTrash
            // 
            this.btnDeleteTrash.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteTrash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteTrash.FlatAppearance.BorderSize = 2;
            this.btnDeleteTrash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTrash.Font = new System.Drawing.Font("Calibri", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTrash.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteTrash.Location = new System.Drawing.Point(289, 3);
            this.btnDeleteTrash.Name = "btnDeleteTrash";
            this.btnDeleteTrash.Size = new System.Drawing.Size(137, 29);
            this.btnDeleteTrash.TabIndex = 1;
            this.btnDeleteTrash.Text = "Delete Forever";
            this.btnDeleteTrash.UseVisualStyleBackColor = false;
            this.btnDeleteTrash.Click += new System.EventHandler(this.btnDeleteTrash_Click);
            // 
            // panelTrashNoteReview
            // 
            this.panelTrashNoteReview.BackColor = System.Drawing.Color.White;
            this.panelTrashNoteReview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTrashNoteReview.Controls.Add(this.checkedListBox1);
            this.panelTrashNoteReview.Controls.Add(this.tableLayoutPanel2);
            this.panelTrashNoteReview.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTrashNoteReview.Location = new System.Drawing.Point(0, 0);
            this.panelTrashNoteReview.Name = "panelTrashNoteReview";
            this.panelTrashNoteReview.Size = new System.Drawing.Size(343, 565);
            this.panelTrashNoteReview.TabIndex = 3;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkedListBox1.Font = new System.Drawing.Font("Calibri", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(0, 33);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(289, 530);
            this.checkedListBox1.TabIndex = 2;
            this.checkedListBox1.Click += new System.EventHandler(this.checkedListBox1_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Azure;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBoxNewNote, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxTrashNoteSearch, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(341, 33);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // pictureBoxNewNote
            // 
            this.pictureBoxNewNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxNewNote.Enabled = false;
            this.pictureBoxNewNote.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNewNote.Image")));
            this.pictureBoxNewNote.Location = new System.Drawing.Point(295, 3);
            this.pictureBoxNewNote.Name = "pictureBoxNewNote";
            this.pictureBoxNewNote.Size = new System.Drawing.Size(43, 27);
            this.pictureBoxNewNote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNewNote.TabIndex = 1;
            this.pictureBoxNewNote.TabStop = false;
            // 
            // textBoxTrashNoteSearch
            // 
            this.textBoxTrashNoteSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTrashNoteSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxTrashNoteSearch.Font = new System.Drawing.Font("Calibri", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTrashNoteSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxTrashNoteSearch.Location = new System.Drawing.Point(3, 3);
            this.textBoxTrashNoteSearch.Name = "textBoxTrashNoteSearch";
            this.textBoxTrashNoteSearch.Size = new System.Drawing.Size(286, 29);
            this.textBoxTrashNoteSearch.TabIndex = 2;
            this.textBoxTrashNoteSearch.Text = "Trash";
            this.textBoxTrashNoteSearch.Enter += new System.EventHandler(this.textBoxTrashNoteSearch_Enter);
            this.textBoxTrashNoteSearch.Leave += new System.EventHandler(this.textBoxTrashNoteSearch_Leave);
            // 
            // frmTrash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 565);
            this.Controls.Add(this.panelAllNote);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTrash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trash";
            this.Load += new System.EventHandler(this.frmTrash_Load);
            this.panelAllNote.ResumeLayout(false);
            this.panelNoteDescription.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelTrashNoteReview.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNewNote)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAllNote;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Panel panelNoteDescription;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelTrashNoteReview;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBoxNewNote;
        private System.Windows.Forms.TextBox textBoxTrashNoteSearch;
        private System.Windows.Forms.Button btnRestoreTrash;
        private System.Windows.Forms.Button btnDeleteTrash;
        public System.Windows.Forms.RichTextBox richTextBoxTrashDescription;
        public System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}