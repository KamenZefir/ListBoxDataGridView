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
    public partial class Massiv2 : Form
    {
        int[,] array = new int[0, 0];

        public Massiv2()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fom1 = new Form1();
            fom1.Show();
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i, j;
            int rows = Convert.ToInt32(textBox1.Text);
            int columns = Convert.ToInt32(textBox2.Text);
            array = new int[rows, columns];
            dataGridView1.ColumnCount = Convert.ToInt32(textBox2.Text) + 1;
            dataGridView1.RowCount = Convert.ToInt32(textBox1.Text);
            for (j = 0; j < columns; j++) dataGridView1.Columns[j].Width = 30;
            dataGridView1.Columns[columns].Width = 30;


            Random rand = new Random();
            for (i = 0; i < rows; i++)
            {
                dataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();
                for (j = 0; j < columns; j++)
                {
                    array[i, j] = rand.Next(-10, 10);
                    dataGridView1.Columns[j].HeaderCell.Value = (j + 1).ToString();
                    dataGridView1[j, i].Value = array[i, j].ToString();
                }
            }

        }

        public void button3_Click(object sender, EventArgs e)
        {
            int i, j, min;
            int rows = Convert.ToInt32(textBox1.Text);
            int columns = Convert.ToInt32(textBox2.Text);
            dataGridView1.ColumnCount = Convert.ToInt32(textBox2.Text) + 1;
            dataGridView1.Columns[columns].HeaderCell.Value = "MIN";
            dataGridView1.RowCount = Convert.ToInt32(textBox1.Text);
            for (j = 0; j < columns; j++) dataGridView1.Columns[j].Width = 30;
            dataGridView1.Columns[columns].Width = 30;


            for (i = 0; i < rows; i++)
            {
                min = array[i, 0];
                for (j = 1; j < columns; j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                    }
                }
                dataGridView1[columns, i].Value = min.ToString();
            }
        }

        private void Massiv2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i, j, sch, proverka;
            int rows = Convert.ToInt32(textBox1.Text);
            int columns = Convert.ToInt32(textBox2.Text);
            dataGridView1.ColumnCount = Convert.ToInt32(textBox2.Text) + 1;
            dataGridView1.Columns[columns].HeaderCell.Value = "Sch";
            dataGridView1.RowCount = Convert.ToInt32(textBox1.Text);
            for (j = 0; j < columns; j++) dataGridView1.Columns[j].Width = 30;
            dataGridView1.Columns[columns].Width = 40;
            sch = 0;

            for (i = 0; i < rows; i++)
            {
                for (j = 1; j < columns; j++)
                {
                    proverka = array[i, j] % 2;
                    if (proverka == 0)
                    {
                        sch++;
                    }
                }
                dataGridView1[columns, i].Value = sch.ToString();
            }
        }
    }
}
