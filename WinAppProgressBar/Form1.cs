using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int progress = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.MarqueeAnimationSpeed = 5;
            while (progress >= 0 && progress <= 100)
            {
                progress += 1;
                if (progress < 101)
                {
                    progressBar1.Value = progress;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.MarqueeAnimationSpeed = 0;
            //progressBar1.Value = progressBar1.Value;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progress = 0;
        }
    }
}
