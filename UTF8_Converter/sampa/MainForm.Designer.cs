/*
 * Készítette a SharpDevelop.
 * Felhasználó: Atlantis
 * Dátum: 2009.07.23.
 * Idő: 13:29
 * 
 * A sablon megváltoztatásához használja az Eszközök | Beállítások | Kódolás | Szabvány Fejlécek Szerkesztését.
 */
namespace sampa
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
            this.list_items = new System.Windows.Forms.ListBox();
            this.list_repaired = new System.Windows.Forms.ListBox();
            this.btn_load = new System.Windows.Forms.Button();
            this.open_txt = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button5 = new System.Windows.Forms.Button();
            this.chb_onlyphoneme = new System.Windows.Forms.CheckBox();
            this.chb_upper = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.combo_sampatype = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_wordconverted = new System.Windows.Forms.TextBox();
            this.tb_word = new System.Windows.Forms.TextBox();
            this.btn_convertword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_items
            // 
            this.list_items.FormattingEnabled = true;
            this.list_items.Location = new System.Drawing.Point(12, 12);
            this.list_items.Name = "list_items";
            this.list_items.Size = new System.Drawing.Size(349, 225);
            this.list_items.TabIndex = 0;
            // 
            // list_repaired
            // 
            this.list_repaired.FormattingEnabled = true;
            this.list_repaired.Location = new System.Drawing.Point(379, 12);
            this.list_repaired.Name = "list_repaired";
            this.list_repaired.Size = new System.Drawing.Size(490, 225);
            this.list_repaired.TabIndex = 1;
            // 
            // btn_load
            // 
            this.btn_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_load.Location = new System.Drawing.Point(135, 243);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(134, 42);
            this.btn_load.TabIndex = 2;
            this.btn_load.Text = "Betöltés - Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.Btn_loadClick);
            // 
            // open_txt
            // 
            this.open_txt.Filter = "TXT szövegfájl|*.txt|SQL fájl|*.sql|Minden fájl|*.*";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(12, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(349, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Konvertálás - Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "UTF-8",
            "ANSI",
            "ASCII"});
            this.comboBox1.Location = new System.Drawing.Point(184, 293);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(85, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "UTF-8";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(12, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 42);
            this.button2.TabIndex = 5;
            this.button2.Text = "Törlés - Del";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(379, 243);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 42);
            this.button3.TabIndex = 6;
            this.button3.Text = "Törlés - Del";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(376, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "UTF-8 konvertáló";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(379, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "http://en.wikipedia.org/wiki/UTF-8";
            this.label2.Click += new System.EventHandler(this.Label2Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(674, 246);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(195, 60);
            this.button4.TabIndex = 9;
            this.button4.Text = "Mentés - Save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "TXT szövegfájl|*.txt|SQL fájl|*.sql|Minden fájl|*.*";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(674, 371);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(195, 37);
            this.button5.TabIndex = 10;
            this.button5.Text = "Kilépés - Exit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5Click);
            // 
            // chb_onlyphoneme
            // 
            this.chb_onlyphoneme.Checked = true;
            this.chb_onlyphoneme.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_onlyphoneme.Location = new System.Drawing.Point(275, 243);
            this.chb_onlyphoneme.Name = "chb_onlyphoneme";
            this.chb_onlyphoneme.Size = new System.Drawing.Size(98, 24);
            this.chb_onlyphoneme.TabIndex = 11;
            this.chb_onlyphoneme.Text = "Csak az új";
            this.chb_onlyphoneme.UseVisualStyleBackColor = true;
            this.chb_onlyphoneme.CheckedChanged += new System.EventHandler(this.Chb_onlyphonemeCheckedChanged);
            // 
            // chb_upper
            // 
            this.chb_upper.Location = new System.Drawing.Point(275, 281);
            this.chb_upper.Name = "chb_upper";
            this.chb_upper.Size = new System.Drawing.Size(98, 24);
            this.chb_upper.TabIndex = 12;
            this.chb_upper.Text = "NAGYBETŰS";
            this.chb_upper.UseVisualStyleBackColor = true;
            this.chb_upper.CheckedChanged += new System.EventHandler(this.chb_upper_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(290, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "New only";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(292, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "CAPITAL";
            // 
            // combo_sampatype
            // 
            this.combo_sampatype.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.combo_sampatype.FormattingEnabled = true;
            this.combo_sampatype.Items.AddRange(new object[] {
            "BROKEN-UTF8"});
            this.combo_sampatype.Location = new System.Drawing.Point(12, 293);
            this.combo_sampatype.Name = "combo_sampatype";
            this.combo_sampatype.Size = new System.Drawing.Size(166, 21);
            this.combo_sampatype.TabIndex = 16;
            this.combo_sampatype.Text = "BROKEN-UTF8";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 23);
            this.label6.TabIndex = 17;
            this.label6.Text = "Szó konvertálása - Convert a word";
            // 
            // tb_wordconverted
            // 
            this.tb_wordconverted.Location = new System.Drawing.Point(337, 381);
            this.tb_wordconverted.Name = "tb_wordconverted";
            this.tb_wordconverted.Size = new System.Drawing.Size(318, 20);
            this.tb_wordconverted.TabIndex = 18;
            // 
            // tb_word
            // 
            this.tb_word.Location = new System.Drawing.Point(14, 381);
            this.tb_word.Name = "tb_word";
            this.tb_word.Size = new System.Drawing.Size(228, 20);
            this.tb_word.TabIndex = 19;
            this.tb_word.TextChanged += new System.EventHandler(this.Tb_wordTextChanged);
            // 
            // btn_convertword
            // 
            this.btn_convertword.Location = new System.Drawing.Point(264, 379);
            this.btn_convertword.Name = "btn_convertword";
            this.btn_convertword.Size = new System.Drawing.Size(55, 23);
            this.btn_convertword.TabIndex = 20;
            this.btn_convertword.Text = "----->";
            this.btn_convertword.UseVisualStyleBackColor = true;
            this.btn_convertword.Click += new System.EventHandler(this.Button6Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 417);
            this.Controls.Add(this.btn_convertword);
            this.Controls.Add(this.tb_word);
            this.Controls.Add(this.tb_wordconverted);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.combo_sampatype);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chb_upper);
            this.Controls.Add(this.chb_onlyphoneme);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.list_repaired);
            this.Controls.Add(this.list_items);
            this.Name = "MainForm";
            this.Text = "Broken UTF-8 konverter";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.Button btn_convertword;
		private System.Windows.Forms.TextBox tb_word;
		private System.Windows.Forms.TextBox tb_wordconverted;
		private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combo_sampatype;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox chb_upper;
		private System.Windows.Forms.CheckBox chb_onlyphoneme;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ListBox list_repaired;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ListBox list_items;
		private System.Windows.Forms.OpenFileDialog open_txt;
		private System.Windows.Forms.Button btn_load;
	}
}
