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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int ons1 = Form3.ons;
        double bakiye = Form2.bakiye;
        Random rastgele = new Random();

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            menuStrip1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int sayac = Convert.ToInt32(label6.Text);
            sayac++;
            label6.Text = sayac.ToString();

            pictureBox1.Left = pictureBox1.Left + rastgele.Next (3, ons1);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(3, 10);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(3, 10);

            if(pictureBox1.Left > pictureBox2.Left +3 && pictureBox1.Left > pictureBox3.Left +3)
            {
                label7.Text = ("Şahbatur önde gidiyor!!!");
                button3.Visible = true;
                button4.Visible = false;
                button5.Visible = false;

            }
            if (pictureBox2.Left > pictureBox1.Left +3 && pictureBox2.Left > pictureBox3.Left+3)
            {
                label7.Text = ("Pakize Yarışı kazanmaya koşuyor");
                button3.Visible = false;
                button4.Visible = true;
                button5.Visible = false;
            }
            if (pictureBox3.Left > pictureBox2.Left + 3 && pictureBox3.Left > pictureBox1.Left +3)
            {
                label7.Text = ("Onur'dan beklenmedik bir atak ve şimdilik birinci sırada!!");
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = true;
            }


            if (pictureBox1.Width + pictureBox1.Left >= label5.Left)
            {
                timer1.Enabled = false;
                label7.Text = ("Şahbatur Yarışı Kazandı");
                
            }
            if (pictureBox2.Width + pictureBox2.Left >= label5.Left)
            {
                timer1.Enabled = false;
                label7.Text = ("Pakize Yarışı Kazandı");
            }
            if (pictureBox3.Width + pictureBox3.Left >= label5.Left)
            {
                timer1.Enabled = false;
                label7.Text = ("Onur Yarışı Kazandı");
            }
            button2.Visible = false;
            button6.Visible = true;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
        }

        private void şahbaturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 topvurma = new Form3();
            topvurma.Show();
        }

        private void atGeliştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 bahis = new Form2() ;
            bahis.Show();
        }

        private void atGeliştirToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            label6.Text = "0";
            pictureBox1.Left = 0;
            pictureBox2.Left = 0;
            pictureBox3.Left = 0;
            label7.Text = "Yeni Yarış Hazır!";
            button6.Visible = false;
            button2.Visible = true;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            timer1.Enabled = false;
            menuStrip1.Enabled = true;
        }

        private void pakizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 pakizegelstir = new Form5();
            pakizegelstir.Show();
        }
    }
}
