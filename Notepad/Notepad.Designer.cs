﻿namespace Notepad
{
	partial class Notepad
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.newFileMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.openFileMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.saveFileMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsFileMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.exitFileMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.undoEditMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.cutEditMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.cipyEditMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteEditMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteEditMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileMenu
			// 
			this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileMenu,
            this.openFileMenu,
            this.saveFileMenu,
            this.saveAsFileMenu,
            this.exitFileMenu});
			this.fileMenu.Name = "fileMenu";
			this.fileMenu.Size = new System.Drawing.Size(37, 20);
			this.fileMenu.Text = "File";
			// 
			// newFileMenu
			// 
			this.newFileMenu.Name = "newFileMenu";
			this.newFileMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.newFileMenu.Size = new System.Drawing.Size(180, 22);
			this.newFileMenu.Text = "New";
			// 
			// openFileMenu
			// 
			this.openFileMenu.Name = "openFileMenu";
			this.openFileMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openFileMenu.Size = new System.Drawing.Size(180, 22);
			this.openFileMenu.Text = "Open";
			// 
			// saveFileMenu
			// 
			this.saveFileMenu.Name = "saveFileMenu";
			this.saveFileMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveFileMenu.Size = new System.Drawing.Size(180, 22);
			this.saveFileMenu.Text = "Save";
			// 
			// saveAsFileMenu
			// 
			this.saveAsFileMenu.Name = "saveAsFileMenu";
			this.saveAsFileMenu.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
			this.saveAsFileMenu.Size = new System.Drawing.Size(180, 22);
			this.saveAsFileMenu.Text = "Save As";
			// 
			// exitFileMenu
			// 
			this.exitFileMenu.Name = "exitFileMenu";
			this.exitFileMenu.Size = new System.Drawing.Size(180, 22);
			this.exitFileMenu.Text = "Exit";
			// 
			// editMenu
			// 
			this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoEditMenu,
            this.cutEditMenu,
            this.cipyEditMenu,
            this.pasteEditMenu,
            this.deleteEditMenu});
			this.editMenu.Name = "editMenu";
			this.editMenu.Size = new System.Drawing.Size(39, 20);
			this.editMenu.Text = "Edit";
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem1});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.viewToolStripMenuItem.Text = "View";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// richTextBox1
			// 
			this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox1.Location = new System.Drawing.Point(0, 24);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(800, 426);
			this.richTextBox1.TabIndex = 2;
			this.richTextBox1.Text = "";
			// 
			// undoEditMenu
			// 
			this.undoEditMenu.Name = "undoEditMenu";
			this.undoEditMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
			this.undoEditMenu.Size = new System.Drawing.Size(180, 22);
			this.undoEditMenu.Text = "Undo";
			// 
			// cutEditMenu
			// 
			this.cutEditMenu.Name = "cutEditMenu";
			this.cutEditMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.cutEditMenu.Size = new System.Drawing.Size(180, 22);
			this.cutEditMenu.Text = "Cut";
			// 
			// cipyEditMenu
			// 
			this.cipyEditMenu.Name = "cipyEditMenu";
			this.cipyEditMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.cipyEditMenu.Size = new System.Drawing.Size(180, 22);
			this.cipyEditMenu.Text = "Copy";
			// 
			// pasteEditMenu
			// 
			this.pasteEditMenu.Name = "pasteEditMenu";
			this.pasteEditMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.pasteEditMenu.Size = new System.Drawing.Size(180, 22);
			this.pasteEditMenu.Text = "Paste";
			// 
			// deleteEditMenu
			// 
			this.deleteEditMenu.Name = "deleteEditMenu";
			this.deleteEditMenu.ShortcutKeys = System.Windows.Forms.Keys.Delete;
			this.deleteEditMenu.Size = new System.Drawing.Size(180, 22);
			this.deleteEditMenu.Text = "Delete";
			// 
			// helpToolStripMenuItem1
			// 
			this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
			this.helpToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
			this.helpToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
			this.helpToolStripMenuItem1.Text = "Help?";
			// 
			// viewToolStripMenuItem1
			// 
			this.viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
			this.viewToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.V)));
			this.viewToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
			this.viewToolStripMenuItem1.Text = "View";
			// 
			// Notepad
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Notepad";
			this.Text = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileMenu;
		private System.Windows.Forms.ToolStripMenuItem newFileMenu;
		private System.Windows.Forms.ToolStripMenuItem openFileMenu;
		private System.Windows.Forms.ToolStripMenuItem saveFileMenu;
		private System.Windows.Forms.ToolStripMenuItem saveAsFileMenu;
		private System.Windows.Forms.ToolStripMenuItem exitFileMenu;
		private System.Windows.Forms.ToolStripMenuItem editMenu;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.ToolStripMenuItem undoEditMenu;
		private System.Windows.Forms.ToolStripMenuItem cutEditMenu;
		private System.Windows.Forms.ToolStripMenuItem cipyEditMenu;
		private System.Windows.Forms.ToolStripMenuItem pasteEditMenu;
		private System.Windows.Forms.ToolStripMenuItem deleteEditMenu;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
	}
}

