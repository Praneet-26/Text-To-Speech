using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.IO;
using System.IO.Pipes;


namespace Text_To_Speech
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer ss;
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnread_Click(object sender, EventArgs e)
        {
            ss = new SpeechSynthesizer();
            ss.Rate = trkSpeed.Value;
            ss.Volume = 100;
            ss.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
            ss.SpeakAsync(textBox1.Text);
        }

        private void Btnpause_Click(object sender, EventArgs e)
        {
            ss.Pause();
        }

        private void BtnResume_Click(object sender, EventArgs e)
        {
            ss.Resume();
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text documents| *.txt";
            ofd.ShowDialog();
            string fname = ofd.FileName;
            StreamReader sr = new StreamReader(fname);
            textBox1.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Wave Files| *.wav";
            sfd.ShowDialog();
            String fname;
            fname= sfd.FileName;
            SpeechSynthesizer ss = new SpeechSynthesizer();
            ss.Rate = trkSpeed.Value;
            ss.Volume = 100;
            ss.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
            ss.SetOutputToWaveFile(fname);
            ss.Speak(textBox1.Text);
            ss.SetOutputToDefaultAudioDevice();
            MessageBox.Show("Wave File has been saved successfully.");
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
