using SimpleTCP;
using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string host = "127.0.0.1";
        int port = 6400;
        SimpleTcpServer server;

        private void Form1_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
            MessageBox.Show("Server started");
            server.Start(port);
        }
        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            TxtStatus.Invoke((MethodInvoker)delegate ()
            {
                TxtStatus.Text += e.MessageString + "\r\n";
                e.ReplyLine(string.Format("You said: " + e.MessageString));
            });
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            if(server.IsStarted)
            {
                server.Stop();
            }
        }
    }
}
