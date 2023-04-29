using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;

namespace WinAppVoiceImages
{
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine objListen = new SpeechRecognitionEngine(
          new System.Globalization.CultureInfo("es-ES"));
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {

            objListen.SetInputToDefaultAudioDevice(); // detecta el micro
            objListen.LoadGrammar(new DictationGrammar());    //cargar patrones de voz
            objListen.SpeechRecognized += Deteccion;
            objListen.RecognizeAsync(RecognizeMode.Multiple);
        }
        void Deteccion(object sender, SpeechRecognizedEventArgs e)
        {
            textBox1.Text = e.Result.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            objListen.RecognizeAsyncStop();
            if(textBox1.Text == "ratón")
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
            }
            if (textBox1.Text == "perro")
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
            }
            if (textBox1.Text == "gato")
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                pictureBox4.Visible = false;
            }
            if (textBox1.Text == "pato")
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
            }
        }
    }
}
