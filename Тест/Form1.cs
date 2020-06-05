using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Тест
{
    public partial class Form1 : Form
    {
        int n = 0;
        int[] answer;

        public Form1()
        {
            InitializeComponent();
            answer = new int[6];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var bmp = new Bitmap(Тест.Properties.Resources.i1);
            pictureBox1.BackgroundImage = bmp;
        }
        public void show(int n)
        {
            int n1 = n + 1;
            label1.Text = "Вопрос №" + n1;
            switch (answer[n])
            {
                case 0:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = true;
                    radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    radioButton6.Checked = false;
                    break;
                case 1:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = true;
                    radioButton5.Checked = false;
                    radioButton6.Checked = false;
                    break;
                case 2:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton5.Checked = true;
                    radioButton6.Checked = false;
                    break;
                case 3:
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    radioButton6.Checked = false;
                    break;
                case 4:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton5.Checked = true;
                    radioButton6.Checked = false;
                    break;
                case 5:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton5.Checked = true;
                    radioButton6.Checked = false;
                    break;
                case 6:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = true;
                    radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    radioButton6.Checked = false;
                    break;
            }
            switch(n)
            {
                case 0:
                    pictureBox1.BackgroundImage = new Bitmap(Тест.Properties.Resources.i1);
                    break;
                case 1:
                    pictureBox1.BackgroundImage = new Bitmap(Тест.Properties.Resources.i2);
                    break;
                case 2:
                    pictureBox1.BackgroundImage = new Bitmap(Тест.Properties.Resources.i3);
                    break;
                case 3:
                    pictureBox1.BackgroundImage = new Bitmap(Тест.Properties.Resources.i4);
                    break;
                case 4:
                    pictureBox1.BackgroundImage = new Bitmap(Тест.Properties.Resources.i5);
                    break;
                case 5:
                    pictureBox1.BackgroundImage = new Bitmap(Тест.Properties.Resources.i6);
                    break;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            n++;
            if (n > 5) n = 5;
            show(n);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n--;
            if (n < 0) n = 0;
            show(n);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            answer[n] = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            answer[n] = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            answer[n] = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            answer[n] = 4;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            answer[n] = 5;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            answer[n] = 6;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int correct = 0;
            if (answer[0] == 1)
                correct++;
         
            if (answer[1] == 2)
                correct++;
          
            if (answer[2] == 3)
                correct++;
      
            if (answer[3] == 4)
                correct++;
     
            if (answer[4] == 5)
                correct++;
          
            if (answer[5] == 6)
                correct++;
            int prcnt = correct * 100 / 6;
            string msg;
            if (prcnt >= 75) msg = "Вы прошли тест";
            MessageBox.Show("Вы ответили на" + prcnt + "процентов вопросов верно.");
      

        }
    }
}
