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
        //ContextMenuStrip m = new ContextMenuStrip();
        public int column;
        public Form3()
        {
            InitializeComponent();
            //Image img = null;
            //m.Items.Add("Задать фильтр", img, new EventHandler(ContextMenuClick));
            //m.Items.Add("Задать условия сортировки", img, new EventHandler(ContextMenuClick));
            //dataGridView1.ContextMenuStrip = m;
            var cards=Controller.openRegistry();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.ColumnCount = 12;

            //dataGridView1.RowCount = 2;

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



            //dataGridView1.Rows[0].Cells[0].Value = Convert.ToString("1");
            //dataGridView1.Rows[0].Cells[1].Value = Convert.ToString("10.10.2021");
            //dataGridView1.Rows[0].Cells[2].Value = Convert.ToString("-");
            //dataGridView1.Rows[0].Cells[3].Value = Convert.ToString("-");
            //dataGridView1.Rows[0].Cells[4].Value = Convert.ToString("-");
            //dataGridView1.Rows[0].Cells[5].Value = Convert.ToString("1");
            //dataGridView1.Rows[0].Cells[6].Value = Convert.ToString("5");
            //dataGridView1.Rows[0].Cells[7].Value = Convert.ToString("6");
            //dataGridView1.Rows[0].Cells[8].Value = Convert.ToString("11");
            //dataGridView1.Rows[0].Cells[9].Value = Convert.ToString("Tyumen");
            //dataGridView1.Rows[0].Cells[10].Value = Convert.ToString("9.10.2021");
            //dataGridView1.Rows[0].Cells[11].Value = Convert.ToString("Catch");


            //dataGridView1.Rows[1].Cells[0].Value = Convert.ToString("Акт 3");
            //dataGridView1.Rows[1].Cells[1].Value = Convert.ToString("г. Тула");
            //dataGridView1.Rows[1].Cells[2].Value = Convert.ToString("Отделение №1");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var card=Controller.openCard(1);
            //Form4 dlg = new Form4();
            //dlg.button1.Visible = false;
            //dlg.dataGridView1.Columns[3].Visible = false;
            ////dlg.label15.Visible = false;
            //dlg.button5.Visible = false;
            //dlg.textBox1.ReadOnly = true;
            //dlg.textBox2.ReadOnly = true;
            //dlg.textBox3.ReadOnly = true;
            //dlg.textBox4.ReadOnly = true;
            //dlg.textBox5.ReadOnly = true;
            //dlg.textBox6.ReadOnly = true;
            //dlg.textBox7.ReadOnly = true;
            //dlg.textBox8.ReadOnly = true;
            //dlg.textBox9.ReadOnly = true;
            //dlg.textBox10.ReadOnly = true;
            //dlg.textBox11.ReadOnly = true;
            //dlg.textBox12.ReadOnly = true;
            //dlg.button3.Visible = false;

            //int index = dataGridView1.CurrentRow.Index;
            //dlg.textBox1.Text = Convert.ToString(dataGridView1.Rows[index].Cells[0].Value);
            //dlg.textBox2.Text = Convert.ToString(dataGridView1.Rows[index].Cells[1].Value);
            //dlg.textBox3.Text = Convert.ToString(dataGridView1.Rows[index].Cells[2].Value);
            //dlg.textBox4.Text = Convert.ToString(dataGridView1.Rows[index].Cells[3].Value);
            //dlg.textBox5.Text = Convert.ToString(dataGridView1.Rows[index].Cells[4].Value);
            //dlg.textBox6.Text = Convert.ToString(dataGridView1.Rows[index].Cells[5].Value);
            //dlg.textBox7.Text = Convert.ToString(dataGridView1.Rows[index].Cells[6].Value);
            //dlg.textBox8.Text = Convert.ToString(dataGridView1.Rows[index].Cells[7].Value);
            //dlg.textBox9.Text = Convert.ToString(dataGridView1.Rows[index].Cells[8].Value);
            //dlg.textBox10.Text = Convert.ToString(dataGridView1.Rows[index].Cells[9].Value);
            //dlg.textBox11.Text = Convert.ToString(dataGridView1.Rows[index].Cells[10].Value);
            //dlg.textBox12.Text = Convert.ToString(dataGridView1.Rows[index].Cells[11].Value);
            //dlg.Show(this);
        }




        private void button2_Click_1(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            if (Controller.SelectActCardToUpdate(index))
            {
                Form4 form = new Form4();
                form.dataGridView1.Columns[3].Visible = true;
                form.button3.Visible = true;
                form.button5.Visible = false;
                form.index = index;
                form.textBox1.Text = Convert.ToString(dataGridView1.Rows[index].Cells[0].Value);
                form.textBox2.Text = Convert.ToString(dataGridView1.Rows[index].Cells[1].Value);
                form.textBox3.Text = Convert.ToString(dataGridView1.Rows[index].Cells[2].Value);
                form.textBox4.Text = Convert.ToString(dataGridView1.Rows[index].Cells[3].Value);
                form.textBox5.Text = Convert.ToString(dataGridView1.Rows[index].Cells[4].Value);
                form.textBox6.Text = Convert.ToString(dataGridView1.Rows[index].Cells[5].Value);
                form.textBox7.Text = Convert.ToString(dataGridView1.Rows[index].Cells[6].Value);
                form.textBox8.Text = Convert.ToString(dataGridView1.Rows[index].Cells[7].Value);
                form.textBox9.Text = Convert.ToString(dataGridView1.Rows[index].Cells[8].Value);
                form.textBox10.Text = Convert.ToString(dataGridView1.Rows[index].Cells[9].Value);
                form.textBox11.Text = Convert.ToString(dataGridView1.Rows[index].Cells[10].Value);
                form.textBox12.Text = Convert.ToString(dataGridView1.Rows[index].Cells[11].Value);
                form.Show(this);
            }
            else MessageBox.Show("Доступ отсутствует");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            if (Controller.SelectActCardToDelete(1))
            {
                DialogResult result=MessageBox.Show("Удалить выбранную карточку?", "Сообщение", MessageBoxButtons.YesNo);
                if (result==DialogResult.Yes) Controller.DeleteActCard(index);
            }
            else MessageBox.Show("Доступ отсутствует");

            //dataGridView1.Rows.RemoveAt(index);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (Controller.OpenNewActCard())
            {
                Form4 form = new Form4();
                form.dataGridView1.Columns[3].Visible = true;
                form.button3.Visible = false;
                form.button5.Visible = true;
                form.Show(this);
            }
            else MessageBox.Show("Доступ отсутствует");
        }

        private void Form3_Shown(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void ContextMenuClick(object sender, EventArgs e)
        {
            //if (sender.Equals(m.Items[0]))
            //{
            //    Form5 dlg = new Form5();
            //    dlg.label1.Text = dataGridView1.Columns[column].HeaderText;
            //    for (int i = 0; i < dataGridView1.RowCount; i++)
            //    {
            //        dlg.listBox1.Items.Add(dataGridView1.Rows[i].Cells[column].Value.ToString());
            //    }
            //    dlg.Show();
            //}
            //if (sender.Equals(m.Items[1])) MessageBox.Show("Задать условия сортировки");
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            column = e.ColumnIndex;
        }
    }
}
