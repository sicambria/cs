/*
 * Készítette a SharpDevelop.
 * Felhasználó: Sicambria
 * Dátum: 2009.07.23.
 * Idő: 13:29
 * 
 * GNU GENERAL PUBLIC LICENSE
 *  Version 3, 29 June 2007
 * 
 * 
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;

namespace sampa
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }

        string encoding = "UTF-8";  // ANSI
        public string Encoding
        {
            get { return encoding; }
            set { encoding = value; }
        }

        void Btn_loadClick(object sender, EventArgs e)
        {
            string temp;
            string src_filename;

            if (open_txt.ShowDialog() == DialogResult.OK) //Beolvasás TXT-ből
            {
                try
                {
                    src_filename = open_txt.FileName;
                    // Fájlok átkódolása UTF-8 formátumba
                    if (encoding == "ANSI")
                    {
                        EncoderClass.EncodeWindowsAnsiDefaultToUTF8(src_filename);
                        src_filename += "_utf8.txt";
                    }
                    else if (encoding == "ASCII")
                    {
                        EncoderClass.EncodeASCIIToUTF8(src_filename);
                        src_filename += "_utf8.txt";
                    }
                    list_items.Items.Clear();

                    TextReader targyak = new StreamReader(src_filename);
                    //TextReader targyak = new StreamReader(open_txt.FileName);

                    while (targyak.Peek() >= 0)
                    {
                        temp = targyak.ReadLine();
                        list_items.Items.Add(temp);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }



        void Button1Click(object sender, EventArgs e)
        {
            list_repaired.Items.Clear();

            for (int i = 0; i < list_items.Items.Count; i++)
            {
                string currentitem = list_items.Items[i].ToString();

                string converteditem = currentitem;    //.ToUpper();



                if (combo_sampatype.Text == "BROKEN-UTF8")
                {
                    converteditem = RepairBrokenUtf(converteditem);
                }



                if (chb_onlyphoneme.Checked)
                {
                    list_repaired.Items.Add(converteditem);
                }
                else
                {
                    if (chb_upper.Checked)
                    {
                        list_repaired.Items.Add(currentitem.ToUpper() + " " + converteditem);
                    }
                    else
                    {
                        list_repaired.Items.Add(currentitem + " " + converteditem);
                    }

                }
            }
        }

        static string RepairBrokenUtf(string input)
        {
            //StringBuilder sb = new StringBuilder(Regex.Replace(input, "((?<=[^SD])Z(?=[^S]))", "z "));

            StringBuilder sb = new StringBuilder(input);

            //---capital letters---

            // A Ã E Ã‰ I Ã o Ã“ Ã– Å U Ãš Ãœ Å°

            sb.Replace("Ã", "Á");

            sb.Replace("Ã‰", "É");

            sb.Replace("Ã", "Í");

            sb.Replace("Ã“", "Ó");
            sb.Replace("Ã–", "Ö");
            sb.Replace("Å", "Ő");

            sb.Replace("Ãš", "Ú");
            sb.Replace("Ãœ", "Ü");
            sb.Replace("Å°", "Ű");

            //---small letters---


            // a Ã¡ e Ã© i Ã­ o Ã³ Ã¶ Å‘ u Ãº Ã¼ Å±


            sb.Replace("Ã¡", "á");

            sb.Replace("Ã©", "é");

            sb.Replace("Ã­", "í");

            sb.Replace("Ã³", "ó");
            sb.Replace("Ã¶", "ö");
            sb.Replace("Å‘", "ő");

            sb.Replace("Ãº", "ú");
            sb.Replace("Ã¼", "ü");
            sb.Replace("Å±", "ű");

            // ---symbols---

            // replace order is important!

            sb.Replace("â€¦", "…");
            sb.Replace("â€“", "–");  

            sb.Replace("â€ž", "„");
            sb.Replace("â€", "”");

            sb.Replace("â‚¬", "€");
            sb.Replace("Â§", "§");            

            sb.Replace("Ã·", "÷");
            sb.Replace("Ã—", "×");
            sb.Replace("Å‚", "ł");
            sb.Replace("Å", "Ł");            
            sb.Replace("ÃŸ", "ß");
            sb.Replace("Â¤", "¤");

            sb.Replace("Â ", " ");           

            


            //1 ' 2 " 3 ` 4 „ 5 ”
            //0 § 1' 2" 3+ 4! 5% 6/ 7= 8( 9)
            //[]{}&@€

            //1 ' 2 &quot; 3 ` 4 â€ž 5 â€
            //0 Â§ 1' 2&quot; 3+ 4! 5% 6/ 7= 8( 9)
            //[]{}&amp;@â‚¬

            //÷×łŁ$ß¤
            //,.- norm
            //;>* altgr
            //?:_ shift


            //Ã·Ã—Å‚Å$ÃŸÂ¤
            //,.- norm
            //;&gt;* altgr
            //?:_ shift



            //÷
            //×
            //ł
            //Ł
            //$
            //ß
            //¤
            //#
            //&
            //@
            ///
            //*
            //-
            //+
            //,
            //đ
            //Đ

            //Ã·
            //Ã—
            //Å‚
            //Å
            //$
            //ÃŸ
            //Â¤
            //#
            //&amp;
            //@
            ///
            //*
            //-
            //+
            //,
            //Ä‘
            //Ä


            return sb.ToString();
        }

        //StringBuilder sb = new StringBuilder(Regex.Replace(input.ToUpper(), "((?<=[^SD])Z(?=[^S]))", "z "));
        //sb.Replace("DZS", "dZ");
        //sb.Replace("CS", "tS ");
        //sb.Replace("DZ", "dz ");
        //sb.Replace("GY", "d' ");
        //sb.Replace("LY", "j ");
        //sb.Replace("J", "j ");
        //sb.Replace("NY", "J ");
        //sb.Replace("SZ", "s ");
        //sb.Replace("TY", "t' ");
        //sb.Replace("ZS", "Z ");
        //sb.Replace("A", "A ");
        //sb.Replace("Á", "a: ");
        //sb.Replace("B", "b ");
        //sb.Replace("C", "ts ");
        //sb.Replace("D", "d ");
        //sb.Replace("E", "E ");
        //sb.Replace("É", "e: ");
        //sb.Replace("F", "f ");
        //sb.Replace("G", "g ");
        //sb.Replace("H", "h ");
        //sb.Replace("I", "i ");
        //sb.Replace("Í", "i: ");
        //sb.Replace("K", "k ");
        //sb.Replace("L", "l ");
        //sb.Replace("M", "m ");
        //sb.Replace("N", "n ");
        //sb.Replace("O", "o ");
        //sb.Replace("Ó", "o: ");
        //sb.Replace("Ö", "2 ");
        //sb.Replace("Ő", "2: ");
        //sb.Replace("P", "p ");
        //sb.Replace("Q", "k v ");
        //sb.Replace("R", "r ");
        //sb.Replace("S", "S ");
        //sb.Replace("T", "t ");
        //sb.Replace("U", "u ");
        //sb.Replace("Ú", "u: ");
        //sb.Replace("Ü", "y ");
        //sb.Replace("Ű", "y: ");
        //sb.Replace("V", "v ");
        //sb.Replace("W", "v ");
        //sb.Replace("X", "k s ");
        //sb.Replace("Y", "i ");



        void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("ANSI"))
            {
                encoding = "ANSI";
            }
            else
            {
                if (comboBox1.Text.Equals("ASCII"))
                {
                    encoding = "ASCII";
                }
                else
                {
                    encoding = "UTF-8";
                }
            }
        }


        void Button2Click(object sender, EventArgs e)
        {
            list_items.Items.Clear();
        }

        void Button3Click(object sender, EventArgs e)
        {
            list_repaired.Items.Clear();
        }

        void Label2Click(object sender, EventArgs e)
        {

        }

        void Button4Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFileDialog1.FileName);

                foreach (object item in list_repaired.Items)

                    sw.WriteLine(item.ToString());

                sw.Close();
            }
        }

        void Button5Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void Chb_onlyphonemeCheckedChanged(object sender, EventArgs e)
        {
            if (chb_onlyphoneme.Checked)
            {
                chb_upper.Checked = false;
            }
            else
            {
                chb_upper.Checked = true;
            }
        }

        void Button6Click(object sender, EventArgs e)
        {
            if (combo_sampatype.Text == "BROKEN-UTF8")
            {
                tb_wordconverted.Text = RepairBrokenUtf(tb_word.Text);
            }
        }

        void Tb_wordTextChanged(object sender, EventArgs e)
        {
            Button6Click(sender, e);
        }

        private void chb_upper_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
