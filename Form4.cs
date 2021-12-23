using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace pis
{
    public partial class Form4 : Form
    {
        public int index;
        public Form4()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(GetValues("municipal_contract", "id_mc"));
        }

        public string[] GetValues(string tableName, string columnName)
        {
            Controller.connect.Open();

            string sql1 = @"select " + columnName + " from " + tableName;
            SqlCommand command = Controller.connect.CreateCommand();
            command.CommandText = sql1;
            SqlDataReader result = command.ExecuteReader();
            var data = new List<string>();
            while (result.Read())
            {
                data.Add(result.GetValue(0).ToString());
            }

            Controller.connect.Close();

            return data.ToArray();
        }

        private void button3_Click(object sender, EventArgs e) //изменение
        {
            var idCard = Convert.ToInt32(textBox6.Text);
            var actCardData = new List<string>();
            actCardData.Add(comboBox1.Text);
            actCardData.Add(textBox2.Text);
            actCardData.Add(textBox3.Text);
            actCardData.Add(textBox4.Text);
            actCardData.Add(textBox5.Text);
            actCardData.Add(textBox6.Text);
            actCardData.Add(textBox7.Text);
            actCardData.Add(textBox8.Text);
            actCardData.Add(textBox9.Text);
            actCardData.Add(textBox10.Text);
            actCardData.Add(dateTimePicker11.Text);
            actCardData.Add(textBox12.Text);
            Controller.UpdateActCard(idCard, actCardData.ToArray());
            if (MessageBox.Show("Изменения сохранены") == DialogResult.OK)
            {
                Close();
            }
        }


        private void button5_Click_1(object sender, EventArgs e) //добавление
        {
            var idCard = Convert.ToInt32(textBox6.Text);

            var actCardData = new List<string>();
            actCardData.Add(comboBox1.Text);
            actCardData.Add(textBox2.Text);
            actCardData.Add(textBox3.Text);
            actCardData.Add(textBox4.Text);
            actCardData.Add(textBox5.Text);
            actCardData.Add(textBox6.Text);
            actCardData.Add(textBox7.Text);
            actCardData.Add(textBox8.Text);
            actCardData.Add(textBox9.Text);
            actCardData.Add(textBox10.Text);
            actCardData.Add(dateTimePicker11.Text);
            actCardData.Add(textBox12.Text);
            Controller.AddActCard(actCardData.ToArray());

            Controller.connect.Open();

            if (CheckId(idCard))
            {
                Controller.AddActCard(actCardData.ToArray());
                if (MessageBox.Show("Карточка добавлена") == DialogResult.OK)
                {
                    Close();
                }
            }
            else MessageBox.Show("Акт с таким номером уже существует");

            Controller.connect.Close();
        }

        public bool CheckId(int idCard)
        {
            string sql1 = @"select* from act_trapping where id_act="+idCard;
            SqlCommand command = Controller.connect.CreateCommand();
            command.CommandText = sql1;
            SqlDataReader result = command.ExecuteReader();
            if (result.HasRows) return false;
            return true;
        }

        private void button1_Click_1(object sender, EventArgs e) //загрузить файлы
        {
            var idCard = Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value);
            Controller.AddFile(idCard, new byte[0]);
        }

        private void button4_Click_1(object sender, EventArgs e) //закрыть
        {
            Close();
        }

        private void Form4_Shown(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            label13.Focus();
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.Columns[e.ColumnIndex].Index;
            if (i != 1 && i != 3)
            {
                dataGridView1.Cursor = Cursors.Default;
            }
            else
            {
                dataGridView1.Cursor = Cursors.Hand;
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 2;

            if (!button5.Visible) // просмотр или изменение
            {
                dataGridView1.Rows[0].Cells[0].Value = "0";
                dataGridView1.Rows[0].Cells[1].Value = "Файл1";
                dataGridView1.Rows[0].Cells[2].Value = dateTimePicker11.Value.ToShortDateString();
                dataGridView1.Rows[1].Cells[0].Value = "0";
                dataGridView1.Rows[1].Cells[1].Value = "Файл2";
                dataGridView1.Rows[1].Cells[2].Value = dateTimePicker11.Value.ToShortDateString();

                button2.Visible = true;
            }

            if (button3.Visible) //изменение
            {
                dataGridView1.Rows[0].Cells[3].Value = "Удалить";
                dataGridView1.Rows[1].Cells[3].Value = "Удалить";
                dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.Red;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Controller.connect.Open();
            string sql1 = @"select* from mcTable where id_mc="+comboBox1.SelectedItem.ToString();
            SqlCommand command = Controller.connect.CreateCommand();
            command.CommandText = sql1;
            SqlDataReader result = command.ExecuteReader();
            var data = new List<string>();
            while (result.Read())
            {
                textBox2.Text = Convert.ToDateTime(result.GetValue(1)).ToShortDateString();
                textBox3.Text = result.GetValue(2).ToString();
                textBox4.Text = result.GetValue(3).ToString();
                textBox5.Text = result.GetValue(4).ToString();
            }
            Controller.connect.Close();
        }

        private void button2_Click(object sender, EventArgs e) //экспорт в Word
        {
            var idCard = Convert.ToInt32(textBox6.Text);
            Controller.ExportWord(idCard, "");
        }
    }
}
