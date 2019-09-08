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

    public partial class Easy_Game : Form
    {
        int i = 0;
        public Easy_Game()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void EasyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f2 = new Form1();
            f2.ShowDialog();
        }

        private void HardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Harder_Game f2 = new Harder_Game();
            f2.ShowDialog();
        }
        int sum = 0;

        
        private void BtnMakeQuestion_Click(object sender, EventArgs e)
        {
            i = 0;
            Random seed = new Random();
            int Number1 = seed.Next(10) + 1;
            label1.Text = Number1.ToString();
            pictureBox1.Image = Image.FromFile(Number1.ToString() + ".jpg");

            int Number2 = seed.Next(10) + 1;
            label2.Text = Number2.ToString();
            pictureBox2.Image = Image.FromFile(Number2.ToString() + ".jpg");

            

            sum = Number2 + Number1;
            textBox1.Text = "";
                textBox1.Enabled = true;
            timer1.Start();


            
        }
        int correctCount = 0;
        int totalcount = 0;
        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            int Answer = int.Parse(textBox1.Text);
            if (sum == Answer)
            {
                correctCount = correctCount + 1;
                MessageBox.Show("Well done!");
            }
            else
            {
                MessageBox.Show("Try again! The correct answer was " + sum);
            }
            totalcount = totalcount + 1;
            lblAttempt.Text = totalcount.ToString();
            lblCorrect.Text = correctCount.ToString();

            Random seed = new Random();
            int Number1 = seed.Next(10) + 1;
            label1.Text = Number1.ToString();
            pictureBox1.Image = Image.FromFile(Number1.ToString() + ".jpg");

            int Number2 = seed.Next(10) + 1;
            label2.Text = Number2.ToString();
            pictureBox2.Image = Image.FromFile(Number2.ToString() + ".jpg");



            sum = Number2 + Number1;
            textBox1.Text = "";
        }
        
        private void Easy_Game_Load(object sender, EventArgs e)
        {
            
            Random seed = new Random();
            int Number1 = seed.Next(10) + 1;
            label1.Text = Number1.ToString();
            pictureBox1.Image = Image.FromFile(Number1.ToString() + ".jpg");

            int Number2 = seed.Next(10) + 1;
            label2.Text = Number2.ToString();
            pictureBox2.Image = Image.FromFile(Number2.ToString() + ".jpg");



            sum = Number2 + Number1;
            textBox1.Text = "";
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            

        }

        private void Button2_Click(object sender, EventArgs e)
        {
           
        }
        
        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            i++;
            label7.Text = i.ToString();
            if (i == 45)
            {
                timer1.Stop();

                MessageBox.Show("Time is up!");
                textBox1.Enabled = false;
                label7.Text = "0";

            }
        }
    }
    }

