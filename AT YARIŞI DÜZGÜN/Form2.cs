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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int ons3 = Form3.ons;
        public static double bakiye = 1000;
        double oran, yatır;
        double kar;
        public static double idda;

        private void Form2_Load(object sender, EventArgs e)
        {
            lblbakiye.Text = bakiye.ToString();
            if (ons3== 10)
            {
                label4.Text = "1,50";
            }
            if (ons3 > 10 && ons3 <= 15)
            {
                label4.Text = "1,45";
            }
            if (ons3 > 15 && ons3 <= 20)
            {
                label4.Text = "1,325";
            }
            if (ons3 > 20 && ons3 <= 25)
            {
                label4.Text = "1,225";
            }
            if (ons3 > 25 && ons3 <= 30)
            {
                label4.Text = "1,070";
            }
            if (ons3 > 30)
            {
                label4.Text = "1,020";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Şahbatur")
            {
                lbloran.Text = label4.Text;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if ( textBox1.Text != "")
            {
                yatır = Convert.ToDouble(textBox1.Text);
                oran = Convert.ToDouble(lbloran.Text);
                kar = oran * yatır;
                lblkar.Text = kar.ToString();
            }
            else
            {
                lblkar.Text = "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yatır = Convert.ToDouble(textBox1.Text);
            bakiye = bakiye - yatır;
            idda = bakiye + kar;
        }
    }
}
// comboboxtaki değerleri public tanımla. Hangisi seçiliyse form 1 deki karşılığı geldiğinda idda yı göstersim iddayı yeni bakiye yapsın. Bahis tutmazsa Bakiyeyi göstersin.