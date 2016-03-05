using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.IO;

namespace PingStat
{
    public partial class Form1 : Form
    {
        //---------------------------------------
        string destination = "hu.wikipedia.org";
        //---------------------------------------

        int ping_time_ms = 0;
        List<int> pinglist = new List<int>();
        int iter = 1;
        bool ping_failure = false;


        public Form1()
        {
            InitializeComponent();

        }

        private void timer_ping_Tick(object sender, EventArgs e)
        {
            pingSite(destination);
        }

        void pingSite(string webpage)
        {
            System.Net.NetworkInformation.Ping pinger = new System.Net.NetworkInformation.Ping();
            ping_time_ms = 0;

            try
            {
                PingReply pingreply = pinger.Send(webpage);

                string pinganswer = pingreply.Address + " - " + pingreply.Status.ToString() + " - " + pingreply.RoundtripTime.ToString() + "ms";


                ping_time_ms = (int)pingreply.RoundtripTime;

                if (pinglist.Count > 30)
                {
                    pinglist.Clear();
                }

                pinglist.Add(ping_time_ms);

                drawping();

                toolStripStatusLabel1.Text = pinganswer + " - "
                    + DateTime.Now.ToString();

                if (pingreply.Status != IPStatus.Success)
                {
                    textBox1.Text += DateTime.Now.ToString()
                        + "\r\n";
                    ping_failure = true; // log fájl mentése

                    if (cb_pingfail_sound.Checked)
                    {
                        Console.Beep(2000, 500);
                    }
                }

            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = ex.Message;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            WindowState = FormWindowState.Minimized;
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (ping_failure)
            {
                string timestamp = DateTime.Now.ToString().Replace(':', '-').Replace(".", "-");
                TextWriter writer = new StreamWriter(Application.StartupPath + @"\"
                    + timestamp + ".log");

                writer.WriteLine(textBox1.Text);
                writer.Close();
            }


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            timer_ping.Interval = (int)numericUpDown1.Value * 1000;
        }


        void drawping()
        {
            panel1.Invalidate();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "PingNET - " + destination;
            textBox_dest.Text = destination;
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            Pen pen1 = new Pen(Color.Green, 4f);
            Pen pen2 = new Pen(Color.Orange, 4f);
            Pen pen3 = new Pen(Color.Red, 4f);

            Pen pen_error = new Pen(Color.Black, 4f);

            //g.DrawLine(pen1, 0, 0, this.Width, this.Height);
            SolidBrush brushOne = new SolidBrush(Color.Green);


            foreach (int pingtime in pinglist)
            {
                if (pingtime < 36)
                {
                    g.DrawLine(pen1, 0, iter * 6, (pingtime - 10) * 3, iter * 6);
                }

                if (pingtime >= 36 && pingtime < 60)
                {
                    g.DrawLine(pen2, 0, iter * 6, (pingtime - 10) * 3, iter * 6);
                }

                if (pingtime >= 60)
                {
                    g.DrawLine(pen3, 0, iter * 6, (pingtime - 10) * 3, iter * 6);
                }

                if (pingtime == 0)
                {
                    g.DrawLine(pen_error, 0, iter * 6, 300, iter * 6);
                }

                iter++;
            }
            iter = 1;
        }

        private void btn_dest_ok_Click(object sender, EventArgs e)
        {
            destination = textBox_dest.Text;
            this.Text = "PingNET - " + destination;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (timer_ping.Enabled)
            {
                timer_ping.Enabled = false;
                btn_stop_start.Text = "START";
                notifyIcon1.Text = "PingNET leállítva";
            }
            else
            {
                timer_ping.Enabled = true;
                btn_stop_start.Text = "STOP";
                notifyIcon1.Text = "PingNET aktív";
            }
        }



    }
}
