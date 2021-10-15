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
    public partial class Form3 : Form
    {
        public Form3()
        {
            Program.f1 = this;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.RowCount = 3;
            dataGridView1.ColumnCount = 12;
            //dataGridView1.Rows[0].Cells[0].Value = Convert.ToString("Номер МК");
            //dataGridView1.Rows[0].Cells[1].Value = Convert.ToString("Дата заключения МК");
            //dataGridView1.Rows[0].Cells[2].Value = Convert.ToString("Муниципальное образование");
            //dataGridView1.Rows[0].Cells[3].Value = Convert.ToString("ОМ СУ");
            //dataGridView1.Rows[0].Cells[4].Value = Convert.ToString("Исполнитель МК");
            //dataGridView1.Rows[0].Cells[5].Value = Convert.ToString("Номер акта отлова");
            //dataGridView1.Rows[0].Cells[6].Value = Convert.ToString("Количество отловленных собак");
            //dataGridView1.Rows[0].Cells[7].Value = Convert.ToString("Количество отловленных кошек");
            //dataGridView1.Rows[0].Cells[8].Value = Convert.ToString("Количество отловленных животных");
            //dataGridView1.Rows[0].Cells[9].Value = Convert.ToString("Населенный пункт");
            //dataGridView1.Rows[0].Cells[10].Value = Convert.ToString("Дата отлова");
            //dataGridView1.Rows[0].Cells[11].Value = Convert.ToString("Цель отлова");



            dataGridView1.Rows[0].Cells[0].Value = Convert.ToString("1");
            dataGridView1.Rows[0].Cells[1].Value = Convert.ToString("10.10.2021");
            dataGridView1.Rows[0].Cells[2].Value = Convert.ToString("-");
            dataGridView1.Rows[0].Cells[3].Value = Convert.ToString("-");
            dataGridView1.Rows[0].Cells[4].Value = Convert.ToString("-");
            dataGridView1.Rows[0].Cells[5].Value = Convert.ToString("1");
            dataGridView1.Rows[0].Cells[6].Value = Convert.ToString("5");
            dataGridView1.Rows[0].Cells[7].Value = Convert.ToString("6");
            dataGridView1.Rows[0].Cells[8].Value = Convert.ToString("11");
            dataGridView1.Rows[0].Cells[9].Value = Convert.ToString("Tyumen");
            dataGridView1.Rows[0].Cells[10].Value = Convert.ToString("9.10.2021");
            dataGridView1.Rows[0].Cells[11].Value = Convert.ToString("Catch");


            dataGridView1.Rows[1].Cells[0].Value = Convert.ToString("Акт 3");
            dataGridView1.Rows[1].Cells[1].Value = Convert.ToString("г. Тула");
            dataGridView1.Rows[1].Cells[2].Value = Convert.ToString("Отделение №1");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 dlg = new Form4();
            dlg.button1.Visible = false;
            dlg.label15.Visible = false;
            dlg.button5.Visible = false;
            dlg.textBox1.ReadOnly = true;
            dlg.textBox2.ReadOnly = true;
            dlg.textBox3.ReadOnly = true;
            dlg.textBox4.ReadOnly = true;
            dlg.textBox5.ReadOnly = true;
            dlg.textBox6.ReadOnly = true;
            dlg.textBox7.ReadOnly = true;
            dlg.textBox8.ReadOnly = true;
            dlg.textBox9.ReadOnly = true;
            dlg.textBox10.ReadOnly = true;
            dlg.textBox11.ReadOnly = true;
            dlg.textBox12.ReadOnly = true;
            dlg.button3.Visible = false;

            int index = dataGridView1.CurrentRow.Index;
            dlg.textBox1.Text = Convert.ToString(dataGridView1.Rows[index].Cells[0].Value);
            dlg.textBox2.Text = Convert.ToString(dataGridView1.Rows[index].Cells[1].Value);
            dlg.textBox3.Text = Convert.ToString(dataGridView1.Rows[index].Cells[2].Value);
            dlg.textBox4.Text = Convert.ToString(dataGridView1.Rows[index].Cells[3].Value);
            dlg.textBox5.Text = Convert.ToString(dataGridView1.Rows[index].Cells[4].Value);
            dlg.textBox6.Text = Convert.ToString(dataGridView1.Rows[index].Cells[5].Value);
            dlg.textBox7.Text = Convert.ToString(dataGridView1.Rows[index].Cells[6].Value);
            dlg.textBox8.Text = Convert.ToString(dataGridView1.Rows[index].Cells[7].Value);
            dlg.textBox9.Text = Convert.ToString(dataGridView1.Rows[index].Cells[8].Value);
            dlg.textBox10.Text = Convert.ToString(dataGridView1.Rows[index].Cells[9].Value);
            dlg.textBox11.Text = Convert.ToString(dataGridView1.Rows[index].Cells[10].Value);
            dlg.textBox12.Text = Convert.ToString(dataGridView1.Rows[index].Cells[11].Value);
            dlg.Show(this);
        }




        private void button2_Click_1(object sender, EventArgs e)
        {
            Form4 dlg = new Form4();
            dlg.button3.Visible = true;
            dlg.textBox13.Visible = false;
            dlg.button5.Visible = false;
            int index = dataGridView1.CurrentRow.Index;
            dlg.textBox13.Text = Convert.ToString(index);
            dlg.textBox1.Text = Convert.ToString(dataGridView1.Rows[index].Cells[0].Value);
            dlg.textBox2.Text = Convert.ToString(dataGridView1.Rows[index].Cells[1].Value);
            dlg.textBox3.Text = Convert.ToString(dataGridView1.Rows[index].Cells[2].Value);
            dlg.textBox4.Text = Convert.ToString(dataGridView1.Rows[index].Cells[3].Value);
            dlg.textBox5.Text = Convert.ToString(dataGridView1.Rows[index].Cells[4].Value);
            dlg.textBox6.Text = Convert.ToString(dataGridView1.Rows[index].Cells[5].Value);
            dlg.textBox7.Text = Convert.ToString(dataGridView1.Rows[index].Cells[6].Value);
            dlg.textBox8.Text = Convert.ToString(dataGridView1.Rows[index].Cells[7].Value);
            dlg.textBox9.Text = Convert.ToString(dataGridView1.Rows[index].Cells[8].Value);
            dlg.textBox10.Text = Convert.ToString(dataGridView1.Rows[index].Cells[9].Value);
            dlg.textBox11.Text = Convert.ToString(dataGridView1.Rows[index].Cells[10].Value);
            dlg.textBox12.Text = Convert.ToString(dataGridView1.Rows[index].Cells[11].Value);
            dlg.Show(this);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows.RemoveAt(index);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form4 dlg = new Form4();
            dlg.button3.Visible = false;
            dlg.button5.Visible = true;
            dlg.Show(this);
        }
    }
}
