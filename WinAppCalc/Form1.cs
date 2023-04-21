using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WinAppCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        double n1, id;


        private void Btn0_Click(object sender, EventArgs e)
        {
            if (id == 5)
            {
                TxtResult.Text += 0;
            }
            if (id == 7)
            {
                TxtResult.Text += 0;
            }
            if (id == 8)
            {
                TxtResult.Text += 0;
            }
            if (id == 9)
            {
                TxtResult.Text += 0;
            }
            if (id == 10)
            {
                TxtResult.Text += 0;
            }
            if (id == 11)
            {
                TxtResult.Text += 0;
            }
            if (id >= 0 && id <= 4)
            {
                TxtAux.Text = "0";
                TxtNumbers.Text += TxtAux.Text;
                id = 0;
            }
        }
        private void Btn1_Click(object sender, EventArgs e)
        {
            if (id == 5)
            {
                TxtResult.Text += 1;
            }
            if (id == 7)
            {
                TxtResult.Text += 1;
            }
            if (id == 8)
            {
                TxtResult.Text += 1;
            }
            if (id == 9)
            {
                TxtResult.Text += 1;
            }
            if (id == 10)
            {
                TxtResult.Text += 1;
            }
            if (id == 11)
            {
                TxtResult.Text += 1;
            }
            if (id == 12)
            {
                TxtResult.Text += 1;
            }
            if (id >= 0 && id <= 4)
            {
                TxtAux.Text = "1";
                TxtNumbers.Text += TxtAux.Text;
                id = 0;
            }
        }
        private void Btn2_Click(object sender, EventArgs e)
        {
            if (id == 5)
            {
                TxtResult.Text += 2;
            }
            if (id == 7)
            {
                TxtResult.Text += 2;
            }
            if (id == 8)
            {
                TxtResult.Text += 2;
            }
            if (id == 9)
            {
                TxtResult.Text += 2;
            }
            if (id == 10)
            {
                TxtResult.Text += 2;
            }
            if (id == 11)
            {
                TxtResult.Text += 2;
            }
            if (id == 12)
            {
                TxtResult.Text += 2;
            }
            if (id >= 0 && id <= 4)
            {
                TxtAux.Text = "2";
                TxtNumbers.Text += TxtAux.Text;
                id = 0;
            }
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (id == 5)
            {
                TxtResult.Text += 3;
            }
            if (id == 7)
            {
                TxtResult.Text += 3;
            }
            if (id == 8)
            {
                TxtResult.Text += 3;
            }
            if (id == 9)
            {
                TxtResult.Text += 3;
            }
            if (id == 10)
            {
                TxtResult.Text += 3;
            }
            if (id == 11)
            {
                TxtResult.Text += 3;
            }
            if (id == 12)
            {
                TxtResult.Text += 3;
            }
            if (id >= 0 && id <= 4)
            {
                TxtAux.Text = "3";
                TxtNumbers.Text += TxtAux.Text;
                id = 0;
            }
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (id == 5)
            {
                TxtResult.Text += 4;
            }
            if (id == 7)
            {
                TxtResult.Text += 4;
            }
            if (id == 8)
            {
                TxtResult.Text += 4;
            }
            if (id == 9)
            {
                TxtResult.Text += 4;
            }
            if (id == 10)
            {
                TxtResult.Text += 4;
            }
            if (id == 11)
            {
                TxtResult.Text += 4;
            }
            if (id == 12)
            {
                TxtResult.Text += 4;
            }
            if (id >= 0 && id <= 4)
            {
                TxtAux.Text = "4";
                TxtNumbers.Text += TxtAux.Text;
                id = 0;
            }
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (id == 5)
            {
                TxtResult.Text += 5;
            }
            if (id == 7)
            {
                TxtResult.Text += 5;
            }
            if (id == 8)
            {
                TxtResult.Text += 5;
            }
            if (id == 9)
            {
                TxtResult.Text += 5;
            }
            if (id == 10)
            {
                TxtResult.Text += 5;
            }
            if (id == 11)
            {
                TxtResult.Text += 5;
            }
            if (id == 12)
            {
                TxtResult.Text += 5;
            }
            if (id >= 0 && id <= 4)
            {
                TxtAux.Text = "5";
                TxtNumbers.Text += TxtAux.Text;
                id = 0;
            }
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (id == 5)
            {
                TxtResult.Text += 6;
            }
            if (id == 7)
            {
                TxtResult.Text += 6;
            }
            if (id == 8)
            {
                TxtResult.Text += 6;
            }
            if (id == 9)
            {
                TxtResult.Text += 6;
            }
            if (id == 10)
            {
                TxtResult.Text += 6;
            }
            if (id == 11)
            {
                TxtResult.Text += 6;
            }
            if (id == 12)
            {
                TxtResult.Text += 6;
            }
            if (id >= 0 && id <= 4)
            {
                TxtAux.Text = "6";
                TxtNumbers.Text += TxtAux.Text;
                id = 0;
            }
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (id == 5)
            {
                TxtResult.Text += 7;
            }
            if (id == 7)
            {
                TxtResult.Text += 7;
            }
            if (id == 8)
            {
                TxtResult.Text += 7;
            }
            if (id == 9)
            {
                TxtResult.Text += 7;
            }
            if (id == 10)
            {
                TxtResult.Text += 7;
            }
            if (id == 11)
            {
                TxtResult.Text += 7;
            }
            if (id == 12)
            {
                TxtResult.Text += 7;
            }
            if (id >= 0 && id <= 4)
            {
                TxtAux.Text = "7";
                TxtNumbers.Text += TxtAux.Text;
                id = 0;
            }
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (id == 5)
            {
                TxtResult.Text += 8;
            }
            if (id == 7)
            {
                TxtResult.Text += 8;
            }
            if (id == 8)
            {
                TxtResult.Text += 8;
            }
            if (id == 9)
            {
                TxtResult.Text += 8;
            }
            if (id == 10)
            {
                TxtResult.Text += 8;
            }
            if (id == 11)
            {
                TxtResult.Text += 8;
            }
            if (id == 12)
            {
                TxtResult.Text += 8;
            }
            if (id >= 0 && id <= 4)
            {
                TxtAux.Text = "8";
                TxtNumbers.Text += TxtAux.Text;
                id = 0;
            }
        }

        private void Btn10_Click(object sender, EventArgs e)
        {
            if (id == 5)
            {
                TxtResult.Text += 9;
            }
            if (id == 7)
            {
                TxtResult.Text += 9;
            }
            if (id == 8)
            {
                TxtResult.Text += 9;
            }
            if (id == 9)
            {
                TxtResult.Text += 9;
            }
            if (id == 10)
            {
                TxtResult.Text += 9;
            }
            if (id == 11)
            {
                TxtResult.Text += 9;
            }
            if (id == 12)
            {
                TxtResult.Text += 9;
            }
            if (id >= 0 && id <= 4)
            {
                TxtAux.Text = "9";
                TxtNumbers.Text += TxtAux.Text;
                id = 0;
            }
        }

        private void BtnRest_Click(object sender, EventArgs e)
        {
            try
            {
                if(id == 12)
                {
                    TxtResult.Text += "-";
                }else if (id != 2)
                {
                    id = 2;
                    TxtNumbers.Text += "-";
                }
                else
                {
                    MessageBox.Show("No puede ingresar doble signo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //TxtResult.Text = TxtNumbers.Text;
                //TxtNumbers.Clear();
            }
            catch
            {
                MessageBox.Show("Ingrese número primero", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnMult_Click(object sender, EventArgs e)
        {
            try
            {
                n1 = double.Parse(TxtAux.Text);
                if (id != 3)
                {
                    id = 3;
                    TxtNumbers.Text += "*";
                }
                else
                {
                    MessageBox.Show("No puede ingresar doble signo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //TxtResult.Text = TxtNumbers.Text;
                //TxtNumbers.Clear();
            }
            catch
            {
                MessageBox.Show("Ingrese número primero", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            try
            {
                n1 = double.Parse(TxtAux.Text);
                if (id != 4)
                {
                    id = 4;
                    TxtNumbers.Text += "/";
                }
                else
                {
                    MessageBox.Show("No puede ingresar doble signo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Ingrese número primero", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            TxtResult.Clear();
            TxtNumbers.Clear();
            TxtAux.Clear();
            BtnTan.UseVisualStyleBackColor = false;
            BtnCos.UseVisualStyleBackColor = false;
            BtnSin.UseVisualStyleBackColor = false;
            BtnRaiz.UseVisualStyleBackColor = false;
            BtnLog.UseVisualStyleBackColor = false;
            BtnLn.UseVisualStyleBackColor = false;
            id = 0;
        }

        private void BtnRaiz_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtResult.Text == "" && id != 5)
                {
                    BtnMin.Visible = false;
                    BtnBack.Visible = true;
                    if (id != 0 || TxtAux.Text == "")
                    {
                        id = 5;
                        BtnRaiz.UseVisualStyleBackColor = true;
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar un número o debe haber un operador precedido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    BtnMin.Visible = true;
                    BtnBack.Visible = false;
                    TxtNumbers.Text += Math.Truncate(Math.Sqrt(double.Parse(TxtResult.Text)) * 10000) / 10000;
                    BtnRaiz.UseVisualStyleBackColor = false;
                    TxtAux.Text = TxtResult.Text;
                    TxtResult.Clear();
                    id = 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe ingresar un número o debe haber un operador precedido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                id = 0;
            }
        }

        private void BtnPc_Click(object sender, EventArgs e)
        {
            try
            {
                n1 = double.Parse(TxtAux.Text);
                TxtNumbers.Text += ")";
            }
            catch
            {
                MessageBox.Show("Ingrese número primero", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCos_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtResult.Text == "" && id != 10)
                {
                    if (id != 0 || TxtAux.Text == "")
                    {
                        id = 10;
                        BtnCos.UseVisualStyleBackColor = true;
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar un número o debe haber un operador precedido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    TxtNumbers.Text += Math.Cos(double.Parse(TxtResult.Text) * (Math.PI) / 180);
                    BtnCos.UseVisualStyleBackColor = false;
                    TxtAux.Text = TxtResult.Text;
                    TxtResult.Clear();
                    id = 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe ingresar un número o debe haber un operador precedido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                id = 0;
            }
        }

        private void BtnPot_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtResult.Text == "" && id != 6)
                {
                    if (id != 0 || TxtAux.Text == "")
                    {
                        LblBase.Text = "Base";
                        LblExponente.Text = "Exponente";
                        LblBase.Visible = true;
                        LblExponente.Visible = true;
                        BtnLog.Visible = false;
                        BtnLn.Visible = false;
                        TxtBase.Visible = true;
                        TxtExp.Visible = true;
                        BtnBack.Visible = true;
                        BtnMin.Visible = false;
                        BtnMax.Enabled = false;
                        Btn0.Enabled = false;
                        Btn1.Enabled = false;
                        Btn2.Enabled = false;
                        Btn3.Enabled = false;
                        Btn4.Enabled = false;
                        Btn5.Enabled = false;
                        Btn6.Enabled = false;
                        Btn7.Enabled = false;
                        Btn8.Enabled = false;
                        Btn10.Enabled = false;
                        BtnPc.Enabled = false;
                        BtnSin.Enabled = false;
                        BtnCos.Enabled = false;
                        BtnTan.Enabled = false;
                        BtnPot.UseVisualStyleBackColor = true;
                        id = 6;
                    }
                    else
                    {
                        MessageBox.Show("Debe haber un operador precedido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    LblBase.Visible = false;
                    LblExponente.Visible = false;
                    BtnLog.Visible = true;
                    BtnLn.Visible = true;
                    TxtBase.Visible = false;
                    TxtExp.Visible = false;
                    BtnBack.Visible = false;
                    BtnMin.Visible = true;
                    BtnMax.Enabled = true;
                    Btn0.Enabled = true;
                    Btn1.Enabled = true;
                    Btn2.Enabled = true;
                    Btn3.Enabled = true;
                    Btn4.Enabled = true;
                    Btn5.Enabled = true;
                    Btn6.Enabled = true;
                    Btn7.Enabled = true;
                    Btn8.Enabled = true;
                    Btn10.Enabled = true;
                    BtnPc.Enabled = true;
                    BtnSin.Enabled = true;
                    BtnCos.Enabled = true;
                    BtnTan.Enabled = true;
                    double a = double.Parse(TxtBase.Text);
                    double b = double.Parse(TxtExp.Text);
                    double pot = Math.Truncate(Math.Pow(a, b) * 10000) / 10000;
                    TxtNumbers.Text += pot;
                    TxtAux.Text = pot.ToString();
                    BtnPot.UseVisualStyleBackColor = false;
                    TxtResult.Clear();
                    id = 0;
                    TxtBase.Clear();
                    TxtExp.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe ingresar un número", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                id = 0;
            }
        }

        private void BtnLog_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtResult.Text == "" && id != 7)
                {
                    if (id != 0 || TxtAux.Text == "")
                    {
                        id = 7;
                        BtnLog.UseVisualStyleBackColor = true;
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar un número o debe haber un operador precedido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    TxtNumbers.Text += Math.Truncate(Math.Log10(double.Parse(TxtResult.Text)) * 10000) / 10000;
                    BtnLog.UseVisualStyleBackColor = false;
                    TxtAux.Text = TxtResult.Text;
                    TxtResult.Clear();
                    id = 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe ingresar un número o debe haber un operador precedido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                id = 0;
            }

        }

        private void BtnPa_Click(object sender, EventArgs e)
        {
            TxtNumbers.Text += "(";
        }

        private void BtnLn_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtResult.Text == "" && id != 8)
                {
                    if (id != 0 || TxtAux.Text == "")
                    {
                        id = 8;
                        BtnLn.UseVisualStyleBackColor = true;
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar un número o debe haber un operador precedido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    TxtNumbers.Text += Math.Truncate(Math.Log(double.Parse(TxtResult.Text)) * 10000) / 10000;
                    BtnLn.UseVisualStyleBackColor = false;
                    TxtAux.Text = TxtResult.Text;
                    TxtResult.Clear();
                    id = 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe ingresar un número o debe haber un operador precedido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                id = 0;
            }
        }

        private void BtnMov_Click(object sender, EventArgs e)
        {
            TxtNumbers.Text = TxtResult.Text;
            TxtResult.Clear();
        }

        private void BtnSum_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtAux.Text == "")
                {
                    n1 = double.Parse(TxtNumbers.Text);
                }

                if (id != 1)
                {
                    id = 1;
                    TxtNumbers.Text += "+";
                    TxtAux.Clear();
                }
                else
                {
                    MessageBox.Show("No puede ingresar doble signo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Ingrese número primero", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnP_Click(object sender, EventArgs e)
        {
            if (id == 5)
            {
                TxtResult.Text += ".";
            }
            if (id == 6)
            {
                TxtResult.Text += ".";
            }
            if (id == 7)
            {
                TxtResult.Text += ".";
            }
            if (id == 8)
            {
                TxtResult.Text += ".";
            }
            if (id == 9)
            {
                TxtResult.Text += ".";
            }
            if (id == 10)
            {
                TxtResult.Text += ".";
            }
            if (id == 11)
            {
                TxtResult.Text += ".";
            }
            if (id >= 0 && id <= 4)
            {
                TxtAux.Text = ".";
                TxtNumbers.Text += TxtAux.Text;
                id = 0;
            }
        }

        private void BtnSin_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtResult.Text == "" && id != 9)
                {
                    if (id != 0 || TxtAux.Text == "")
                    {
                        id = 9;
                        BtnSin.UseVisualStyleBackColor = true;
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar un número o debe haber un operador precedido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {                    
                    TxtNumbers.Text += Math.Truncate(Math.Sin(double.Parse(TxtResult.Text) * (Math.PI) / 180) * 1000) / 1000;
                    BtnSin.UseVisualStyleBackColor = false;
                    TxtAux.Text = TxtResult.Text;
                    TxtResult.Clear();
                    id = 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe ingresar un número o debe haber un operador precedido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                id = 0;
            }
        }

        private void BtnTan_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtResult.Text == "" && id != 11)
                {
                    if (id != 0 || TxtAux.Text == "")
                    {
                        id = 11;
                        BtnTan.UseVisualStyleBackColor = true;
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar un número o debe haber un operador precedido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    TxtNumbers.Text += Math.Tan(double.Parse(TxtResult.Text) * (Math.PI) / 180);
                    BtnTan.UseVisualStyleBackColor = false;
                    TxtAux.Text = TxtResult.Text;
                    TxtResult.Clear();
                    id = 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe ingresar un número o debe haber un operador precedido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                id = 0;
            }
        }

        private void BtnPot_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(BtnPot, "Despliega inputs para ingresar base y potencia");
        }

        private void TxtBase_MouseClick(object sender, MouseEventArgs e)
        {
            TxtBase.Clear();
        }

        private void TxtExp_MouseClick(object sender, MouseEventArgs e)
        {
            TxtExp.Clear();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (id >= 5)
            {
                id = 0;
                BtnRaiz.UseVisualStyleBackColor = false;
                BtnPot.UseVisualStyleBackColor = false;
                BtnAbs.UseVisualStyleBackColor = false;
                BtnMax.UseVisualStyleBackColor = false;
                LblBase.Visible = false;
                LblExponente.Visible = false;
                BtnLog.Visible = true;
                BtnLn.Visible = true;
                Btn0.Enabled = true;
                Btn1.Enabled = true;
                Btn2.Enabled = true;
                Btn3.Enabled = true;
                Btn4.Enabled = true;
                Btn5.Enabled = true;
                Btn6.Enabled = true;
                Btn7.Enabled = true;
                Btn8.Enabled = true;
                Btn10.Enabled = true;
                BtnMax.Enabled = true;
                BtnMin.Visible = true;
                BtnBack.Visible = false;
                TxtBase.Visible = false;
                TxtExp.Visible = false;
            }
        }

        private void BtnRaiz_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(BtnRaiz, "Click 1 para ingresar un número\nClick 2 para calcular la raíz de ese número");
        }

        private void BtnAbs_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtResult.Text == "" && id != 12)
                {
                    BtnMin.Visible = false;
                    BtnBack.Visible = true;
                    if (id != 0 || TxtAux.Text == "")
                    {
                        id = 12;
                        BtnAbs.UseVisualStyleBackColor = true;
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar un número o debe haber un operador precedido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    BtnMin.Visible = true;
                    BtnBack.Visible = false;
                    TxtNumbers.Text += Math.Truncate(Math.Abs(double.Parse(TxtResult.Text)) * 10000) / 10000;
                    BtnAbs.UseVisualStyleBackColor = false;
                    TxtAux.Text = TxtResult.Text;
                    TxtResult.Clear();
                    id = 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe ingresar un número o debe haber un operador precedido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                id = 0;
            }
        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtResult.Text == "" && id != 12)
                {
                    if (id != 0 || TxtAux.Text == "")
                    {
                        LblBase.Text = "Num1";
                        LblExponente.Text = "Num2";
                        LblBase.Visible = true;
                        LblExponente.Visible = true;
                        BtnLog.Visible = false;
                        BtnLn.Visible = false;
                        TxtBase.Visible = true;
                        TxtExp.Visible = true;
                        BtnBack.Visible = true;
                        BtnMin.Visible = false;
                        Btn0.Enabled = false;
                        Btn1.Enabled = false;
                        Btn2.Enabled = false;
                        Btn3.Enabled = false;
                        Btn4.Enabled = false;
                        Btn5.Enabled = false;
                        Btn6.Enabled = false;
                        Btn7.Enabled = false;
                        Btn8.Enabled = false;
                        Btn10.Enabled = false;
                        BtnPc.Enabled = false;
                        BtnMax.UseVisualStyleBackColor = true;
                        id = 12;
                    }
                    else
                    {
                        MessageBox.Show("Debe haber un operador precedido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    LblBase.Visible = false;
                    LblExponente.Visible = false;
                    BtnLog.Visible = true;
                    BtnLn.Visible = true;
                    TxtBase.Visible = false;
                    TxtExp.Visible = false;
                    BtnBack.Visible = false;
                    BtnMin.Visible = true;
                    Btn0.Enabled = true;
                    Btn1.Enabled = true;
                    Btn2.Enabled = true;
                    Btn3.Enabled = true;
                    Btn4.Enabled = true;
                    Btn5.Enabled = true;
                    Btn6.Enabled = true;
                    Btn7.Enabled = true;
                    Btn8.Enabled = true;
                    Btn10.Enabled = true;
                    BtnPc.Enabled = true;
                    double a = double.Parse(TxtBase.Text);
                    double b = double.Parse(TxtExp.Text);
                    double max = Math.Max(a,b);
                    TxtNumbers.Text += max;
                    TxtAux.Text = max.ToString();
                    BtnMax.UseVisualStyleBackColor = false;
                    TxtResult.Clear();
                    id = 0;
                    TxtBase.Clear();
                    TxtExp.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe ingresar un número", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                id = 0;
            }
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtResult.Text == "" && id != 11)
                {
                    if (id != 0 || TxtAux.Text == "")
                    {
                        LblBase.Text = "Num1";
                        LblExponente.Text = "Num2";
                        LblBase.Visible = true;
                        LblExponente.Visible = true;
                        BtnLog.Visible = false;
                        BtnLn.Visible = false;
                        TxtBase.Visible = true;
                        TxtExp.Visible = true;
                        BtnBack.Visible = true;
                        BtnMin.Visible = false;
                        Btn0.Enabled = false;
                        Btn1.Enabled = false;
                        Btn2.Enabled = false;
                        Btn3.Enabled = false;
                        Btn4.Enabled = false;
                        Btn5.Enabled = false;
                        Btn6.Enabled = false;
                        Btn7.Enabled = false;
                        Btn8.Enabled = false;
                        Btn10.Enabled = false;
                        BtnPc.Enabled = false;
                        BtnMax.UseVisualStyleBackColor = true;
                        id = 11;
                    }
                    else
                    {
                        MessageBox.Show("Debe haber un operador precedido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    LblBase.Visible = false;
                    LblExponente.Visible = false;
                    BtnLog.Visible = true;
                    BtnLn.Visible = true;
                    TxtBase.Visible = false;
                    TxtExp.Visible = false;
                    BtnBack.Visible = false;
                    BtnMin.Visible = true;
                    Btn0.Enabled = true;
                    Btn1.Enabled = true;
                    Btn2.Enabled = true;
                    Btn3.Enabled = true;
                    Btn4.Enabled = true;
                    Btn5.Enabled = true;
                    Btn6.Enabled = true;
                    Btn7.Enabled = true;
                    Btn8.Enabled = true;
                    Btn10.Enabled = true;
                    BtnPc.Enabled = true;
                    double a = double.Parse(TxtBase.Text);
                    double b = double.Parse(TxtExp.Text);
                    double min = Math.Min(a, b);
                    TxtNumbers.Text += min;
                    TxtAux.Text = min.ToString();
                    BtnMax.UseVisualStyleBackColor = false;
                    TxtResult.Clear();
                    id = 0;
                    TxtBase.Clear();
                    TxtExp.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe ingresar un número", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                id = 0;
            }
        }

        private void TxtBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                TxtExp.Focus();
            }
        }

        private void TxtExp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                switch (id)
                {
                    case 6: BtnPot_Click(sender, e); break;
                    case 11: BtnMin_Click(sender, e); break;
                    case 12: BtnMax_Click(sender, e); break;
                }     
            }
        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                if (id != 5 && id != 7 && id != 8 && id != 9 && id != 10 && id != 11)
                {
                    string operacion = TxtNumbers.Text;
                    DataTable tabla = new DataTable();
                    var resultado = tabla.Compute(operacion, "");
                    TxtResult.Text = resultado.ToString();
                    id = 0;
                }
                else
                {
                    MessageBox.Show("Termine el ingreso de la operación", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese número primero o expresión incorrecta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show(ex.Message);
            }
        }
    }
}
