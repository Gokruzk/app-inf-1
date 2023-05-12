using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppVotos
{
    public partial class Form1 : Form
    {
        string path = Application.StartupPath;
        string file1 = "1.png";
        string file2 = "2.png";
        string file3 = "3.png";
        public Form1()
        {
            InitializeComponent();
            string path1 = Path.Combine(path, file1);
            string path2 = Path.Combine(path, file2);
            string path3 = Path.Combine(path, file3);
            PbxC1.Image = Image.FromFile(path1);
            PbxC2.Image = Image.FromFile(path2);
            PbxC3.Image = Image.FromFile(path3);
            LblVot1.Text = "Votos: 0";
            LblVot2.Text = "Votos: 0";
            LblVot3.Text = "Votos: 0";
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            int[] array = new int[3];
            int num1 = 0, num2 = 0, num3 = 0;
            int winner = 0;
            string winnerName = "";

            Random rnd = new Random();
            num1 = rnd.Next(1, 1000);
            num2 = rnd.Next(1, 1000);
            num3 = rnd.Next(1, 1000);
            array[0] = num1;
            array[1] = num2;
            array[2] = num3;

            LblVot1.Text = "Votos: " + num1;
            LblVot2.Text = "Votos: " + num2;
            LblVot3.Text = "Votos: " + num3;

            int may = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= may)
                {
                    may = array[i];
                    winner = i + 1;
                }
            }
            switch (winner)
            {
                case 1: winnerName = "Pepito"; break;
                case 2: winnerName = "Jaimito"; break;
                case 3: winnerName = "Clarita"; break;
            }
            MessageBox.Show("El candidato ganador es: " + winnerName, "GANADOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
