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
namespace WinAppServer

    //conectar 4 clientes locales
    //conectar 2 clientes mediante internet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Socket wait = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Socket connection;
            IPEndPoint address = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 6400);
            wait.Bind(address);
            wait.Listen(5);
            connection = wait.Accept();
            MessageBox.Show("Connected");
            byte[] vecrecibir = new byte[80];
            string data;
            int totalD = connection.Receive(vecrecibir, 0, vecrecibir.Length, 0);
            Array.Resize(ref vecrecibir, totalD);
            data = Encoding.Default.GetString(vecrecibir);
            listBox1.Items.Add(data);
        }
    }
}
