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
    public partial class Learning : Form
    {
        bool flag=true;
        public Learning(bool flagg): this()
        {
            flag = flagg;
        }
        void add_dta()
        {
            DataTable dta = new DataTable();
            dta.Columns.Add("ID", typeof(string));
            dta.Columns.Add("English", typeof(string));
            dta.Columns.Add("Vietnamese", typeof(string));

            dta.Rows.Add("1", "Apple", "Quả Táo");
            dta.Rows.Add("2", "Pineapple", "Quả Dứa");
            dta.Rows.Add("3", "Coconut", "Quả Dừa");
            dta.Rows.Add("4", "Lemon", "Quả Chanh");
            dta.Rows.Add("5", "Orange", "Quả Cam");
            dta.Rows.Add("6", "Grapes", "Chùm Nho");
            dta.Rows.Add("7", "Water Melon", "Dưa Hấu");
            dta.Rows.Add("8", "Mango", "Quả Xoài");
            dta.Rows.Add("9", "Banana", "Quả Chuối");
            dta.Rows.Add("10", "Pear", "Quả Lê");
            dta.Rows.Add("11", "Peach", "Quả Đào");
            dta.Rows.Add("12", "Avocado", "Quả Bơ");
            dta.Rows.Add("13", "Strawberry", "Quả Dâu Tây");
            dta.Rows.Add("14", "Payaya", "Quả Đu Đủ");
            dta.Rows.Add("15", "Durian", "Quả Sầu Riêng");

            dataGridView1.DataSource = dta;
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 200;
        }
        void play_click()
        {
            if (flag == true)
            {
                SoundPlayer audio = new SoundPlayer(Properties.Resources.Hover); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
                audio.Play();
            }
        }
        void add_dtj()
        {
            DataTable dta = new DataTable();
            dta.Columns.Add("ID", typeof(string));
            dta.Columns.Add("English", typeof(string));
            dta.Columns.Add("Vietnamese", typeof(string));

            dta.Rows.Add("1", "Doctor", "Bác Sĩ");
            dta.Rows.Add("2", "Engineer", "Kĩ Sư");
            dta.Rows.Add("3", "Teacher", "Giáo Viên");
            dta.Rows.Add("4", "Singer", "Ca Sĩ");
            dta.Rows.Add("5", "Artist", "Nghệ Sĩ");
            dta.Rows.Add("6", "Policeman", "Cảnh Sát");
            dta.Rows.Add("7", "Pilot", "Phi Công");
            dta.Rows.Add("8", "Cook", "Đầu Bếp");
            dta.Rows.Add("9", "Dentist", "Nha Sĩ");
            dta.Rows.Add("10", "Fire Fighter", "C.Sát Cứu Hỏa");
            dta.Rows.Add("11", "Astronaut", "Phi Hành Gia");
            dta.Rows.Add("12", "Nurse", "Y Tá");
            dta.Rows.Add("13", "Cashies", "Thu Ngân");
            dta.Rows.Add("14", "Waiter", "Phục Vụ");
            dta.Rows.Add("15", "Baker", "Thợ Làm Bánh");
            dataGridView1.DataSource = dta;
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 200;
        }
        void add_dtani()
        {
            DataTable dta = new DataTable();
            dta.Columns.Add("ID", typeof(string));
            dta.Columns.Add("English", typeof(string));
            dta.Columns.Add("Vietnamese", typeof(string));

            dta.Rows.Add("1", "Dog", "Con Chó");
            dta.Rows.Add("2", "Cat", "Con Mèo");
            dta.Rows.Add("3", "Pig", "Con Heo");
            dta.Rows.Add("4", "Lion", "Sử Tử");
            dta.Rows.Add("5", "Tiger", "Con Hổ");
            dta.Rows.Add("6", "Bird", "Con Chim");
            dta.Rows.Add("7", "Horse", "Con Ngựa");
            dta.Rows.Add("8", "Goat", "Con Dê");
            dta.Rows.Add("9", "Rooster", "Gà Trống");
            dta.Rows.Add("10", "Hen", "Con Gà Mái");
            dta.Rows.Add("11", "Duck", "Con Vịt");
            dta.Rows.Add("12", "Cow", "Bò Sữa");
            dta.Rows.Add("13", "Sheep", "Con Cừu");
            dta.Rows.Add("14", "Donkey", "Con Lừa");
            dta.Rows.Add("15", "Elephant", "Con Voi");
            dataGridView1.DataSource = dta;
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 200;
        }
        public Learning()
        {
            InitializeComponent();
            add_dta();
        }
        
        private void Learning_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            play_click();
                this.Close();
        }
        private void exit_hover(object sender, EventArgs e)
        {
            pictureBox5.Size = new System.Drawing.Size(50, 41);
        }
        private void exit_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Size = new System.Drawing.Size(54, 45);
        }
        private void apple_hover(object sender, EventArgs e)
        {
            pictureBox1.Size = new System.Drawing.Size(55, 53);
        }
        private void apple_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Size = new System.Drawing.Size(59, 57);
        }
        private void job_hover(object sender, EventArgs e)
        {
            pictureBox3.Size = new System.Drawing.Size(55, 53);
        }
        private void job_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Size = new System.Drawing.Size(59, 57);
        }
        private void animal_hover(object sender, EventArgs e)
        {
            pictureBox2.Size = new System.Drawing.Size(55, 53);
        }
        private void animal_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Size = new System.Drawing.Size(59, 57);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            play_click();
            label_topic.Text = "Fruits";
            add_dta();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            play_click();
            label_topic.Text = "Animals";
            add_dtani();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            play_click();
            label_topic.Text = "Careers";
            add_dtj();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
