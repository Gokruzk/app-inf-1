using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (richTextBox1.SelectionFont != null)
                {
                    if (richTextBox1.SelectionFont.Italic && richTextBox1.SelectionFont.Bold)
                    {
                        Font currentFont = richTextBox1.SelectionFont;
                        Font newFont = new Font(currentFont.FontFamily, currentFont.Size, FontStyle.Regular);
                        richTextBox1.SelectionFont = newFont;
                        if (richTextBox1.SelectionFont.Style == FontStyle.Regular)
                        {
                            Font currentFont2 = richTextBox1.SelectionFont;
                            Font newFont2 = new Font(currentFont2.FontFamily, currentFont2.Size, FontStyle.Italic);
                            richTextBox1.SelectionFont = newFont2;
                            richTextBox1.Focus();
                        }
                    }
                    else if (richTextBox1.SelectionFont.Italic)
                    {
                        Font currentFont = richTextBox1.SelectionFont;
                        Font newFont = new Font(currentFont.FontFamily, currentFont.Size, FontStyle.Bold | FontStyle.Italic);
                        richTextBox1.SelectionFont = newFont;
                        richTextBox1.Focus();
                    }
                    else if (richTextBox1.SelectionFont.Bold)
                    {
                        Font currentFont = richTextBox1.SelectionFont;
                        Font newFont = new Font(currentFont.FontFamily, currentFont.Size, FontStyle.Regular);
                        richTextBox1.SelectionFont = newFont;
                        richTextBox1.Focus();
                    }
                    else
                    {
                        Font currentFont = richTextBox1.SelectionFont;
                        Font newFont = new Font(currentFont.FontFamily, currentFont.Size, FontStyle.Bold);
                        richTextBox1.SelectionFont = newFont;
                        richTextBox1.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (richTextBox1.SelectionFont != null)
                {
                    if (richTextBox1.SelectionFont.Italic && richTextBox1.SelectionFont.Bold)
                    {
                        Font currentFont = richTextBox1.SelectionFont;
                        Font newFont = new Font(currentFont.FontFamily, currentFont.Size, FontStyle.Regular);
                        richTextBox1.SelectionFont = newFont;
                        if (richTextBox1.SelectionFont.Style == FontStyle.Regular)
                        {
                            Font currentFont2 = richTextBox1.SelectionFont;
                            Font newFont2 = new Font(currentFont2.FontFamily, currentFont2.Size, FontStyle.Bold);
                            richTextBox1.SelectionFont = newFont2;
                            richTextBox1.Focus();
                        }
                    }
                    else if (richTextBox1.SelectionFont.Italic)
                    {
                        Font currentFont = richTextBox1.SelectionFont;
                        Font newFont = new Font(currentFont.FontFamily, currentFont.Size, FontStyle.Regular);
                        richTextBox1.SelectionFont = newFont;
                        richTextBox1.Focus();
                    }
                    else if (richTextBox1.SelectionFont.Bold)
                    {
                        Font currentFont = richTextBox1.SelectionFont;
                        Font newFont = new Font(currentFont.FontFamily, currentFont.Size, FontStyle.Italic | FontStyle.Bold);
                        richTextBox1.SelectionFont = newFont;
                        richTextBox1.Focus();
                    }
                    else
                    {
                        Font currentFont = richTextBox1.SelectionFont;
                        Font newFont = new Font(currentFont.FontFamily, currentFont.Size, FontStyle.Italic);
                        richTextBox1.SelectionFont = newFont;
                        richTextBox1.Focus();
                    }
                }
            }
            catch
            {
                MessageBox.Show("ERROR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (richTextBox1.SelectionFont != null)
                {
                    if (richTextBox1.SelectionAlignment == HorizontalAlignment.Left)
                    {
                        richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
                        richTextBox1.Focus();
                    }
                    else if (richTextBox1.SelectionAlignment == HorizontalAlignment.Right)
                    {
                        richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
                        richTextBox1.Focus();
                    }
                    else
                    {
                        richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
                        richTextBox1.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
                richTextBox1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (richTextBox1.SelectionFont != null && richTextBox1.SelectionAlignment == HorizontalAlignment.Right)
                {
                    richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
                    richTextBox1.Focus();
                }
                else
                {
                    richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
                    richTextBox1.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Font currentFont = richTextBox1.SelectionFont;
                Font newFont = new Font(comboBox1.SelectedItem.ToString(), currentFont.Size, currentFont.Style);
                richTextBox1.SelectionFont = newFont;
            }
            catch
            {
                MessageBox.Show("ERROR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Font currentFont = richTextBox1.SelectionFont;
                Font newFont = new Font(currentFont.FontFamily, (float)numericUpDown1.Value, currentFont.Style);
                richTextBox1.SelectionFont = newFont;
            }
            catch
            {
                MessageBox.Show("ERROR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Font currentFont = richTextBox1.SelectionFont;
                numericUpDown1.Value = (decimal)currentFont.Size;
                comboBox1.Text = currentFont.FontFamily.Name.ToString();
            }
            catch
            {
                MessageBox.Show("ERROR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                colorDialog1.ShowDialog();
                richTextBox1.SelectionColor = colorDialog1.Color;
                BtnColor.BackColor = colorDialog1.Color;
            }
            catch
            {
                MessageBox.Show("ERROR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
