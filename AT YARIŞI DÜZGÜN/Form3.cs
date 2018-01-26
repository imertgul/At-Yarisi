using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT_YARIŞI_DÜZGÜN
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int puan = 0;
        public int exp;
        public static int ons = 10;
        private void btnstart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            btnstart.Enabled = false;
            timer2.Enabled = true;
            lblpuan.Visible = true;
            lblsyac.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Top = button1.Top + rastgele.Next(25, 50);
            button2.Top = button2.Top + rastgele.Next(25, 50);
            button3.Top = button3.Top + rastgele.Next(25, 50);
            button4.Top = button4.Top + rastgele.Next(25, 50);
            button5.Top = button5.Top + rastgele.Next(25, 50);
            button6.Top = button6.Top + rastgele.Next(25, 50);
            button7.Top = button7.Top + rastgele.Next(25, 50);

            if (button1.Top + button1.Height >= label2.Top)
            {
                button1.Top = 0;
            }
            if (button2.Top + button2.Height >= label2.Top)
            {
                button2.Top = 0;
            }
            if (button3.Top + button3.Height >= label2.Top)
            {
                button3.Top = 0;
            }
            if (button4.Top + button4.Height >= label2.Top)
            {
                button4.Top = 0;
            }
            if (button5.Top + button5.Height >= label2.Top)
            {
                button5.Top = 0;
            }
            if (button6.Top + button6.Height >= label2.Top)
            {
                button6.Top = 0;
            }
            if (button7.Top + button7.Height >= label2.Top)
            {
                button7.Top = 0;
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int sayac = Convert.ToInt32(lblsyac.Text);
            sayac++;
            lblsyac.Text = sayac.ToString();
            if (sayac== 60)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                btnupdate.Enabled = true;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            btnupdate.Enabled = false;
            puan++;
            lblpuan.Text = puan.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Top = 0;
            puan++;
            lblpuan.Text = puan.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Top = 0;
            puan++;
            lblpuan.Text = puan.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Top = 0;
            puan++;
            lblpuan.Text = puan.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Top = 0;
            puan++;
            lblpuan.Text = puan.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Top = 0;
            puan++;
            lblpuan.Text = puan.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Top = 0;
            puan++;
            lblpuan.Text = puan.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Top = 0;
            puan++;
            lblpuan.Text = puan.ToString();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Şahbatur'u Geliştirdiniz");
            if (puan < 15)
            {
                MessageBox.Show("Şahbatur'u Geliştirtiremediniz");
            }
            if (puan >= 15 && puan <25 )
            {
                MessageBox.Show("Şahbatur'un gücü 5 arttı.");
                ons++;
                

            }
            if (puan >= 25)
            {
                MessageBox.Show("Şahbatur'un gücü 10 arttı");
                ons++;
                ons++;
                
            }

            this.Close();
        }
    }
}
