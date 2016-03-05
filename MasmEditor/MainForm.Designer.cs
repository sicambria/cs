/*
 * Készítette a SharpDevelop.
 * Dátum: 2010.03.05.
 * Idő: 17:16
 */
namespace MasmIDE
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_col_row = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_errorlines = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_editor = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.syntaxRichTextBox1 = new SyntaxHighlighter.SyntaxRichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.betűtípusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formázásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.kivágásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.másolásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beillesztésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.törlésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.visszavonásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ismétToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.újToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.betöltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mentésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parancssorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.futtatásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_log = new System.Windows.Forms.TextBox();
            this.tb_errmsg = new System.Windows.Forms.TextBox();
            this.tab_about = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lab_version = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_run = new System.Windows.Forms.Button();
            this.btn_cmd = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.status_led = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_editor.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tab_about.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.status_col_row,
            this.status_led,
            this.status_errorlines});
            this.statusStrip1.Location = new System.Drawing.Point(0, 738);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(984, 24);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(69, 19);
            this.toolStripStatusLabel1.Text = "MasmEdit v";
            // 
            // status_col_row
            // 
            this.status_col_row.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.status_col_row.Margin = new System.Windows.Forms.Padding(5, 3, 5, 2);
            this.status_col_row.Name = "status_col_row";
            this.status_col_row.Size = new System.Drawing.Size(26, 19);
            this.status_col_row.Text = "1:1";
            // 
            // status_errorlines
            // 
            this.status_errorlines.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.status_errorlines.Name = "status_errorlines";
            this.status_errorlines.Size = new System.Drawing.Size(10, 19);
            this.status_errorlines.Text = " ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "asm";
            this.openFileDialog1.Filter = "Assembly forrásfájlok|*.asm|Minden fájl|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "asm";
            this.saveFileDialog1.Filter = "Assembly forrásfájlok|*.asm|Minden fájl|*.*";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tab_editor);
            this.tabControl1.Controls.Add(this.tab_about);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(980, 702);
            this.tabControl1.TabIndex = 5;
            // 
            // tab_editor
            // 
            this.tab_editor.Controls.Add(this.splitContainer1);
            this.tab_editor.Location = new System.Drawing.Point(4, 22);
            this.tab_editor.Name = "tab_editor";
            this.tab_editor.Padding = new System.Windows.Forms.Padding(3);
            this.tab_editor.Size = new System.Drawing.Size(972, 676);
            this.tab_editor.TabIndex = 0;
            this.tab_editor.Text = "Szerkesztő";
            this.tab_editor.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.NavajoWhite;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.syntaxRichTextBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tb_log);
            this.splitContainer1.Panel2.Controls.Add(this.tb_errmsg);
            this.splitContainer1.Size = new System.Drawing.Size(966, 670);
            this.splitContainer1.SplitterDistance = 634;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 0;
            // 
            // syntaxRichTextBox1
            // 
            this.syntaxRichTextBox1.AcceptsTab = true;
            this.syntaxRichTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.syntaxRichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.syntaxRichTextBox1.EnableAutoDragDrop = true;
            this.syntaxRichTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.syntaxRichTextBox1.Location = new System.Drawing.Point(0, 0);
            this.syntaxRichTextBox1.Name = "syntaxRichTextBox1";
            this.syntaxRichTextBox1.Size = new System.Drawing.Size(632, 668);
            this.syntaxRichTextBox1.TabIndex = 3;
            this.syntaxRichTextBox1.Text = "";
            this.syntaxRichTextBox1.WordWrap = false;
            this.syntaxRichTextBox1.SelectionChanged += new System.EventHandler(this.syntaxRichTextBox1_SelectionChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.betűtípusToolStripMenuItem,
            this.formázásToolStripMenuItem,
            this.toolStripMenuItem1,
            this.kivágásToolStripMenuItem,
            this.másolásToolStripMenuItem,
            this.beillesztésToolStripMenuItem,
            this.törlésToolStripMenuItem,
            this.toolStripMenuItem4,
            this.visszavonásToolStripMenuItem,
            this.ismétToolStripMenuItem,
            this.toolStripMenuItem3,
            this.újToolStripMenuItem,
            this.betöltToolStripMenuItem,
            this.mentésToolStripMenuItem,
            this.parancssorToolStripMenuItem,
            this.futtatásToolStripMenuItem,
            this.toolStripMenuItem2,
            this.kilépésToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 336);
            // 
            // betűtípusToolStripMenuItem
            // 
            this.betűtípusToolStripMenuItem.Name = "betűtípusToolStripMenuItem";
            this.betűtípusToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.betűtípusToolStripMenuItem.Text = "Betűtípus";
            this.betűtípusToolStripMenuItem.Click += new System.EventHandler(this.betűtípusToolStripMenuItem_Click);
            // 
            // formázásToolStripMenuItem
            // 
            this.formázásToolStripMenuItem.Name = "formázásToolStripMenuItem";
            this.formázásToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.formázásToolStripMenuItem.Text = "Formázás";
            this.formázásToolStripMenuItem.Click += new System.EventHandler(this.formázásToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(133, 6);
            // 
            // kivágásToolStripMenuItem
            // 
            this.kivágásToolStripMenuItem.Name = "kivágásToolStripMenuItem";
            this.kivágásToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.kivágásToolStripMenuItem.Text = "Kivágás";
            this.kivágásToolStripMenuItem.Click += new System.EventHandler(this.kivágásToolStripMenuItem_Click);
            // 
            // másolásToolStripMenuItem
            // 
            this.másolásToolStripMenuItem.Name = "másolásToolStripMenuItem";
            this.másolásToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.másolásToolStripMenuItem.Text = "Másolás";
            this.másolásToolStripMenuItem.Click += new System.EventHandler(this.másolásToolStripMenuItem_Click);
            // 
            // beillesztésToolStripMenuItem
            // 
            this.beillesztésToolStripMenuItem.Name = "beillesztésToolStripMenuItem";
            this.beillesztésToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.beillesztésToolStripMenuItem.Text = "Beillesztés";
            this.beillesztésToolStripMenuItem.Click += new System.EventHandler(this.beillesztésToolStripMenuItem_Click);
            // 
            // törlésToolStripMenuItem
            // 
            this.törlésToolStripMenuItem.Name = "törlésToolStripMenuItem";
            this.törlésToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.törlésToolStripMenuItem.Text = "Törlés";
            this.törlésToolStripMenuItem.Click += new System.EventHandler(this.törlésToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(133, 6);
            // 
            // visszavonásToolStripMenuItem
            // 
            this.visszavonásToolStripMenuItem.Name = "visszavonásToolStripMenuItem";
            this.visszavonásToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.visszavonásToolStripMenuItem.Text = "Visszavonás";
            this.visszavonásToolStripMenuItem.Click += new System.EventHandler(this.visszavonásToolStripMenuItem_Click);
            // 
            // ismétToolStripMenuItem
            // 
            this.ismétToolStripMenuItem.Name = "ismétToolStripMenuItem";
            this.ismétToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.ismétToolStripMenuItem.Text = "Ismét";
            this.ismétToolStripMenuItem.Visible = false;
            this.ismétToolStripMenuItem.Click += new System.EventHandler(this.ismétToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(133, 6);
            // 
            // újToolStripMenuItem
            // 
            this.újToolStripMenuItem.Name = "újToolStripMenuItem";
            this.újToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.újToolStripMenuItem.Text = "Új";
            this.újToolStripMenuItem.Click += new System.EventHandler(this.Btn_newClick);
            // 
            // betöltToolStripMenuItem
            // 
            this.betöltToolStripMenuItem.Name = "betöltToolStripMenuItem";
            this.betöltToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.betöltToolStripMenuItem.Text = "Betölt";
            this.betöltToolStripMenuItem.Click += new System.EventHandler(this.Btn_loadClick);
            // 
            // mentésToolStripMenuItem
            // 
            this.mentésToolStripMenuItem.Name = "mentésToolStripMenuItem";
            this.mentésToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.mentésToolStripMenuItem.Text = "Mentés";
            this.mentésToolStripMenuItem.Click += new System.EventHandler(this.Btn_saveClick);
            // 
            // parancssorToolStripMenuItem
            // 
            this.parancssorToolStripMenuItem.Name = "parancssorToolStripMenuItem";
            this.parancssorToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.parancssorToolStripMenuItem.Text = "Parancssor";
            this.parancssorToolStripMenuItem.Click += new System.EventHandler(this.btn_cmd_Click);
            // 
            // futtatásToolStripMenuItem
            // 
            this.futtatásToolStripMenuItem.Name = "futtatásToolStripMenuItem";
            this.futtatásToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.futtatásToolStripMenuItem.Text = "Futtatás";
            this.futtatásToolStripMenuItem.Click += new System.EventHandler(this.Btn_runClick);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(133, 6);
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
            // 
            // tb_log
            // 
            this.tb_log.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tb_log.Location = new System.Drawing.Point(0, 484);
            this.tb_log.Multiline = true;
            this.tb_log.Name = "tb_log";
            this.tb_log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_log.Size = new System.Drawing.Size(322, 184);
            this.tb_log.TabIndex = 3;
            // 
            // tb_errmsg
            // 
            this.tb_errmsg.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_errmsg.Location = new System.Drawing.Point(0, 0);
            this.tb_errmsg.Multiline = true;
            this.tb_errmsg.Name = "tb_errmsg";
            this.tb_errmsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_errmsg.Size = new System.Drawing.Size(322, 478);
            this.tb_errmsg.TabIndex = 2;
            // 
            // tab_about
            // 
            this.tab_about.Controls.Add(this.richTextBox1);
            this.tab_about.Controls.Add(this.lab_version);
            this.tab_about.Location = new System.Drawing.Point(4, 22);
            this.tab_about.Name = "tab_about";
            this.tab_about.Padding = new System.Windows.Forms.Padding(3);
            this.tab_about.Size = new System.Drawing.Size(965, 676);
            this.tab_about.TabIndex = 1;
            this.tab_about.Text = "Névjegy";
            this.tab_about.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(6, 54);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(953, 616);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // lab_version
            // 
            this.lab_version.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_version.Location = new System.Drawing.Point(6, 12);
            this.lab_version.Name = "lab_version";
            this.lab_version.Size = new System.Drawing.Size(494, 39);
            this.lab_version.TabIndex = 1;
            this.lab_version.Text = "MASM Editor";
            // 
            // fontDialog1
            // 
            this.fontDialog1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1DoWork);
            // 
            // btn_run
            // 
            this.btn_run.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_run.AutoSize = true;
            this.btn_run.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_run.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_run.Location = new System.Drawing.Point(393, 2);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(177, 30);
            this.btn_run.TabIndex = 4;
            this.btn_run.Text = "Fordítás és futtatás";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.Btn_runClick);
            // 
            // btn_cmd
            // 
            this.btn_cmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cmd.AutoSize = true;
            this.btn_cmd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_cmd.Location = new System.Drawing.Point(288, 2);
            this.btn_cmd.Name = "btn_cmd";
            this.btn_cmd.Size = new System.Drawing.Size(99, 30);
            this.btn_cmd.TabIndex = 5;
            this.btn_cmd.Text = "Parancssor";
            this.btn_cmd.UseVisualStyleBackColor = true;
            this.btn_cmd.Click += new System.EventHandler(this.btn_cmd_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.AutoSize = true;
            this.btn_save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_save.Location = new System.Drawing.Point(145, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(137, 30);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Mentés másként";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.Btn_saveClick);
            // 
            // btn_load
            // 
            this.btn_load.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_load.AutoSize = true;
            this.btn_load.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_load.Location = new System.Drawing.Point(78, 2);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(61, 30);
            this.btn_load.TabIndex = 7;
            this.btn_load.Text = "Betölt";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.Btn_loadClick);
            // 
            // btn_new
            // 
            this.btn_new.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_new.AutoSize = true;
            this.btn_new.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_new.Location = new System.Drawing.Point(12, 2);
            this.btn_new.MinimumSize = new System.Drawing.Size(60, 0);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(60, 30);
            this.btn_new.TabIndex = 6;
            this.btn_new.Text = "Új";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.Btn_newClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btn_new);
            this.panel1.Controls.Add(this.btn_load);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_cmd);
            this.panel1.Controls.Add(this.btn_run);
            this.panel1.Location = new System.Drawing.Point(4, 702);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 33);
            this.panel1.TabIndex = 6;
            // 
            // status_led
            // 
            this.status_led.Name = "status_led";
            this.status_led.Size = new System.Drawing.Size(16, 19);
            this.status_led.Text = "   ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 762);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MASM szerkesztő";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tab_editor.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tab_about.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lab_version;
        private System.Windows.Forms.FontDialog fontDialog1;
		private System.Windows.Forms.TabPage tab_about;
		private System.Windows.Forms.TabPage tab_editor;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		
		void Button2Click(object sender, System.EventArgs e)
		{
			

        }

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem betűtípusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formázásToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem újToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem betöltToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mentésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parancssorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem futtatásToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.Button btn_cmd;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripStatusLabel status_col_row;
        private System.Windows.Forms.ToolStripStatusLabel status_errorlines;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem törlésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem másolásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kivágásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beillesztésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visszavonásToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem ismétToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        public SyntaxHighlighter.SyntaxRichTextBox syntaxRichTextBox1;
        private System.Windows.Forms.TextBox tb_errmsg;
        private System.Windows.Forms.TextBox tb_log;
        private System.Windows.Forms.ToolStripStatusLabel status_led;
	}
}
