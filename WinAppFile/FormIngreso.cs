using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppFile
{
    public partial class FormIngreso : Form
    {
        public FormIngreso()
        {
            InitializeComponent();
        }
        string path = Application.StartupPath;
        ClData student = new ClData();

        private void BtnSave_Click(object sender, EventArgs e)
        {
            dataSet11.ReadXml(path + "\\data.xml");
            object[] data = new object[4];
            data[0] = student.Code;
            data[1] = student.Name;
            data[2] = student.LastName;
            data[3] = student.Age;
            dataSet11.TblData.Rows.Add(data);
            dataSet11.WriteXml(path + "\\data.xml");
        }

        private void FormIngreso_Load(object sender, EventArgs e)
        {
        }

        private void TxtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    string code = TxtCode.Text;
                    if(code == "")
                    {
                        MessageBox.Show("Ingrese el código", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        student.SetCode(code);
                        TxtName.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Ingrese el código", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TxtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    string name = TxtName.Text;
                    if (name == "")
                    {
                        MessageBox.Show("Ingrese el nombre", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        student.SetName(name);
                        TxtLastName.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Ingrese el nombre", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TxtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    string lastName = TxtLastName.Text;
                    if (lastName == "")
                    {
                        MessageBox.Show("Ingrese el apellido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        student.SetLastName(lastName);
                    }
                }
                catch
                {
                    MessageBox.Show("Ingrese el apellido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
