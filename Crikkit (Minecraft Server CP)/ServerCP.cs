﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crikkit__Minecraft_Server_CP_
{
    public partial class ServerCP : Form
    {
        private Server Server;

        public ServerCP(Server server)
        {
            InitializeComponent();
            Server = server;
            Server.ControlPanel = this;

            ServerBackgroundWorker.DoWork += (sender, e) =>
                Server.Run(); 
        }

        private void imageButton_NewServer_Click(object sender, EventArgs e)
        {
            if (!ServerBackgroundWorker.IsBusy)
                ServerBackgroundWorker.RunWorkerAsync();
        }

        private void ServerCP_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Server.ControlPanel == this)
                Server.ControlPanel = null;
        }

        private void textBox_ConsoleInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextBox input = (TextBox)sender;
                if (Server != null && Server.Process != null)
                    SendCommand(input.Text);
                input.Text = "";
            }
        }

        private void SendCommand(string cmd)
        {
            Server.Process.StandardInput.WriteLine(cmd);
            Console.WriteLine("Input: " + cmd);
        }

        public void ProcessReceived(string data)
        {
            if (data == null)
                return;
            data = data.ToLower();
            try
            {
                Regex TestRegex = new Regex(@"[0-9\-]{10}\ ([0-9:]{8})\ \[INFO\]\ ([^\ ]*)\ (lost\ connection)");
                if (TestRegex.IsMatch(data))
                {
                    //string[] Matches = TestRegex.Split(Data);
                }
            }
            catch
            {
            }
        }
    }
}
