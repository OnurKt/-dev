using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] not;
        private void button1_Click(object sender, EventArgs e)
        {
            not = new int[Convert.ToInt32(textBox1.Text)];
        }
        int sayac = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            if (sayac<not.Length)
            {
                not[sayac] = Convert.ToInt32(textBox2.Text);
                sayac++;
                textBox2.Clear();
                textBox2.Focus();
                
            }
            if (sayac == not.Length)
            {
                textBox2.Enabled = false;
                MessageBox.Show("Eleman sayısına ulaşılmıştır");
            }
        }
        int toplam;
        private void button3_Click(object sender, EventArgs e)
        {
            for (int i=0;i<not.Length;i++)
            {
                toplam += not[i];
                listBox1.Items.Add(not[i]);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            double ort = toplam/not.Length;
            listBox2.Items.Add(ort); 
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox3.Items.Add(not.Length);
        }
        int min, max;

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < not.Length; i++)
            {
                if (max < not[i])
                    max = not[i];
                listBox5.Items.Add(max);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            min = not[0];
            max = not[0];
            for (int i = 1; i < not.Length; i++)
            {
                if (min > not[i])
                    min = not[i];
                listBox4.Items.Add(min);
                
            }
        }
    }
}
