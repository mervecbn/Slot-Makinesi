using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slot_Makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (puan==1000)
            {
                Close();
            }
        }

       string[] resimler = Directory.GetFiles(@"C:\Users\ASUS\Desktop\img", "*.png");
        
       
        int jetonadet;
        int puan = 0;
        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            
            pictureBox1.ImageLocation= resimler[random.Next(0, resimler.Length)];
            pictureBox2.ImageLocation = resimler[random.Next(0, resimler.Length)];
            pictureBox3.ImageLocation = resimler[random.Next(0, resimler.Length)];
           


        }

        private void başla_Click(object sender, EventArgs e)
        {
            if (jetonadet > 0)
            {
                timer1.Start();
                durdur.Enabled = true;

            }
            else
            {
                MessageBox.Show("Jeton Atmalısınız!");
            }
        }

        private void durdur_Click(object sender, EventArgs e)
        {
            
            timer1.Stop();
            if (pictureBox1 == pictureBox2 && pictureBox2 ==pictureBox3 )
            {
                puan += 100;
                label1.Text = puan.ToString();
            }
            else if (pictureBox1 == pictureBox2 || pictureBox2 == pictureBox3 || pictureBox2 == pictureBox3)
            {
                puan += 50;
                label1.Text = puan.ToString();

            }
        }

        private void jetonat_Click(object sender, EventArgs e)
        {
            jetonadet += 1;
        }
    }
}
