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
using System.IO;

namespace Bai_TH1
{
    public partial class Ranking : Form
    {
        public Ranking()
        {
            InitializeComponent();
        }
        bool flag = true;
        
        void read_file(int z)
        {
            const Int32 BufferSize = 128;
            using (var fileStream = File.OpenRead(Properties.Resources.Ranking))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
            {
                String line;
                String[] linee = new String[30];
                int i = 0;
                int j = 1;
                //0,1,2
                while (j <= 30)
                {
                    line = streamReader.ReadLine();
                    linee[i] = line;
                    i++;
                    j++;
                }
                int[] score = new int[15];
                
                //0-4 fruits, 5-10 job, 11-15 animal
                //score
                label7.Text = linee[0 + 5 * z];
                label8.Text = linee[1 + 5 * z];
                label9.Text = linee[2 + 5 * z];
                label10.Text = linee[3 + 5 * z];
                label11.Text = linee[4 + 5 * z];
                //date
     
                label14.Text = linee[0 + 5 * z + 15];
                label15.Text = linee[1 + 5 * z + 15];
                label16.Text = linee[2 + 5 * z + 15];
                label17.Text = linee[3 + 5 * z + 15];
                label18.Text = linee[4 + 5 * z + 15];
            }
        }
        public Ranking(bool flagg)
        {
            flag = flagg;
            InitializeComponent();
            read_file(0);
        }
        private void Ranking_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        void play_click()
        {
            if (flag == true)
            {
                SoundPlayer audio = new SoundPlayer(Properties.Resources.Hover); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
                audio.Play();
            }
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            play_click();
            this.Close();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            read_file(0);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            read_file(1);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            read_file(2);
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
