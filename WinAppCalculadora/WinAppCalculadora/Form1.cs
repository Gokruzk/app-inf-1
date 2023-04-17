using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblRespuesta.Text = "0";
            LblAux.Text = "0";
        }
        ClOperaciones ObjRes = new ClOperaciones(0, 0);
        double num1;
        double num2;
        double respuesta;
        bool res = true;
        int id, ip;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            try
            {
                txtbxNumero.Text += "0";
                if (ip == 4)
                {
                    num1 = double.Parse(LblAux.Text);
                    num2 = double.Parse(txtbxNumero.Text);
                    ObjRes.sets(num1, num2);
                    respuesta = ObjRes.Division();
                    txtbxNumero.Text = respuesta.ToString();
                    ip = 0;
                }
                if (ip == 5)
                {
                    num1 = double.Parse(LblAux.Text);
                    num2 = double.Parse(txtbxNumero.Text);
                    ObjRes.sets(num1, num2);
                    respuesta = ObjRes.Potencia();
                    txtbxNumero.Text = respuesta.ToString();
                    ip = 0;
                }
                if (ip == 6)
                {
                    num1 = double.Parse(txtbxNumero.Text);
                    ObjRes.set(num1);
                    txtbxNumero.Text = ObjRes.Raiz().ToString();
                    ip = 0;
                }
            }
            catch
            {
                MessageBox.Show("Ingrese número primero", "\t\t\tERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            try
            {
                txtbxNumero.Text += ",";
                res = false;
                if (res)
                    btnComa.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Ingrese número primero", "\t\t\tERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            try
            {
                txtbxNumero.Clear();
                btnComa.Enabled = true;
                lblRespuesta.Text = "0";
                LblAux.Text = "0";
                id = 0;
                num1 = 0;
                num2 = 0;
                respuesta = 0;
            }
            catch
            {
                MessageBox.Show("Ingrese número primero", "\t\t\tERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                txtbxNumero.Text += "1";
                if (ip == 4)
                {
                    num1 = double.Parse(LblAux.Text);
                    num2 = double.Parse(txtbxNumero.Text);
                    ObjRes.sets(num1, num2);
                    respuesta = ObjRes.Division();
                    txtbxNumero.Text = respuesta.ToString();
                    ip = 0;
                }
                //if (ip == 5)
                //{
                //    num1 = double.Parse(LblAux.Text);
                //    num2 = double.Parse(txtbxNumero.Text);
                //    ObjRes.sets(num1, num2);
                //    respuesta = ObjRes.Potencia();
                //    txtbxNumero.Text = respuesta.ToString();
                //    ip = 0;
                //}
                if (ip == 6)
                {
                    num1 = double.Parse(txtbxNumero.Text);
                    ObjRes.set(num1);
                    txtbxNumero.Text = ObjRes.Raiz().ToString();
                    ip = 0;
                }
            }
            catch
            {
                MessageBox.Show("Ingrese número primero", "\t\t\tERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            try
            {
                txtbxNumero.Text += "2";
                if (ip == 4)
                {
                    num1 = double.Parse(LblAux.Text);
                    num2 = double.Parse(txtbxNumero.Text);
                    ObjRes.sets(num1, num2);
                    respuesta = ObjRes.Division();
                    txtbxNumero.Text = respuesta.ToString();
                    ip = 0;
                }
                
                if (ip == 6)
                {
                    num1 = double.Parse(txtbxNumero.Text);
                    ObjRes.set(num1);
                    txtbxNumero.Text = ObjRes.Raiz().ToString();
                    ip = 0;
                }
            }
            catch
            {
                MessageBox.Show("Ingrese número primero", "\t\t\tERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            try
            {
                txtbxNumero.Text += "3";
                if (ip == 4)
                {
                    num1 = double.Parse(LblAux.Text);
                    num2 = double.Parse(txtbxNumero.Text);
                    ObjRes.sets(num1, num2);
                    respuesta = ObjRes.Division();
                    txtbxNumero.Text = respuesta.ToString();
                    ip = 0;
                }
                if (ip == 5)
                {
                    num1 = double.Parse(LblAux.Text);
                    num2 = double.Parse(txtbxNumero.Text);
                    ObjRes.sets(num1, num2);
                    respuesta = ObjRes.Potencia();
                    txtbxNumero.Text = respuesta.ToString();
                    ip = 0;
                }
                if (ip == 6)
                {
                    num1 = double.Parse(txtbxNumero.Text);
                    ObjRes.set(num1);
                    txtbxNumero.Text = ObjRes.Raiz().ToString();
                    ip = 0;
                }
            }
            catch
            {
                MessageBox.Show("Ingrese número primero", "\t\t\tERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            try
            {
                txtbxNumero.Text += "4";
                if (ip == 4)
                {
                    num1 = double.Parse(LblAux.Text);
                    num2 = double.Parse(txtbxNumero.Text);
                    ObjRes.sets(num1, num2);
                    respuesta = ObjRes.Division();
                    txtbxNumero.Text = respuesta.ToString();
                    ip = 0;
                }
                if (ip == 5)
                {
                    num1 = double.Parse(LblAux.Text);
                    num2 = double.Parse(txtbxNumero.Text);
                    ObjRes.sets(num1, num2);
                    respuesta = ObjRes.Potencia();
                    txtbxNumero.Text = respuesta.ToString();
                    ip = 0;
                }
                if (ip == 6)
                {
                    num1 = double.Parse(txtbxNumero.Text);
                    ObjRes.set(num1);
                    txtbxNumero.Text = ObjRes.Raiz().ToString();
                    ip = 0;
                }
            }
            catch
            {
                MessageBox.Show("Ingrese número primero", "\t\t\tERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            try
            {
                txtbxNumero.Text += "5";
                if (ip == 4)
                {
                    num1 = double.Parse(LblAux.Text);
                    num2 = double.Parse(txtbxNumero.Text);
                    ObjRes.sets(num1, num2);
                    respuesta = ObjRes.Division();
                    txtbxNumero.Text = respuesta.ToString();
                    ip = 0;
                }
                if (ip == 5)
                {
                    num1 = double.Parse(LblAux.Text);
                    num2 = double.Parse(txtbxNumero.Text);
                    ObjRes.sets(num1, num2);
                    respuesta = ObjRes.Potencia();
                    txtbxNumero.Text = respuesta.ToString();
                    ip = 0;
                }
                if (ip == 6)
                {
                    num1 = double.Parse(txtbxNumero.Text);
                    ObjRes.set(num1);
                    txtbxNumero.Text = ObjRes.Raiz().ToString();
                    ip = 0;
                }
            }
            catch
            {
                MessageBox.Show("Ingrese número primero", "\t\t\tERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            try
            {
                txtbxNumero.Text += "6";
                if (ip == 4)
                {
                    num1 = double.Parse(LblAux.Text);
                    num2 = double.Parse(txtbxNumero.Text);
                    ObjRes.sets(num1, num2);
                    respuesta = ObjRes.Division();
                    txtbxNumero.Text = respuesta.ToString();
                    ip = 0;
                }
                if (ip == 5)
                {
                    num1 = double.Parse(LblAux.Text);
                    num2 = double.Parse(txtbxNumero.Text);
                    ObjRes.sets(num1, num2);
                    respuesta = ObjRes.Potencia();
                    txtbxNumero.Text = respuesta.ToString();
                    ip = 0;
                }
                if (ip == 6)
                {
                    num1 = double.Parse(txtbxNumero.Text);
                    ObjRes.set(num1);
                    txtbxNumero.Text = ObjRes.Raiz().ToString();
                    ip = 0;
                }
            }
            catch
            {
                MessageBox.Show("Ingrese número primero", "\t\t\tERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            try
            {
                txtbxNumero.Text += "7";
                if (ip == 4)
                {
                    num1 = double.Parse(LblAux.Text);
                    num2 = double.Parse(txtbxNumero.Text);
                    ObjRes.sets(num1, num2);
                    respuesta = ObjRes.Division();
                    txtbxNumero.Text = respuesta.ToString();
                    ip = 0;
                }
                if (ip == 5)
                {
                    num1 = double.Parse(LblAux.Text);
                    num2 = double.Parse(txtbxNumero.Text);
                    ObjRes.sets(num1, num2);
                    respuesta = ObjRes.Potencia();
                    txtbxNumero.Text = respuesta.ToString();
                    ip = 0;
                }
                if (ip == 6)
                {
                    num1 = double.Parse(txtbxNumero.Text);
                    ObjRes.set(num1);
                    txtbxNumero.Text = ObjRes.Raiz().ToString();
                    ip = 0;
                }
            }
            catch
            {
                MessageBox.Show("Ingrese número primero", "\t\t\tERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            try
            {
                txtbxNumero.Text = txtbxNumero.Text + "8";
                if (ip == 4)
                {
                    num1 = double.Parse(LblAux.Text);
                    num2 = double.Parse(txtbxNumero.Text);
                    ObjRes.sets(num1, num2);
                    respuesta = ObjRes.Division();
                    txtbxNumero.Text = respuesta.ToString();
                    ip = 0;
                }
                if (ip == 5)
                {
                    num1 = double.Parse(LblAux.Text);
                    num2 = double.Parse(txtbxNumero.Text);
                    ObjRes.sets(num1, num2);
                    respuesta = ObjRes.Potencia();
                    txtbxNumero.Text = respuesta.ToString();
                    ip = 0;
                }
                if (ip == 6)
                {
                    num1 = double.Parse(txtbxNumero.Text);
                    ObjRes.set(num1);
                    txtbxNumero.Text = ObjRes.Raiz().ToString();
                    ip = 0;
                }
            }
            catch
            {
                MessageBox.Show("Ingrese número primero", "\t\t\tERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            try
            {
                txtbxNumero.Text = txtbxNumero.Text + "9";
                if (ip == 4)
                {
                    num1 = double.Parse(LblAux.Text);
                    num2 = double.Parse(txtbxNumero.Text);
                    ObjRes.sets(num1, num2);
                    respuesta = ObjRes.Division();
                    txtbxNumero.Text = respuesta.ToString();
                    ip = 0;
                }
                if (ip == 5)
                {
                    num1 = double.Parse(LblAux.Text);
                    num2 = double.Parse(txtbxNumero.Text);
                    ObjRes.sets(num1, num2);
                    respuesta = ObjRes.Potencia();
                    txtbxNumero.Text = respuesta.ToString();
                    ip = 0;
                }
                if (ip == 6)
                {
                    num1 = double.Parse(txtbxNumero.Text);
                    ObjRes.set(num1);
                    txtbxNumero.Text = ObjRes.Raiz().ToString();
                    ip = 0;
                }
            }
            catch
            {
                MessageBox.Show("Ingrese número primero", "\t\t\tERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                num2 = double.Parse(txtbxNumero.Text);
                num1 = double.Parse(lblRespuesta.Text);
                ObjRes.sets(num1, num2);
                

                if (id == 1)
                {
                    num1 = double.Parse(LblAux.Text);
                    
                    ObjRes.sets(num1, num2);
                    respuesta = ObjRes.Suma();
                    id = 0;
                    
                }
                if (id == 2)
                {

                    respuesta = ObjRes.Resta();

                }

                if (id == 3)
                {

                    respuesta = ObjRes.Multiplicacion();

                }
                if (ip == 5)
                {
                    respuesta = ObjRes.Potencia();
                    txtbxNumero.Text = respuesta.ToString();
                    ip = 0;
                }
                if (id == 6)
                    respuesta = ObjRes.Minimo();
                if (id == 7)
                    respuesta = ObjRes.Maximo();
                //lblRespuesta.Text = respuesta.ToString();
                lblRespuesta.Text = "0";
                txtbxNumero.Text = respuesta.ToString();
            }
            catch
            {
                //MessageBox.Show("Ingrese número primero", "\t\t\tERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            num1 = 0;
            num2 = 0;
            respuesta = 0;
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            try
            {
                id = 1;
                //lblRespuesta.Text = txtbxNumero.Text;
                LblAux.Text = txtbxNumero.Text;
                num1 = double.Parse(LblAux.Text);
                txtbxNumero.Clear();
                btnComa.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Ingrese número primero", "\t\t\tERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            try
            {
                ip = 0;
                id = 2;
                num1 = double.Parse(txtbxNumero.Text);
                lblRespuesta.Text = txtbxNumero.Text;
                txtbxNumero.Clear();
                btnComa.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Ingrese número primero", "\t\t\tERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            try
            {
                ip = 0;
                id = 3;
                lblRespuesta.Text = txtbxNumero.Text;
                num1 = double.Parse(lblRespuesta.Text);
                txtbxNumero.Clear();
                btnComa.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Ingrese número primero", "\t\t\tERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            try
            {
                ip = 4;
                num1 = double.Parse(txtbxNumero.Text);
                LblAux.Text = txtbxNumero.Text;
                txtbxNumero.Clear();
                btnComa.Enabled = true;
            }
            catch
            {
                ip = 0;
                MessageBox.Show("Ingrese número primero", "\t\t\tERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = double.Parse(txtbxNumero.Text);
                ClOperaciones ObjRes = new ClOperaciones(num1);
                lblRespuesta.Text = txtbxNumero.Text;
                lblRespuesta.Text = ObjRes.Seno().ToString();
                btnComa.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Ingrese número primero", "\t\t\tERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = double.Parse(txtbxNumero.Text);
                ClOperaciones ObjRes = new ClOperaciones(num1);
                lblRespuesta.Text = txtbxNumero.Text;
                lblRespuesta.Text = ObjRes.Coseno().ToString();
                btnComa.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Ingrese número primero", "\t\t\tERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = double.Parse(txtbxNumero.Text);
                ClOperaciones ObjRes = new ClOperaciones(num1);
                lblRespuesta.Text = txtbxNumero.Text;
                lblRespuesta.Text = ObjRes.Tangente().ToString();
                btnComa.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Ingrese número primero", "\t\t\tERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = double.Parse(txtbxNumero.Text);
                ClOperaciones ObjRes = new ClOperaciones(num1);
                lblRespuesta.Text = txtbxNumero.Text;
                lblRespuesta.Text = ObjRes.Logaritmo().ToString();
                btnComa.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Ingrese número primero", "\t\t\tERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnln_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = double.Parse(txtbxNumero.Text);
                ClOperaciones ObjRes = new ClOperaciones(num1);
                lblRespuesta.Text = ObjRes.LogaritmoNatural().ToString();
                txtbxNumero.Text = lblRespuesta.Text;
                btnComa.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Ingrese número primero", "\t\t\tERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            try
            {
                ip = 6;
                
                btnComa.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Ingrese número primero", "\t\t\tERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPot_Click(object sender, EventArgs e)
        {
            try
            {
                ip = 5;
                num1 = double.Parse(txtbxNumero.Text);
                lblRespuesta.Text = txtbxNumero.Text;
                txtbxNumero.Clear();
                btnComa.Enabled = true;
            }
            catch
            {
                ip = 0;
                MessageBox.Show("Ingrese número primero", "\t\t\tERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAbs_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtbxNumero.Text);
            ClOperaciones ObjRes = new ClOperaciones(num1);
            lblRespuesta.Text = ObjRes.Absoluto().ToString();
            btnComa.Enabled = true;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            try
            {
                id = 6;
                num1 = double.Parse(txtbxNumero.Text);
                lblRespuesta.Text = txtbxNumero.Text;
                txtbxNumero.Clear();
                btnComa.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Ingrese número primero", "\t\t\tERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            try
            {
                id = 7;
                num1 = double.Parse(txtbxNumero.Text);
                lblRespuesta.Text = txtbxNumero.Text;
                txtbxNumero.Clear();
                btnComa.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Ingrese número primero", "\t\t\tERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMasMenos_Click(object sender, EventArgs e)
        {
            if (txtbxNumero.Text == "")
                txtbxNumero.Text += "-";
        }

        private void lblRespuesta_Click(object sender, EventArgs e)
        {

        }
    }
}
