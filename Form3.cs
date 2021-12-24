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
        public Form2 form2;
        public Form3(Form2 form)
        {
            InitializeComponent();
            form2 = form;
        }

        private void Form3_Load(object sender, EventArgs e) //открытие реестра
        {
            openRegistry(this);
        }

        public static void openRegistry(Form3 form)
        {
            form.dataGridView1.Rows.Clear();
            var cards = Controller.openRegistry();
            foreach (var card in cards)
            {
                form.dataGridView1.Rows.Add(card.idMC, card.datemc.ToShortDateString(), card.municipality,
                    card.localGovernmentBody, card.executor, card.idCard, card.numberdog,
                    card.numbercat, card.numberanimal, card.locality,
                    card.date_trapping.ToShortDateString(), card.purpose);
            }
        }

        private void button1_Click(object sender, EventArgs e) //просмотреть карточку
        {
            var idCard = Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value);
            var card=Controller.openCard(idCard);
            Form4 form = new Form4(this);
            form.comboBox1.Text = card.idMC.ToString();
            form.textBox2.Text = card.datemc.ToShortDateString();
            form.textBox3.Text = card.municipality.ToString();
            form.textBox4.Text = card.localGovernmentBody.ToString();
            form.textBox5.Text = card.executor.ToString();
            form.textBox6.Text = card.idCard.ToString();
            form.textBox7.Text = card.numberdog.ToString();
            form.textBox8.Text = card.numbercat.ToString();
            form.textBox9.Text = card.numberanimal.ToString();
            form.textBox10.Text = card.locality.ToString();
            form.dateTimePicker11.Value = card.date_trapping;
            form.dateTimePicker11.Text = card.date_trapping.ToShortDateString();
            form.textBox12.Text = card.purpose.ToString();
            form.button1.Visible = false;
            form.button2.Visible = true;
            form.button3.Visible = false;
            form.button5.Visible = false;
            form.Show();
        }

        private void button2_Click_1(object sender, EventArgs e) //изменить карточку
        {
            var  idCard= Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value);
            if (Controller.SelectActCardToUpdate(idCard))
            {
                var card = Controller.openCard(idCard);
                Form4 form = new Form4(this);
                form.comboBox1.Text = card.idMC.ToString();
                form.textBox2.Text = card.datemc.ToShortDateString();
                form.textBox3.Text = card.municipality.ToString();
                form.textBox4.Text = card.localGovernmentBody.ToString();
                form.textBox5.Text = card.executor.ToString();
                form.textBox6.Text = card.idCard.ToString();
                form.textBox7.Text = card.numberdog.ToString();
                form.textBox8.Text = card.numbercat.ToString();
                form.textBox9.Text = card.numberanimal.ToString();
                form.textBox10.Text = card.locality.ToString();
                form.dateTimePicker11.Value = card.date_trapping;
                form.dateTimePicker11.Text = card.date_trapping.ToShortDateString();
                form.textBox12.Text = card.purpose.ToString();
                form.button1.Visible = true;
                form.button2.Visible = false;
                form.button3.Visible = true;
                form.button5.Visible = false;
                form.textBox6.ReadOnly = true;
                form.Show();
            }
            else MessageBox.Show("Доступ отсутствует");
        }

        private void button3_Click_1(object sender, EventArgs e) //удалить карточку
        {
            var idCard = Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value);
            var index = dataGridView1.CurrentRow.Index;
            if (Controller.SelectActCardToDelete(idCard))
            {
                DialogResult result=MessageBox.Show("Удалить выбранную карточку?", "Сообщение", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Controller.DeleteActCard(idCard);
                    //dataGridView1.Rows.RemoveAt(index);
                    openRegistry(this);
                }
            }
            else MessageBox.Show("Доступ отсутствует");
        }

        private void button4_Click_1(object sender, EventArgs e) //добавить карточку
        {
            if (Controller.OpenNewActCard())
            {
                Form4 form = new Form4(this);
                form.button1.Visible = true;
                form.button2.Visible = false;
                form.button3.Visible = false;
                form.button5.Visible = true;
                form.Show();
            }
            else MessageBox.Show("Доступ отсутствует");
        }

        private void button7_Click(object sender, EventArgs e) //экспорт в Exel
        {
            var idCards = new List<int>();
            for (var i = 0; i < dataGridView1.Rows.Count; i++)
            {
                idCards.Add(Convert.ToInt32(dataGridView1.Rows[0].Cells[5]));
            }
            Controller.ExportExcel(idCards.ToArray(), "");
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            form2.Show();
        }
    }
}
