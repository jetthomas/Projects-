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
    public partial class Harder_Game : Form
    {
        public Harder_Game()
        {
            InitializeComponent();
            TImerForAnswer.Start();

        }
        int i = 0;
        int sum = 0;
        int correctCount = 0;
        int totalcount = 0;
        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f2 = new Form1();
            f2.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            i = 0;
            TImerForAnswer.Start();
            textBox1.Enabled = true;
            Random seed = new Random();
            int Number1 = seed.Next(10) + 1;
            label2.Text = Number1.ToString();
            pictureBox1.Image = Image.FromFile(Number1.ToString() + "Hard" + ".png");

            int Number2 = seed.Next(10) + 1;
            label3.Text = Number2.ToString();
            pictureBox2.Image = Image.FromFile(Number2.ToString() + "Hard" + ".png");

            int Number3 = seed.Next(10,20) + 1; //Limits the numbers to randomize 10 through to 20
            label4.Text = Number3.ToString();
            pictureBox3.Image = Image.FromFile("Hard"+ Number3.ToString() + ".png");
            sum = Number1 * Number2 + Number3;

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblAttempt_Click(object sender, EventArgs e)
        {

        }

        private void LblCorrect_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Harder_Game_Load(object sender, EventArgs e)
        {
            Random seed = new Random();
            int Number1 = seed.Next(10) + 1;
            label2.Text = Number1.ToString();
            pictureBox1.Image = Image.FromFile(Number1.ToString() + "Hard" + ".png");

            int Number2 = seed.Next(10) + 1;
            label3.Text = Number2.ToString();
            pictureBox2.Image = Image.FromFile(Number2.ToString() + "Hard" + ".png");

            int Number3 = seed.Next(10, 20) + 1; //Limits the numbers to randomize 10 through to 20
            label4.Text = Number3.ToString();
            pictureBox3.Image = Image.FromFile("Hard" + Number3.ToString() + ".png");
            sum = Number1 * Number2 + Number3;
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;
            label5.BackColor = System.Drawing.Color.Transparent;
            label6.BackColor = System.Drawing.Color.Transparent;
            lblEnterAnswer.BackColor = System.Drawing.Color.Transparent;
            label8.BackColor = System.Drawing.Color.Transparent;
            label9.BackColor = System.Drawing.Color.Transparent;
            lblAttempt.BackColor = System.Drawing.Color.Transparent;
            lblCorrect.BackColor = System.Drawing.Color.Transparent;
        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void BtnAnswer_Click(object sender, EventArgs e)
        {
            i = 0;
            TImerForAnswer.Start();

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
            label2.Text = Number1.ToString();
            pictureBox1.Image = Image.FromFile(Number1.ToString() + "Hard" + ".png");

            int Number2 = seed.Next(10) + 1;
            label3.Text = Number2.ToString();
            pictureBox2.Image = Image.FromFile(Number2.ToString() + "Hard" + ".png");

            int Number3 = seed.Next(10, 20) + 1; //Limits the numbers to randomize 10 through to 20
            label4.Text = Number3.ToString();
            pictureBox3.Image = Image.FromFile("Hard" + Number3.ToString() + ".png");
            sum = Number1 * Number2 + Number3;

        }

        private void EasyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Easy_Game f2 = new Easy_Game();
            f2.ShowDialog();
        }

        private void MediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f2 = new Form1();
            f2.ShowDialog();
        }

        private void TImerForAnswer_Tick(object sender, EventArgs e)
        {
            i++;
            label7.Text = i.ToString();
            if (i == 45)
            {
                TImerForAnswer.Stop();

                MessageBox.Show("Time is up!");
                textBox1.Enabled = false;
                label7.Text = "0";
                i = 0;
            }
        }
    }
}
