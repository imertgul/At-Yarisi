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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int sayac;

        private void Form5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'w')
            {
                lbltop.Top = lbltop.Top - 15;
            }
            if (e.KeyChar == 's')
            {
                lbltop.Top = lbltop.Top + 15;
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
        private void basla()
        {
            if (sayac == 9)
            {
                timer2.Enabled = true;
            }
            if (sayac == 16)
            {
                timer3.Enabled = true;
            }
            if (sayac == 500)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button1.Enabled = false;
            button1.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac = Convert.ToInt32(label6.Text);
            sayac++;
            label6.Text = sayac.ToString();
            label7.Left = label7.Left - rastgele.Next(20, 25);
            basla();
            if (label7.Left + label7.Width >= label5.Left)
            {
                
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label8.Left = label8.Left - rastgele.Next(15, 25);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label9.Left = label9.Left - rastgele.Next(15, 25);
        }
    }
}
