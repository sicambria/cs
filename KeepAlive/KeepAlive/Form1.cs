using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace KeepAlive
{
    public partial class Form1 : Form
    {
        int refresh_time;

        public Form1()
        {
            InitializeComponent();
        }

        void KeepAlive(string drive)
        {
            try
            {
                TextWriter writer = new StreamWriter(drive + "acc.txt");
                writer.WriteLine(DateTime.Now.ToString());
                writer.Close();
            }
            catch (IOException) { label1.Text = "Hozzáférés megtagadva: " + drive; }
            catch (Exception) { label1.Text = "A meghajtó: " + drive + " nem írható."; }
        }

        void GetDiskLabel(string drive)
        {
            try
            {
                DriveInfo drivelabel = new DriveInfo(drive);
                if (drivelabel.VolumeLabel != "")
                {
                    label1.Text = drivelabel.VolumeLabel;
                }
                else
                {
                    label1.Text = "Nincs címke";
                }
            }
            catch (DriveNotFoundException) { label1.Text = "Meghajtó nem található"; }
            catch (Exception) { label1.Text = "Nincs címke"; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (DriveInfo drive in System.IO.DriveInfo.GetDrives())
                {
                    combo_drives.Items.Add(drive.ToString());
                }

                TextReader reader = new StreamReader(Application.StartupPath + @"\drives.ini");
                while (reader.Peek() > 0)
                {
                    list_drives.Items.Add(reader.ReadLine());
                }
                reader.Close();
            }
            catch (Exception) { }

        }

        private void combo_drives_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_drives.SelectedItem != null)
            {
                list_drives.Items.Add(combo_drives.SelectedItem.ToString());
                GetDiskLabel(combo_drives.SelectedItem.ToString().Substring(0, 1));
            }

            //try
            //{
            //    DriveInfo drivelabel = new DriveInfo(combo_drives.SelectedItem.ToString().Substring(0, 1));
            //    label1.Text = drivelabel.VolumeLabel;
            //}
            //catch (Exception) { }
        }

        private void combo_time_SelectedIndexChanged(object sender, EventArgs e)
        {
            progressbar.Value = 0;
            refresh_time = int.Parse(combo_time.SelectedItem.ToString());
            timer_KeepAlive.Interval = refresh_time * 1000;
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            list_drives.Enabled = true;
            btn_clear.Enabled = true;
            btn_del.Enabled = true;
            btn_start.Enabled = true;
            combo_drives.Enabled = true;
            btn_stop.Enabled = false;

            timer_KeepAlive.Enabled = false;
            timer_ProgressbarSync.Enabled = false;
            progressbar.Value = 0;
            statuslabel.Text = "Időzítő leállítva.";
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (list_drives.Items.Count > 0)
            {
                list_drives.Enabled = false;
                btn_clear.Enabled = false;
                btn_del.Enabled = false;
                btn_start.Enabled = false;
                combo_drives.Enabled = false;
                btn_stop.Enabled = true;

                timer_KeepAlive.Enabled = true;
                timer_ProgressbarSync.Enabled = true;
                progressbar.Value = 0;
                statuslabel.Text = "Időzítő aktív.";
               // label1.Text = "";
            }
            else
            {
                MessageBox.Show("Nincs meghajtó kiválasztva!");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            TextWriter writer = new StreamWriter(Application.StartupPath + @"\drives.ini");
            for (int i = 0; i < list_drives.Items.Count; i++)
            {
                writer.WriteLine(list_drives.Items[i].ToString());
            }
            writer.Close();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            try
            {
                if (list_drives.SelectedItem != null)
                {
                    list_drives.Items.Remove(list_drives.SelectedItem);
                }

            }
            catch (Exception) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            list_drives.Items.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < list_drives.Items.Count; i++)
            {
                progressbar.Value = 0;
                KeepAlive(list_drives.Items[i].ToString());
            }

            //foreach (object items in list_drives.Items.ToString())
            //{
            //    progressbar.Value = 0;
            //    KeepAlive(items.ToString());
            //}
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            switch (refresh_time)
            {
                case 10: progressbar.Maximum = 10;
                    break;
                case 30: progressbar.Maximum = 30;
                    break;
                case 60: progressbar.Maximum = 60;
                    break;
                case 120: progressbar.Maximum = 120;
                    break;
                case 240: progressbar.Maximum = 240;
                    break;
                case 480: progressbar.Maximum = 480;
                    break;
            }
            if (progressbar.Value != progressbar.Maximum)
            {
                progressbar.Value += 1;
            }
        }

        private void list_drives_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (list_drives.SelectedItem != null)
                {
                    GetDiskLabel(list_drives.SelectedItem.ToString());
                }
            }
            catch (Exception) { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Hide();
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

    }
}
