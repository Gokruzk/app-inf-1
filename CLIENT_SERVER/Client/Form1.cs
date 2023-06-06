using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string host = "127.0.0.1";
        int port = 6400;
        SimpleTcpClient client;

        private void BtnConn_Click(object sender, EventArgs e)
        {
            BtnConn.Enabled = false;
            client.Connect(host, port);
            TxtMessage.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += Client_DataReceived;
        }

        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            TxtStatus.Invoke((MethodInvoker)delegate ()
            {
                TxtStatus.Text = e.MessageString;
            });
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            string message = TxtMessage.Text;
            client.WriteLineAndGetReply(message + "\n", TimeSpan.FromSeconds(3));
        }
    }
}
