﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aol.Forms
{
    public partial class dial_up : Form
    {
        #region win95_theme
        int _ = 2;

        Rectangle Top { get { return new Rectangle(0, 0, this.ClientSize.Width, _); } }
        Rectangle Left { get { return new Rectangle(0, 0, _, this.ClientSize.Height); } }
        Rectangle Bottom { get { return new Rectangle(0, this.ClientSize.Height - _, this.ClientSize.Width, _); } }
        Rectangle Right { get { return new Rectangle(this.ClientSize.Width - _, 0, _, this.ClientSize.Height); } }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) return;
            e.Graphics.FillRectangle(Brushes.Gray, Top);
            e.Graphics.FillRectangle(Brushes.Gray, Left);
            e.Graphics.FillRectangle(Brushes.Gray, Right);
            e.Graphics.FillRectangle(Brushes.Gray, Bottom);
        }
        #endregion

        #region winform_functions
        public dial_up()
        {
            InitializeComponent();
            TopLevel = true;
            Focus();
            if (accForm.tmpLocation == "Dial-Up")
                verbage = "Dial-Up";
        }

        string verbage = "TCP/IP";
        int i = 0;

        async Task dialUp()
        {
            timer1.Stop();
            verbage = "Dial-Up";
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream = Properties.Resources.dial_up_modem;
                player.Play();
            }
            await Task.Delay(25000);
            timer1.Start();
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            switch (i)
            {
                case 0: // pretend to initialize the modem
                    statusLabel.Text = "Step 1: Looking for AOL via " + verbage + "...";
                    break;
                case 1: // pretend to connect to server
                    pictureBox1.Visible = Visible;
                    statusLabel.Text = "Step 2: Connecting using " + verbage + " ...";
                    if (accForm.tmpLocation == "Dial-Up")
                        await dialUp();
                    break;
                case 2: // pretend to check password
                    pictureBox2.Visible = Visible;
                    statusLabel.Text = "Step 3: Checking password ...";
                    break;
                case 3: // show final running man
                    pictureBox3.Visible = Visible;
                    break;
                case 4: // play welcome audio msg and close form
                    if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) break;
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                    player.Stream = Properties.Resources.Welcome;
                    player.Play();
                    Close();
                    break;
                default:
                    break;
            }
            i++;
        }
        #endregion
    }
}
