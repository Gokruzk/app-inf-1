using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CEntidades;
using CLogica;

namespace CPresentacion
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades objEnt = new Entidades();
                objEnt.NombreE = TxtName.Text;
                objEnt.ApellidoE = TxtLastName.Text;
                COperaciones objOper = new COperaciones();
                objOper.SetData(objEnt);
                MessageBox.Show("Estudiante registrado", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("No se pudo registrar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                TxtLastName.Focus();
            }
        }

        private void FrmIngresar_Load(object sender, EventArgs e)
        {
            
        }

        private void TxtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                BtnSave_Click(sender, e);
            }
        }
    }
}
