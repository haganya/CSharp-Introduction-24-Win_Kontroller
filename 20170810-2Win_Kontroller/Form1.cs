using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20170810_2Win_Kontroller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // form 1 oluşturulurken yapılacak olan işlemler buraya yazılırç
            InitializeComponent();

            numericUpDown1.Maximum = decimal.MaxValue; //numericupdown varsayılan olarak 0-100 arasında değer almaktadır. Minimum ve Maximum değerleriyle oynayarabiliriz.
            numericUpDown1.Minimum = decimal.MinValue;

            numericUpDown2.Maximum = decimal.MaxValue;
            numericUpDown2.Minimum = decimal.MinValue;

        }

        private void button1_Click(object sender, EventArgs e)
        {    
            decimal s1=0, s2=0, sonuc=0;
            s1 = numericUpDown1.Value;
            s2 = numericUpDown2.Value;

            switch (comboBox1.Text)
            {
                case "+": sonuc = s1 + s2; break;
                case "-": sonuc = s1 - s2; break;
                case "*": sonuc = s1 * s2; break;
                case "/": sonuc = s1 / s2; break;
                case "%": sonuc = s1 % s2; break;
            }

            textBox1.Text = sonuc.ToString();
        }
        
    }
}
