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
using System.IO;

namespace WinAppVoiceImages
{
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine objListen = new SpeechRecognitionEngine(
          new System.Globalization.CultureInfo("es-ES"));
        int cont = 0;
        string path = Application.StartupPath;
        string file1 = "cat.jpg";
        string file2 = "dog.png";
        string file3 = "duck.jpg";
        string file4 = "mouse.jpg";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
            ListBoxWords.Items.Add(textBox1.Text);

        }

        private void ListBoxWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path1 = Path.Combine(path, file1);
            string path2 = Path.Combine(path, file2);
            string path3 = Path.Combine(path, file3);
            string path4 = Path.Combine(path, file4);
            if (ListBoxWords.SelectedItem.ToString() == "ratón")
            {
                PbxImage.Image = Image.FromFile(path4);
            }
            if (ListBoxWords.SelectedItem.ToString() == "perro")
            {
                PbxImage.Image = Image.FromFile(path2);
            }
            if (ListBoxWords.SelectedItem.ToString() == "gato")
            {
                PbxImage.Image = Image.FromFile(path1);
            }
            if (ListBoxWords.SelectedItem.ToString() == "pato")
            {
                PbxImage.Image = Image.FromFile(path3);
            }
        }
    }
}
