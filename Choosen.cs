using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Bai_TH1
{
    public partial class Choosen : Form
    {
        bool flag;
        public Choosen()
        {
            InitializeComponent();
        }
        public Choosen(bool flagg)
        {
            flag = flagg;
            InitializeComponent();
        }
        void play_click()
        {
            if (flag == true)
            {
                SoundPlayer audio = new SoundPlayer(Properties.Resources.Hover); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
                audio.Play();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            play_click();
            this.Close();
            Start n = new Start(flag,1);
            n.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            play_click();
            this.Close();
            Start n = new Start(flag, 2);
            n.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            play_click();
            this.Close();
            Start n = new Start(flag, 3);
            n.ShowDialog();
        }
    }
}
