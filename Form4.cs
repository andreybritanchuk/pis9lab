using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pis
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(textBox13.Text);
            Program.f1.dataGridView1.Rows[index].Cells[0].Value = textBox1.Text;
            Program.f1.dataGridView1.Rows[index].Cells[1].Value = textBox2.Text;
            Program.f1.dataGridView1.Rows[index].Cells[2].Value = textBox3.Text;
            Program.f1.dataGridView1.Rows[index].Cells[3].Value = textBox4.Text;
            Program.f1.dataGridView1.Rows[index].Cells[4].Value = textBox5.Text;
            Program.f1.dataGridView1.Rows[index].Cells[5].Value = textBox6.Text;
            Program.f1.dataGridView1.Rows[index].Cells[6].Value = textBox7.Text;
            Program.f1.dataGridView1.Rows[index].Cells[7].Value = textBox8.Text;
            Program.f1.dataGridView1.Rows[index].Cells[8].Value = textBox9.Text;
            Program.f1.dataGridView1.Rows[index].Cells[9].Value = textBox10.Text;
            Program.f1.dataGridView1.Rows[index].Cells[10].Value = textBox11.Text;
            Program.f1.dataGridView1.Rows[index].Cells[11].Value = textBox12.Text;
            if (MessageBox.Show("Изменения сохранены") == DialogResult.OK)
            {
                Close();
            }
        }


        private void button5_Click_1(object sender, EventArgs e)
        {
            Program.f1.dataGridView1.Rows.Add(
            textBox1.Text,
            textBox2.Text,
            textBox3.Text,
            textBox4.Text,
            textBox5.Text,
            textBox6.Text,
            textBox7.Text,
            textBox8.Text,
            textBox9.Text,
            textBox10.Text,
            textBox11.Text,
            textBox12.Text
            );
            if (MessageBox.Show("Изменения сохранены") == DialogResult.OK)
            {
                Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog OPF = new OpenFileDialog();
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(OPF.FileName);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
