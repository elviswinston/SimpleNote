namespace SimpleNote.Views
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trashNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelAllNote = new System.Windows.Forms.Panel();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.panelNoteDescription = new System.Windows.Forms.Panel();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxToggleSidebar = new System.Windows.Forms.PictureBox();
            this.pictureBoxTrash = new System.Windows.Forms.PictureBox();
            this.panelNoteReview = new System.Windows.Forms.Panel();
            this.checkedListBoxNote = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxSlideMenu = new System.Windows.Forms.PictureBox();
            this.pictureBoxNewNote = new System.Windows.Forms.PictureBox();
            this.textBoxNoteSearch = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelSlideMenu = new System.Windows.Forms.Panel();
            this.pictureBoxTrashNote = new System.Windows.Forms.PictureBox();
            this.pictureBoxAllNote = new System.Windows.Forms.PictureBox();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelAllNote.SuspendLayout();
            this.panelNoteDescription.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToggleSidebar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrash)).BeginInit();
            this.panelNoteReview.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlideMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNewNote)).BeginInit();
            this.panelSlideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrashNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAllNote)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1254, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newNoteToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(41, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newNoteToolStripMenuItem
            // 
            this.newNoteToolStripMenuItem.Name = "newNoteToolStripMenuItem";
            this.newNoteToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.newNoteToolStripMenuItem.Text = "New Note";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trashNoteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // trashNoteToolStripMenuItem
            // 
            this.trashNoteToolStripMenuItem.Name = "trashNoteToolStripMenuItem";
            this.trashNoteToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.trashNoteToolStripMenuItem.Text = "Trash Note";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(50, 23);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelAllNote);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.panelSlideMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 599);
            this.panel1.TabIndex = 1;
            // 
            // panelAllNote
            // 
            this.panelAllNote.Controls.Add(this.splitter3);
            this.panelAllNote.Controls.Add(this.panelNoteDescription);
            this.panelAllNote.Controls.Add(this.panelNoteReview);
            this.panelAllNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAllNote.Location = new System.Drawing.Point(206, 0);
            this.panelAllNote.Name = "panelAllNote";
            this.panelAllNote.Size = new System.Drawing.Size(1048, 599);
            this.panelAllNote.TabIndex = 4;
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(343, 0);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(1, 599);
            this.splitter3.TabIndex = 5;
            this.splitter3.TabStop = false;
            // 
            // panelNoteDescription
            // 
            this.panelNoteDescription.BackColor = System.Drawing.Color.White;
            this.panelNoteDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNoteDescription.Controls.Add(this.richTextBoxDescription);
            this.panelNoteDescription.Controls.Add(this.tableLayoutPanel1);
            this.panelNoteDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNoteDescription.Location = new System.Drawing.Point(343, 0);
            this.panelNoteDescription.Name = "panelNoteDescription";
            this.panelNoteDescription.Size = new System.Drawing.Size(705, 599);
            this.panelNoteDescription.TabIndex = 4;
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxDescription.Enabled = false;
            this.richTextBoxDescription.Font = new System.Drawing.Font("Calibri", 12.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxDescription.ForeColor = System.Drawing.Color.LightGray;
            this.richTextBoxDescription.Location = new System.Drawing.Point(0, 33);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(703, 564);
            this.richTextBoxDescription.TabIndex = 3;
            this.richTextBoxDescription.Text = "Note text...";
            this.richTextBoxDescription.TextChanged += new System.EventHandler(this.richTextBoxDescription_TextChanged);
            this.richTextBoxDescription.Enter += new System.EventHandler(this.richTextBoxDescription_Enter);
            this.richTextBoxDescription.Leave += new System.EventHandler(this.richTextBoxDescription_Leave);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Azure;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.733333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.26667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxToggleSidebar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxTrash, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(703, 33);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // pictureBoxToggleSidebar
            // 
            this.pictureBoxToggleSidebar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxToggleSidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxToggleSidebar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxToggleSidebar.Image")));
            this.pictureBoxToggleSidebar.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxToggleSidebar.Name = "pictureBoxToggleSidebar";
            this.pictureBoxToggleSidebar.Size = new System.Drawing.Size(31, 27);
            this.pictureBoxToggleSidebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxToggleSidebar.TabIndex = 0;
            this.pictureBoxToggleSidebar.TabStop = false;
            this.pictureBoxToggleSidebar.Click += new System.EventHandler(this.pictureBoxToggleSidebar_Click);
            // 
            // pictureBoxTrash
            // 
            this.pictureBoxTrash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxTrash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxTrash.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTrash.Image")));
            this.pictureBoxTrash.Location = new System.Drawing.Point(653, 3);
            this.pictureBoxTrash.Name = "pictureBoxTrash";
            this.pictureBoxTrash.Size = new System.Drawing.Size(47, 27);
            this.pictureBoxTrash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTrash.TabIndex = 1;
            this.pictureBoxTrash.TabStop = false;
            // 
            // panelNoteReview
            // 
            this.panelNoteReview.BackColor = System.Drawing.Color.White;
            this.panelNoteReview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNoteReview.Controls.Add(this.checkedListBoxNote);
            this.panelNoteReview.Controls.Add(this.tableLayoutPanel2);
            this.panelNoteReview.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNoteReview.Location = new System.Drawing.Point(0, 0);
            this.panelNoteReview.Name = "panelNoteReview";
            this.panelNoteReview.Size = new System.Drawing.Size(343, 599);
            this.panelNoteReview.TabIndex = 3;
            // 
            // checkedListBoxNote
            // 
            this.checkedListBoxNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxNote.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkedListBoxNote.Font = new System.Drawing.Font("Calibri", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxNote.FormattingEnabled = true;
            this.checkedListBoxNote.Location = new System.Drawing.Point(0, 33);
            this.checkedListBoxNote.Name = "checkedListBoxNote";
            this.checkedListBoxNote.Size = new System.Drawing.Size(285, 564);
            this.checkedListBoxNote.TabIndex = 2;
            this.checkedListBoxNote.Click += new System.EventHandler(this.checkedListBoxNote_Click);
            this.checkedListBoxNote.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxNote_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Azure;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.13953F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.86047F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBoxSlideMenu, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBoxNewNote, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxNoteSearch, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(341, 33);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // pictureBoxSlideMenu
            // 
            this.pictureBoxSlideMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSlideMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxSlideMenu.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSlideMenu.Image")));
            this.pictureBoxSlideMenu.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxSlideMenu.Name = "pictureBoxSlideMenu";
            this.pictureBoxSlideMenu.Size = new System.Drawing.Size(46, 27);
            this.pictureBoxSlideMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSlideMenu.TabIndex = 0;
            this.pictureBoxSlideMenu.TabStop = false;
            this.pictureBoxSlideMenu.Click += new System.EventHandler(this.pictureBoxSlideMenu_Click);
            // 
            // pictureBoxNewNote
            // 
            this.pictureBoxNewNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxNewNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxNewNote.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNewNote.Image")));
            this.pictureBoxNewNote.Location = new System.Drawing.Point(291, 3);
            this.pictureBoxNewNote.Name = "pictureBoxNewNote";
            this.pictureBoxNewNote.Size = new System.Drawing.Size(47, 27);
            this.pictureBoxNewNote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNewNote.TabIndex = 1;
            this.pictureBoxNewNote.TabStop = false;
            this.pictureBoxNewNote.Click += new System.EventHandler(this.pictureBoxNewNote_Click);
            // 
            // textBoxNoteSearch
            // 
            this.textBoxNoteSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNoteSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxNoteSearch.Font = new System.Drawing.Font("Calibri", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNoteSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxNoteSearch.Location = new System.Drawing.Point(55, 3);
            this.textBoxNoteSearch.Name = "textBoxNoteSearch";
            this.textBoxNoteSearch.Size = new System.Drawing.Size(230, 29);
            this.textBoxNoteSearch.TabIndex = 2;
            this.textBoxNoteSearch.Text = " All Note";
            this.textBoxNoteSearch.Enter += new System.EventHandler(this.textBoxNoteSearch_Enter);
            this.textBoxNoteSearch.Leave += new System.EventHandler(this.textBoxNoteSearch_Leave);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(205, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1, 599);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // panelSlideMenu
            // 
            this.panelSlideMenu.BackColor = System.Drawing.Color.LightCyan;
            this.panelSlideMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSlideMenu.Controls.Add(this.pictureBoxTrashNote);
            this.panelSlideMenu.Controls.Add(this.pictureBoxAllNote);
            this.panelSlideMenu.Controls.Add(this.splitter4);
            this.panelSlideMenu.Controls.Add(this.splitter2);
            this.panelSlideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSlideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSlideMenu.Name = "panelSlideMenu";
            this.panelSlideMenu.Size = new System.Drawing.Size(205, 599);
            this.panelSlideMenu.TabIndex = 0;
            // 
            // pictureBoxTrashNote
            // 
            this.pictureBoxTrashNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxTrashNote.Image = global::SimpleNote.Properties.Resources.trash_note_icon;
            this.pictureBoxTrashNote.Location = new System.Drawing.Point(3, 70);
            this.pictureBoxTrashNote.Name = "pictureBoxTrashNote";
            this.pictureBoxTrashNote.Size = new System.Drawing.Size(197, 44);
            this.pictureBoxTrashNote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTrashNote.TabIndex = 3;
            this.pictureBoxTrashNote.TabStop = false;
            this.pictureBoxTrashNote.Click += new System.EventHandler(this.pictureBoxTrashNote_Click);
            // 
            // pictureBoxAllNote
            // 
            this.pictureBoxAllNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAllNote.Image = global::SimpleNote.Properties.Resources.all_note_icon;
            this.pictureBoxAllNote.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxAllNote.Name = "pictureBoxAllNote";
            this.pictureBoxAllNote.Size = new System.Drawing.Size(197, 44);
            this.pictureBoxAllNote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAllNote.TabIndex = 2;
            this.pictureBoxAllNote.TabStop = false;
            this.pictureBoxAllNote.Click += new System.EventHandler(this.pictureBoxAllNote_Click);
            // 
            // splitter4
            // 
            this.splitter4.BackColor = System.Drawing.Color.LightCyan;
            this.splitter4.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter4.Location = new System.Drawing.Point(201, 0);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(1, 597);
            this.splitter4.TabIndex = 1;
            this.splitter4.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(202, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(1, 597);
            this.splitter2.TabIndex = 0;
            this.splitter2.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1254, 626);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Note";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelAllNote.ResumeLayout(false);
            this.panelNoteDescription.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToggleSidebar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrash)).EndInit();
            this.panelNoteReview.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlideMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNewNote)).EndInit();
            this.panelSlideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrashNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAllNote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trashNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelSlideMenu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel panelAllNote;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Panel panelNoteDescription;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBoxToggleSidebar;
        private System.Windows.Forms.PictureBox pictureBoxTrash;
        private System.Windows.Forms.Panel panelNoteReview;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBoxSlideMenu;
        private System.Windows.Forms.PictureBox pictureBoxNewNote;
        private System.Windows.Forms.TextBox textBoxNoteSearch;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.PictureBox pictureBoxAllNote;
        private System.Windows.Forms.PictureBox pictureBoxTrashNote;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.CheckedListBox checkedListBoxNote;
    }
}