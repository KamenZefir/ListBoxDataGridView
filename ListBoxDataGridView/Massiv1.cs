using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxDataGridView
{
    public partial class Massiv1 : Form
    {
        public Massiv1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fom1 = new Form1();
            fom1.Show();
            Hide();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int kol, summ = 0;
            kol = Convert.ToInt32(textBox1.Text);
            Random rnd = new Random();

            int[] Array = new int[kol];
            for (int i = 0; i < kol; i++)
            {
                Array[i] = rnd.Next(11);
                listBox1.Items.Add(String.Format("a[{0, 2 }] = {1, 5}", i+1, Array[i]));
            }

            if (radioButton1.Checked == true)
            {
                for (int i = 1; i < kol;)
                {
                    summ += Array[i];
                    i += 2;
                }
            }
                if (radioButton2.Checked == true)
                {
                    for (int i = 0; i < kol;)
                    {
                        summ += Array[i];
                        i += 2;
                    }
                }
                    if (radioButton3.Checked == true)
                    {
                        for (int i = 0; i < kol; i++)
                            summ += Array[i];
                    }
            textBox2.Text = Convert.ToString(summ);

        }
    }
}
