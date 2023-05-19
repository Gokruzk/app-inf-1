using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace WinAppCliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp );
            IPEndPoint connection = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 6400);

            client.Connect(connection);
            byte[] vecenviar = new byte[80];
            string data = "";
            MessageBox.Show("...sending information");
            vecenviar = Encoding.Default.GetBytes(data);
            client.Send(vecenviar);
        }
    }
}
