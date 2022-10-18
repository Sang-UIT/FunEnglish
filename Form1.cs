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
    public partial class FunEnglish : Form
    {
        public FunEnglish()
        {
            InitializeComponent();
        }
        bool flag = true;
        private void Learning_hover(object sender, EventArgs e)
        {
            label_learning.ForeColor = Color.OrangeRed;
            pictureBox4.Size = new System.Drawing.Size(80, 60);
        }
        private void label_learning_MouseLeave(object sender, EventArgs e)
        {
            label_learning.ForeColor = Color.DarkGoldenrod;
            pictureBox4.Size = new System.Drawing.Size(88, 65);
        }
        private void exit_hover(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.DarkRed;
            pictureBox5.Size = new System.Drawing.Size(80, 60);
            

        }
        private void exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.OrangeRed;
            pictureBox5.Size = new System.Drawing.Size(88, 65);
        }
        private void credit_hover(object sender, EventArgs e)
        {
            label_credit.ForeColor = Color.OrangeRed;
            pictureBox6.Size = new System.Drawing.Size(80, 60);
        }
        private void credit_MouseLeave(object sender, EventArgs e)
        {
            label_credit.ForeColor = Color.DarkGoldenrod;
            pictureBox6.Size = new System.Drawing.Size(88, 65);
        }
        private void Rank_hover(object sender, EventArgs e)
        {
            label_ranking.ForeColor = Color.OrangeRed;
            pictureBox3.Size = new System.Drawing.Size(118, 88);
        }
        private void Rank_MouseLeave(object sender, EventArgs e)
        {
            label_ranking.ForeColor = Color.DarkGoldenrod;
            pictureBox3.Size = new System.Drawing.Size(122, 92);
        }
        private void Start_hover(object sender, EventArgs e)
        {
            label_start.ForeColor = Color.OrangeRed;
            pictureBox1.Size = new System.Drawing.Size(98, 78);
        }
        private void Start_MouseLeave(object sender, EventArgs e)
        {
            label_start.ForeColor = Color.Green;
            pictureBox1.Size = new System.Drawing.Size(103, 83);
        }
        private void FunEnglish_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            play_click();
            Choosen s = new Choosen(flag);
            s.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            play_click();
            Learning n = new Learning(flag);
            n.ShowDialog();
 
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            play_click();
            Ranking n = new Ranking(flag);
            n.ShowDialog();
        }

        private void label_start_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            play_click();
            string message = "Do you want to close this game?";
            string title = "Close Game";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
           
        }
        void play_click()
        {
            if (flag == true)
            {
                SoundPlayer audio = new SoundPlayer(Properties.Resources.Hover); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
                audio.Play();
            }
        }
        
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox8.Visible = true;
            if (flag == true)
                flag = false;
            else
                flag = true;
            play_click();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            play_click();
            string message = "Compose: Trương Tấn Sang\nStudent code: 20520736\nInstructors: Nguyễn Bích Vân\nUniversity of Information Technology";
            string title = "Credit";
            DialogResult result = MessageBox.Show(message, title);
            
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox8.Visible = false;
            if (flag == true)
                flag = false;
            else
                flag = true;
            play_click();
        }
    }
}
