using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Porject_1
{
    
    public partial class Form1 : Form
    {
        int i = 0;
        public Form1()
        {
            InitializeComponent();
            TimerforQuestion.Start();
        }
        int sum = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            i = 0;
            TimerforQuestion.Start();
            textBox1.Enabled = true;
            Random seed = new Random();
            int Number1 = seed.Next(10) + 1;
            lblPic1.Text = Number1.ToString();
            pictureBox1.Image = Image.FromFile(Number1.ToString() + ".jpg");

            int Number2 = seed.Next(10) + 1;
            lblPic2.Text = Number2.ToString();
            pictureBox2.Image = Image.FromFile(Number2.ToString() + ".jpg");

            int Number3 = seed.Next(10) + 1;
            lblPic3.Text = Number3.ToString();
            pictureBox3.Image = Image.FromFile(Number3.ToString() + ".jpg");

            sum = Number3 * Number2 + Number1;
            textBox1.Text = "";
           
            


        }
        int crrectCount = 0, totalCount = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

            Random seed = new Random();
            int Number1 = seed.Next(10) + 1;
            lblPic1.Text = Number1.ToString();
            pictureBox1.Image = Image.FromFile(Number1.ToString() + ".jpg");

            int Number2 = seed.Next(10) + 1;
            lblPic2.Text = Number2.ToString();
            pictureBox2.Image = Image.FromFile(Number2.ToString() + ".jpg");

            int Number3 = seed.Next(10) + 1;
            lblPic3.Text = Number3.ToString();
            pictureBox3.Image = Image.FromFile(Number3.ToString() + ".jpg");

            sum = Number3 + Number2 + Number1;
            textBox1.Text = "";

            lblPic1.BackColor = System.Drawing.Color.Transparent;
            lblPic2.BackColor = System.Drawing.Color.Transparent;
            lblPic3.BackColor = System.Drawing.Color.Transparent;
            label1.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            lblTry.BackColor = System.Drawing.Color.Transparent;
            lblCorrect.BackColor = System.Drawing.Color.Transparent;
            label6.BackColor = System.Drawing.Color.Transparent;
            label5.BackColor = System.Drawing.Color.Transparent;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Harder_Game f2 = new Harder_Game();
            f2.ShowDialog();

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Easy_Game f2 = new Easy_Game();
            f2.ShowDialog();
        }

        private void EasyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Easy_Game f2 = new Easy_Game();
            f2.ShowDialog();
        }

        private void HardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Harder_Game f2 = new Harder_Game();
            f2.ShowDialog();
        }

        private void TimerforQuestion_Tick(object sender, EventArgs e)
        {
            i++;
            label7.Text = i.ToString();
            if (i == 90)
            {
                
                TimerforQuestion.Stop();
                MessageBox.Show("The Time is up");
                textBox1.Enabled = false;
                label7.Text = "0";

            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            TimerforQuestion.Stop();
            i = 0;
            
            int Answer = int.Parse(textBox1.Text);

            if (sum == Answer)
            {
                crrectCount = crrectCount + 1;
                MessageBox.Show("Well done!");
            }
            else
            {
                MessageBox.Show("Try again! The correct answer was " + sum);
            }

            totalCount = totalCount + 1;
            lblTry.Text = totalCount.ToString();
            lblCorrect.Text = crrectCount.ToString();
            Random seed = new Random();
            int Number1 = seed.Next(10) + 1;
            lblPic1.Text = Number1.ToString();
            pictureBox1.Image = Image.FromFile(Number1.ToString() + ".jpg");

            int Number2 = seed.Next(10) + 1;
            lblPic2.Text = Number2.ToString();
            pictureBox2.Image = Image.FromFile(Number2.ToString() + ".jpg");

            int Number3 = seed.Next(10) + 1;
            lblPic3.Text = Number3.ToString();
            pictureBox3.Image = Image.FromFile(Number3.ToString() + ".jpg");
            sum = Number1 + Number2 + Number3;
            textBox1.Text = "";
            textBox1.Focus();
            sum = Number3 + Number2 + Number1;

            TimerforQuestion.Start();


        }
    } 
    }

