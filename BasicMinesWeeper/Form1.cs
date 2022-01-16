using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicMinesWeeper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void btnStart_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            lblBoom.Text = "0";
            lblScore.Text = "0";
            Random rnd = new Random();
            int mine1 = rnd.Next(1, 10);
            int mine2 = rnd.Next(11, 18);
            int mine3 = rnd.Next(19, 25);


            for (int i = 1; i < 26; i++)
            {
                Button btnTemp = new Button();

                btnTemp.Name = "btnTemp" + i.ToString();
                btnTemp.Size = new System.Drawing.Size(40, 40);
                btnTemp.Text = i.ToString();
                btnTemp.UseVisualStyleBackColor = true;


                if (mine1 == i || mine2 == i || mine3 == i)
                    btnTemp.Tag = true;
                else
                    btnTemp.Tag = false;


                btnTemp.Click += BtnTemp_Click;
                flowLayoutPanel1.Controls.Add(btnTemp);
            }
        }

        private void BtnTemp_Click(object sender, EventArgs e)
        {
            Button btnTemp = (Button)sender;
            bool tag = (bool)btnTemp.Tag;

            if(tag)
            {
                btnTemp.BackColor = Color.Red;
                int boom = int.Parse(lblBoom.Text);
                boom++;
                lblBoom.Text = boom.ToString();
                btnTemp.Enabled = false;

                if (boom == 3)
                    MessageBox.Show("Ydk fih");
            }
            else
            {
                btnTemp.BackColor = Color.Green;
                int score = int.Parse(lblScore.Text);
                score++;
                lblScore.Text = score.ToString();
                btnTemp.Enabled = false;
            }
        }
    }
}
