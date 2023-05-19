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
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinAppFile
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        string path = Application.StartupPath;

        private void BtnStart_Click(object sender, EventArgs e)
        {
            dataSet11.ReadXml(path + "\\credentials.xml");

            DataRow[] data;
            data = dataSet11.TblUsers.Select("user='" + TxtUser.Text + "'");
            if (data.Length > 0)
            {
                if (data[0]["user"].ToString() == TxtUser.Text)
                {
                    if (TxtUser.Text == "admin")
                    {
                        if (data[0]["psw"].ToString() == TxtPsw.Text)
                        {
                            Form1 obj = new Form1();
                            obj.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Contraseña incorrecta", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if(TxtUser.Text == "nigell")
                    {
                        if (data[0]["psw"].ToString() == TxtPsw.Text)
                        {
                            FrmBuscar obj = new FrmBuscar();
                            obj.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Contraseña incorrecta", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encuentra el usuario", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No se encuentra el usuario", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No se encuentra el usuario", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido", "Hola", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                TxtPsw.Focus();
            }
        }
    }
}
