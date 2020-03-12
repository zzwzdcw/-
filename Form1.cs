using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 算数练习
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int score = 0;
        String scs;
        int sn = 0;
        int i = 0;
        bool answer = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("答案怎么会是空的呢");
                textBox1.Text = "250";
            }
            switch (sn)
            {
                case 0:
                    if (int.Parse(textBox1.Text) == int.Parse(label1.Text) + int.Parse(label3.Text))
                    {
                        answer = true;
                    }
                    else 
                    {
                        answer = false;
                    }
                        
                    break;
                case 1:

                    if (int.Parse(textBox1.Text) == int.Parse(label1.Text) - int.Parse(label3.Text))
                    {
                        answer = true;
                    }
                    else
                    {
                        answer = false;
                    }

                    break;
                case 2:
                    if (int.Parse(textBox1.Text) == int.Parse(label1.Text) * int.Parse(label3.Text))
                    {
                        answer = true;
                    }
                    else
                    {
                        answer = false;
                    }

                    break;
                case 3:
                    if (int.Parse(textBox1.Text) == int.Parse(label1.Text) / int.Parse(label3.Text))
                    {
                        answer = true;
                    }
                    else
                    {
                        answer = false;
                    }

                    break;
            }
            Random random = new Random(++i);
            int N1 = random.Next(0, 51);
            Random Random = new Random(++i);
            int N2 = Random.Next(0, 51);
            string[] arrayA = { "+", "-", "*", "/" };
            Random S = new Random(++i);
            sn = Random.Next(0, 4);
            if (answer)
            {
              //  pictureBox1.Image = Image.FromFile(Application.StartupPath + "/../../img/happy.png");
                pictureBox1.Image = imageList1.Images[0];
                label1.Text = N1.ToString();
                label2.Text = arrayA[sn];
                label3.Text = N2.ToString();
                score++;
                label6.Text = Convert.ToString(score);
                label7.Text = "√";
            }
            else 
            {
           //     pictureBox1.Image = Image.FromFile(Application.StartupPath + "/../..//img/sad.png");
                pictureBox1.Image = imageList1.Images[1];
                label1.Text = N1.ToString();
                label2.Text = arrayA[sn];
                label3.Text = N2.ToString();
                label7.Text = "×";
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
