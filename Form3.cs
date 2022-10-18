using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace Bai_TH1
{

    public partial class Start : Form
    {
        int[] stack= { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
        int ques = 1;
        bool flag = true;
        int xx = 0;
        int type = 0;
        int point = 0;
        int[] top = new int[5];
        String[] date = new String[5];
        String[] linee = new String[30];
        
        public Start()
        {
            InitializeComponent();
        }
        public Start(bool flagg)
        {
            InitializeComponent();
        }
        public Start(bool flagg,int typee)
        {
            flag = flagg;
            type = typee;
            InitializeComponent();
        }
        private void Start_Load(object sender, EventArgs e)
        {
            if (flag == true)
                pictureBox8.Visible = false;
            else
                pictureBox8.Visible = true;
            ImageLoad();
        }
        void ImageLoad()
        {
            label5.Text = ques.ToString();
            do
            {
                Random rnd = new Random();
                xx = rnd.Next(1, 16);
            } while (stack[xx-1]!=0);
            stack[xx-1] = 1;
            ques++;
            String x = System.IO.Directory.GetCurrentDirectory();
            if (type == 1)
            {
                x = x + "\\Fruits\\" + xx + ".png";
            }
            else if (type == 2)
                x = x + "\\Careers\\" + xx + ".png";
            else
                x = x + "\\Animal\\" + xx + ".png" ;
            
            pictureBox1.Image = Image.FromFile(x);
        }
        String getstring(int xx, int type)
        {
            String[,] Fruits = {
                { "1", "Apple", "Quả Táo" },
                { "2", "Pineapple", "Quả Dứa" },
                { "3", "Coconut", "Quả Dừa" },
                { "4", "Lemon", "Quả Chanh" },
                { "5", "Orange", "Quả Cam" },
                { "6", "Grapes", "Chùm Nho" },
                { "7", "Water Melon", "Dưa Hấu" },
                { "8", "Mango", "Quả Xoài" },
                { "9", "Banana", "Quả Chuối" },
                { "10", "Pear", "Quả Lê" },
                { "11", "Peach", "Quả Đào" },
                { "12", "Avocado", "Quả Bơ" },
                { "13", "Strawberry", "Quả Dâu Tây" },
                { "14", "Payaya", "Quả Đu Đủ" },
                { "15", "Durian", "Quả Sầu Riêng" } };

            String[,] Careers =
            {
            {"1", "Doctor", "Bác Sĩ" },
            {"2", "Engineer", "Kĩ Sư" },
            {"3", "Teacher", "Giáo Viên" },
            {"4", "Singer", "Ca Sĩ" },
            {"5", "Artist", "Nghệ Sĩ" },
            {"6", "Policeman", "Cảnh Sát" },
            {"7", "Pilot", "Phi Công" },
            {"8", "Cook", "Đầu Bếp" },
            {"9", "Dentist", "Nha Sĩ" },
            {"10", "Fire Fighter", "C.Sát Cứu Hỏa" },
            {"11", "Astronaut", "Phi Hành Gia" },
            {"12", "Nurse", "Y Tá" },
            {"13", "Cashies", "Thu Ngân" },
            {"14", "Waiter", "Phục Vụ" },
            {"15", "Baker", "Thợ Làm Bánh" }
        };

            String[,] Animal=
             {{ "1", "Dog", "Con Chó"}
            ,{ "2", "Cat", "Con Mèo"}
            ,{ "3", "Pig", "Con Heo"}
            ,{ "4", "Lion", "Sử Tử"}
            ,{ "5", "Tiger", "Con Hổ"}
            ,{ "6", "Bird", "Con Chim"}
            ,{ "7", "Horse", "Con Ngựa"}
            ,{ "8", "Goat", "Con Dê"}
            ,{ "9", "Rooster", "Gà Trống"}
            ,{ "10", "Hen", "Con Gà Mái"}
            ,{ "11", "Duck", "Con Vịt"}
            ,{ "12", "Cow", "Bò Sữa"}
            ,{ "13", "Sheep", "Con Cừu"}
            ,{ "14", "Donkey", "Con Lừa"}
            ,{ "15", "Elephant", "Con Voi"} };
            if (type == 1)
            {
                return Fruits[xx-1, 1];
            }
            else if (type == 2)
               return Careers[xx - 1, 1];
            else
               return Animal[xx - 1, 1];
        }
        bool checktrue(int xx, string s,int type)
        {
            String ss = getstring(xx, type);
            if (String.Equals(s.ToUpper(),ss.ToUpper()))
                return true;
            else
                return false;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
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
        void play_correct()
        {
            if (flag == true)
            {
                SoundPlayer audio = new SoundPlayer(Properties.Resources.Correct); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
                audio.Play();
            }
        }
        void play_lose()
        {
            if (flag == true)
            {
                SoundPlayer audio = new SoundPlayer(Properties.Resources.Lose); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
                audio.Play();
            }
        }
        void play_wrong()
        {
            if (flag == true)
            {
                SoundPlayer audio = new SoundPlayer(Properties.Resources.Wrong); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
                audio.Play();
            }
        }
        void play_end()
        {
            if (flag == true)
            {
                SoundPlayer audio = new SoundPlayer(Properties.Resources.RickRoll); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
                audio.Play();
            }
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

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            pictureBox8.Visible = true;
            if (flag == true)
                flag = false;
            else
                flag = true;
            play_click();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            play_click();
            string message = "Do you want to close game?";
            string title = "Close Game";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)//result
        {
            play_click();
            String s = textBox1.Text.ToString();
            if (checktrue(xx, s, type))
            {
                play_correct();
                point = point + 2;
            }
            else
            {
                play_wrong();
            }
            label6.Text = point.ToString();
            label4.Text = (point/2).ToString() + "/" + (ques-1).ToString();
            textBox1.ResetText();
            if(ques<=5)
            {
                ImageLoad();
            }
            else
            {
                
                read_file();
                if (checktop(point) != -1)
                {
                    play_end();
                    topdown(checktop(point));
                    top[checktop(point)] = point;
                    date[checktop(point)] = DateTime.Now.ToString();
                    DialogResult result = MessageBox.Show("Congratulation!! You got the top " + (checktop(point) + 1).ToString() + " ranked");
                }
                else
                {
                    play_lose();
                    DialogResult result1 = MessageBox.Show("Don't give up, You should study more!!");
                }
                write_file();
                this.Close();
            }
            
        }
        int to_int(String x)
        {
            int rs = 0;
            int i = 0;
            while (i<x.Length)
            {
                rs = rs * 10 + (int)x[i]-48;
                i++;
            }
            return rs;
        }
        void read_file()
        {
            const Int32 BufferSize = 128;
            using (var fileStream = File.OpenRead(Properties.Resources.Ranking))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
            {
                String line;
                int i = 0;
                int z = 1;
                //0,1,2
                while ( z<=30)
                {
                    line = streamReader.ReadLine();
                    linee[i] = line;
                    i++;
                    z++;
                }
                

                top[0] = to_int("0"+linee[0 + 5 * (type-1)]);
                top[1] = to_int("0" + linee[1 + 5 * (type-1)]);
                top[2] = to_int("0" + linee[2 + 5 * (type-1)]);
                top[3] = to_int("0" + linee[3 + 5 * (type-1)]);
                top[4] = to_int("0" + linee[4 + 5 * (type-1)]);

                date[0] = linee[0 + 5 * (type - 1) + 15];
                date[1] = linee[1 + 5 * (type - 1) + 15];
                date[2] = linee[2 + 5 * (type - 1) + 15];
                date[3] = linee[3 + 5 * (type - 1) + 15];
                date[4] = linee[4 + 5 * (type - 1) + 15];
            }
        }
        void write_file()
        {
            using (var fileStream = File.OpenWrite(Properties.Resources.Ranking))
            using (var fw = new StreamWriter(fileStream))
            {
                int i = 0;
                int z = 0;
                int c = 0;
                while (i<30)
                {
                    if (((type - 1) * 5) <= i && i < ((type - 1) * 5 + 5))
                    {
                        fw.WriteLine(top[z]);
                        z++;
                    }
                    else if (((type - 1) * 5 + 15) <= i && i < ((type - 1) * 5 + 5 + 15))
                    {
                        fw.WriteLine(date[c]);
                        c++;
                    }
                    else
                    fw.WriteLine(linee[i]);
                    i++;
                }
            }
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2_Click(this, e);
            }
        }
        int checktop(int x)
        {
            for(int i=0;i<5;i++)
            {
                if(top[i]<=x)
                {
                    return i;
                }
            }
            return -1;
        }
        void topdown(int x)
        {
            for (int i=4;i>x;i--)
            {
                top[i] = top[i-1];
                date[i] = date[i-1];
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
