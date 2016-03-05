// MasmEditor
// 2010.
// 
// This program is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License V3.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License Version 3 for more details.
//  

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text;

using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Text.RegularExpressions;

namespace MasmIDE
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {

        StreamReader _textStreamReader;
        Assembly _assembly;
        string def_asm;
        static string verzio = " v1.0 RC3";
        List<int> errors = new List<int>();
        //int err = 0;  // hibás sorok sorszáma
        Color error_line_color = Color.Yellow;

        public MainForm()
        {
            InitializeComponent();

            try
            {
                _assembly = Assembly.GetExecutingAssembly();
                _textStreamReader = new StreamReader(_assembly.GetManifestResourceStream("MasmIDE.Text1.txt"));
                def_asm = _textStreamReader.ReadToEnd();
            }
            catch (Exception ex)
            {
                tb_log.Text = "\r\n\n" + DateTime.Now + ": " + ex.Message + tb_log.Text;
                MessageBox.Show("A Text1.txt (Névjegy) nem található.");
            }
        }


        public static void EncodeWindowsAnsiDefaultToUTF8(string filepath)
        {
            string encoded_filepath = filepath + "_utf8.txt";
            FileStream fs = File.OpenRead(filepath);
            byte[] bytes = new byte[fs.Length];
            fs.Read(bytes, 0, (int)fs.Length);
            fs.Close();

            byte[] decoded = Encoding.Convert(Encoding.Default, Encoding.UTF8, bytes, 0, bytes.Length);

            FileStream fw = File.OpenWrite(encoded_filepath);
            fw.Write(decoded, 0, (int)decoded.Length);
            fw.Close();
        }

        public static void EncodeASCIIToUTF8(string filepath)
        {
            string encoded_filepath = filepath + "_utf8.txt";

            TextReader EncodeQuery = new StreamReader(filepath);

            FileStream fs = File.OpenRead(filepath);
            byte[] bytes = new byte[fs.Length];
            fs.Read(bytes, 0, (int)fs.Length);
            fs.Close();

            byte[] decoded = Encoding.Convert(Encoding.ASCII, Encoding.UTF8, bytes, 0, bytes.Length);

            FileStream fw = File.OpenWrite(encoded_filepath);
            fw.Write(decoded, 0, (int)decoded.Length);
            fw.Close();

        }

        void Btn_newClick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Új fájl";
            status_errorlines.Text = "";
            syntaxRichTextBox1.Text = "";
            syntaxRichTextBox1.Text = def_asm;
            syntaxRichTextBox1.ProcessAllLines();
        }

        void Btn_loadClick(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    status_errorlines.Text = "A forrásfájl színezéséhez használd a helyi menü Formázás parancsát.";

                    EncodeWindowsAnsiDefaultToUTF8(openFileDialog1.FileName);  // ANSI vagy ASCII dekódolás
                    //EncodeASCIIToUTF8(openFileDialog1.FileName);

                    toolStripStatusLabel1.Text = openFileDialog1.FileName;

                    TextReader tr;

                    if (File.Exists(openFileDialog1.FileName + "_utf8.txt"))
                    {
                        tr = new StreamReader(openFileDialog1.FileName + "_utf8.txt");
                    }
                    else
                    {
                        tr = new StreamReader(openFileDialog1.FileName);
                    }

                    syntaxRichTextBox1.Text = tr.ReadToEnd();

                    tr.Close();
                    File.Delete(openFileDialog1.FileName + "_utf8.txt");
                    //saveFileDialog1.FileName=openFileDialog1.FileName.TrimEnd('\\');
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    tb_log.Text = "\r\n\n" + DateTime.Now + ": " + ex.Message + tb_log.Text;
                }

            }

        }


        void Btn_saveClick(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    TextWriter tw = new StreamWriter(saveFileDialog1.FileName);
                    tw.WriteLine(syntaxRichTextBox1.Text);
                    tw.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    tb_log.Text = "\r\n\n" + DateTime.Now + ": " + ex.Message + tb_log.Text;
                }

                toolStripStatusLabel1.Text = saveFileDialog1.FileName + " - mentve.";
            }
        }

        void Btn_runClick(object sender, EventArgs e)
        {
            syntaxRichTextBox1.SelectAll();
            syntaxRichTextBox1.SelectionBackColor = SystemColors.Window;
            syntaxRichTextBox1.DeselectAll();

            try
            {
                File.Delete(Application.StartupPath + "\\out");
            }
            catch (Exception ex)
            {
                tb_log.Text = "\r\n\n" + DateTime.Now + ": " + ex.Message + tb_log.Text;
            }

            syntaxRichTextBox1.Enabled = false;
            btn_run.Enabled = false;
            btn_load.Enabled = false;
            btn_save.Enabled = false;
            btn_new.Enabled = false;
            btn_cmd.Enabled = false;

            status_led.BackColor = Color.Green;


            try
            {
                TextWriter tw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "temp.asm");
                tw.WriteLine(syntaxRichTextBox1.Text);
                tw.Close();


                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.CreateNoWindow = false;
                startInfo.UseShellExecute = false;
                startInfo.FileName = AppDomain.CurrentDomain.BaseDirectory + "fordit.bat";
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory; // Fontos a munkamappa beállítása!!!
                //startInfo.Arguments = "";  // a BATCH fájl itt paraméterezhető

                try
                {
                    // Start the process with the info we specified.
                    // Call WaitForExit and then the using statement will close.
                    using (Process exeProcess = Process.Start(startInfo))
                    {
                        exeProcess.WaitForExit();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    tb_log.Text = "\r\n\n" + DateTime.Now + ": " + ex.Message + tb_log.Text;
                    status_led.BackColor = Color.Red;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                tb_log.Text = "\r\n\n" + DateTime.Now + ": " + ex.Message + tb_log.Text;
                status_led.BackColor = Color.Red;
            }

            btn_run.Enabled = true;
            syntaxRichTextBox1.Enabled = true;
            btn_load.Enabled = true;
            btn_save.Enabled = true;
            btn_new.Enabled = true;
            btn_cmd.Enabled = true;

            try
            {

                TextReader tr;
                tr = new StreamReader(Application.StartupPath + "\\out");
                tb_errmsg.Text = tr.ReadToEnd();
                tr.Close();
            }
            catch (Exception ex)
            {
                status_errorlines.Text = ex.Message;
                tb_log.Text = "\r\n\n" + DateTime.Now + ": " + ex.Message + tb_log.Text;
                status_led.BackColor = Color.Red;
                return;
            }


            //Regex out_msg;
            HighlightErrors(SystemColors.Window);
            syntaxRichTextBox1.BackColor = SystemColors.Window;
            errors.Clear();

            int err_line_num_start_index = 0;
            int err_line_num_end_index = 0;
            int err_line = 0;
            int length = 0;
            string line = "";
            status_errorlines.Text = "";
            bool errordetected = false;

            // Hibás sorok számának kiszedése a MASM.EXE kimenetéből

            foreach (string curr_line in tb_errmsg.Lines)
            {
                if (Regex.IsMatch(curr_line, "temp.asm"))
                {
                    errordetected = true;

                    err_line_num_start_index = curr_line.IndexOf('(');
                    err_line_num_end_index = curr_line.IndexOf(')');
                    length = err_line_num_end_index - err_line_num_start_index;
                    err_line = Convert.ToInt32(curr_line.Substring(err_line_num_start_index + 1, length - 1));
                    line = curr_line;
                    errors.Add(err_line);
                    status_errorlines.Text += err_line + " ";
                }
            }

            if (errordetected)
            {
                string temp = status_errorlines.Text;
                status_errorlines.Text = "Hibák: " + temp;
                status_led.BackColor = Color.Red;
            }

            //HIBÁS sorok színezése
            HighlightErrors(error_line_color);
        }

        private void HighlightErrors(Color backcolor)
        {

            foreach (int err in errors)
            {
                try
                {
                    syntaxRichTextBox1.SelectionStart = syntaxRichTextBox1.GetFirstCharIndexFromLine(err - 1);  //-1
                    syntaxRichTextBox1.SelectionLength = syntaxRichTextBox1.Lines[err - 1].Length;  //-1
                    syntaxRichTextBox1.SelectionBackColor = backcolor;
                }
                catch (Exception ex)
                {
                    tb_log.Text = "\r\n\n" + DateTime.Now + ": " + ex.Message + tb_log.Text;
                }
            }
        }

        void MainFormLoad(object sender, EventArgs e)
        {
            // Assembly parancsok
            syntaxRichTextBox1.Settings.Keywords.Add("add");
            syntaxRichTextBox1.Settings.Keywords.Add("mov");
            syntaxRichTextBox1.Settings.Keywords.Add("cmp");
            syntaxRichTextBox1.Settings.Keywords.Add("sub");
            syntaxRichTextBox1.Settings.Keywords.Add("mul");

            syntaxRichTextBox1.Settings.Keywords.Add("shr");
            syntaxRichTextBox1.Settings.Keywords.Add("shl");
            syntaxRichTextBox1.Settings.Keywords.Add("ror");
            syntaxRichTextBox1.Settings.Keywords.Add("rol");

            syntaxRichTextBox1.Settings.Keywords.Add("lea");
            syntaxRichTextBox1.Settings.Keywords.Add("int");

            syntaxRichTextBox1.Settings.Keywords.Add("push");
            syntaxRichTextBox1.Settings.Keywords.Add("pop");

            syntaxRichTextBox1.Settings.Keywords.Add("xor");
            syntaxRichTextBox1.Settings.Keywords.Add("and");
            syntaxRichTextBox1.Settings.Keywords.Add("or");

            syntaxRichTextBox1.Settings.Keywords.Add("loop");

            syntaxRichTextBox1.Settings.Keywords.Add("dec");
            syntaxRichTextBox1.Settings.Keywords.Add("inc");
            syntaxRichTextBox1.Settings.Keywords.Add("ret");
            syntaxRichTextBox1.Settings.Keywords.Add("call");

            syntaxRichTextBox1.Settings.Keywords.Add("jmp");

            syntaxRichTextBox1.Settings.Keywords.Add("jz");
            syntaxRichTextBox1.Settings.Keywords.Add("jnz");

            syntaxRichTextBox1.Settings.Keywords.Add("jc");
            syntaxRichTextBox1.Settings.Keywords.Add("jnc");

            syntaxRichTextBox1.Settings.Keywords.Add("js");
            syntaxRichTextBox1.Settings.Keywords.Add("jns");

            syntaxRichTextBox1.Settings.Keywords.Add("jo");
            syntaxRichTextBox1.Settings.Keywords.Add("jno");



            // Set the comment identifier. For Lua this is two minus-signs after each other (--). 
            // For C++ we would set this property to "//".
            syntaxRichTextBox1.Settings.Comment = ";";

            // Set the colors that will be used.
            syntaxRichTextBox1.Settings.KeywordColor = Color.DodgerBlue;
            syntaxRichTextBox1.Settings.CommentColor = Color.ForestGreen;
            syntaxRichTextBox1.Settings.StringColor = Color.Gray;
            syntaxRichTextBox1.Settings.IntegerColor = Color.DarkOrange;

            syntaxRichTextBox1.Settings.RegisterColor = Color.Red;
            syntaxRichTextBox1.Settings.SubRegisterColor = Color.Purple;
            syntaxRichTextBox1.Settings.HexColor = Color.Blue;

            // Process selection
            syntaxRichTextBox1.Settings.EnableStrings = false;
            syntaxRichTextBox1.Settings.EnableIntegers = true;
            syntaxRichTextBox1.Settings.EnableHexNumbers = true;
            syntaxRichTextBox1.Settings.EnableRegisters = true;
            syntaxRichTextBox1.Settings.EnableSubRegisters = true;

            // Let's make the settings we just set valid by compiling
            // the keywords to a regular expression.
            syntaxRichTextBox1.CompileKeywords();


            // Load a file and update the syntax highlighting.
            //syntaxRichTextBox1.LoadFile("../script.lua", RichTextBoxStreamType.PlainText);
            //syntaxRichTextBox1.ProcessAllLines();

            syntaxRichTextBox1.WordWrap = false; // Sortörés letiltása, egyébként hibás működés!

            lab_version.Text += verzio;
            toolStripStatusLabel1.Text = "MasmEditor" + verzio;
        }


        void BackgroundWorker1DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            //syntaxRichTextBox1.ProcessAllLines();
        }


        private void betűtípusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            syntaxRichTextBox1.Font = fontDialog1.Font;            
        }

        private void formázásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string temp = btn_proc_syntax.Text;
            //btn_proc_syntax.Text = "Folyamatban...";

            if (syntaxRichTextBox1.Lines.Length > 30)
            {

                if (MessageBox.Show("Ez a művelet sokáig tarthat. (kb. " +
                    Convert.ToInt32(syntaxRichTextBox1.Lines.Length / 12).ToString() +
                    "-" + Convert.ToInt32(syntaxRichTextBox1.Lines.Length / 8).ToString() +
                    "mp)\nFolytatod?", "Megerősítés kérése", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) == DialogResult.OK)
                {
                    syntaxRichTextBox1.ProcessAllLines();
                }
            }
            else
            {
                syntaxRichTextBox1.ProcessAllLines();
            }

            //backgroundWorker1.RunWorkerAsync();
            //btn_proc_syntax.Text = temp;
        }

        private void btn_cmd_Click(object sender, EventArgs e)
        {
            syntaxRichTextBox1.Enabled = false;
            btn_run.Enabled = false;
            btn_load.Enabled = false;
            btn_save.Enabled = false;
            btn_new.Enabled = false;
            btn_cmd.Enabled = false;

            try
            {
                TextWriter tw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "temp.asm");
                tw.WriteLine(syntaxRichTextBox1.Text);
                tw.Close();


                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.CreateNoWindow = false;
                startInfo.UseShellExecute = false;
                startInfo.FileName = "cmd";
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory; // Fontos a munkamappa beállítása!!!
                //startInfo.Arguments = "";  // a BATCH fájl itt paraméterezhető

                try
                {
                    // Start the process with the info we specified.
                    // Call WaitForExit and then the using statement will close.
                    using (Process exeProcess = Process.Start(startInfo))
                    {
                        exeProcess.WaitForExit();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    tb_log.Text = "\r\n\n" + DateTime.Now + ": " + ex.Message + tb_log.Text;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                tb_log.Text = "\r\n\n" + DateTime.Now + ": " + ex.Message + tb_log.Text;
            }

            btn_run.Enabled = true;
            syntaxRichTextBox1.Enabled = true;
            btn_load.Enabled = true;
            btn_save.Enabled = true;
            btn_new.Enabled = true;
            btn_cmd.Enabled = true;
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DisplayLineNumber()
        {
            int line = syntaxRichTextBox1.GetLineFromCharIndex(syntaxRichTextBox1.SelectionStart);
            int column = syntaxRichTextBox1.SelectionStart - syntaxRichTextBox1.GetFirstCharIndexFromLine(line);
            line++;  // hogy ne nullától induljon a számozás
            column++;
            status_col_row.Text = line + ":" + column;

        }

        private void syntaxRichTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            DisplayLineNumber();
            //syntaxRichTextBox1.BackColor = SystemColors.Window;
        }

        private void másolásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            syntaxRichTextBox1.Copy();
        }

        private void kivágásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            syntaxRichTextBox1.Cut();
        }

        private void beillesztésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            syntaxRichTextBox1.Paste();
        }

        private void törlésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            syntaxRichTextBox1.Clear();
        }

        private void visszavonásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            syntaxRichTextBox1.Undo();
        }

        private void ismétToolStripMenuItem_Click(object sender, EventArgs e)
        {
            syntaxRichTextBox1.Redo();
        }
    }
}
