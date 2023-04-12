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
using System.Speech.Recognition;

namespace WinAppVoice
{
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine objListen = new SpeechRecognitionEngine();
        public Form1()
        {
            InitializeComponent();
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

        private void BtnStop_Click(object sender, EventArgs e)
        {
            objListen.RecognizeAsyncStop();
        }
    }
}
