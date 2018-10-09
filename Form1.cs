using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formlarArasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
         Öncelikle form 1 deki ve form 2 deki tüm nesneler seçilir .
         sonra soldaki özellikler yerinden modifiers olan yer public yapılır.
         böylece haberleşe bilirler.
         
         */


        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
             frm2.label4.Text= textBox1.Text;

            double bir = Convert.ToDouble(textBox2.Text);
            double iki = Convert.ToDouble(textBox3.Text);
            double uc = Convert.ToDouble(textBox4.Text);
            double ortalama = (bir + iki + uc) / 3;
            
            frm2.label5.Text = Convert.ToString(ortalama);
            if (ortalama<50)
            {
                
                frm2.label6.Text = "Başarısız";
                frm2.BackColor = Color.Red;
            }
            else if (ortalama>=50)
            {
                frm2.label6.Text = "Başarılı";
                frm2.BackColor = Color.LightGreen;
            }
            frm2.ShowDialog();
        }

    }
}
