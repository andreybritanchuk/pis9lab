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
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            
            dataGridView1.RowCount = 3;
            dataGridView1.ColumnCount = 12;
            dataGridView1.Rows[0].Cells[0].Value = Convert.ToString("Номер МК");
            dataGridView1.Rows[0].Cells[1].Value = Convert.ToString("Дата заключения МК");
            dataGridView1.Rows[0].Cells[2].Value = Convert.ToString("Муниципальное образование");
            dataGridView1.Rows[0].Cells[3].Value = Convert.ToString("ОМ СУ");
            dataGridView1.Rows[0].Cells[4].Value = Convert.ToString("Исполнитель МК");
            dataGridView1.Rows[0].Cells[5].Value = Convert.ToString("Номер акта отлова");
            dataGridView1.Rows[0].Cells[6].Value = Convert.ToString("Количество отловленных собак");
            dataGridView1.Rows[0].Cells[7].Value = Convert.ToString("Количество отловленных кошек");
            dataGridView1.Rows[0].Cells[8].Value = Convert.ToString("Количество отловленных животных");
            dataGridView1.Rows[0].Cells[9].Value = Convert.ToString("Населенный пункт");
            dataGridView1.Rows[0].Cells[10].Value = Convert.ToString("Дата отлова");
            dataGridView1.Rows[0].Cells[11].Value = Convert.ToString("Цель отлова");



            dataGridView1.Rows[1].Cells[0].Value = Convert.ToString("Акт 2");
            dataGridView1.Rows[1].Cells[1].Value = Convert.ToString("г. Пермь");
            dataGridView1.Rows[1].Cells[2].Value = Convert.ToString("Отделение №3");

            dataGridView1.Rows[2].Cells[0].Value = Convert.ToString("Акт 3");
            dataGridView1.Rows[2].Cells[1].Value = Convert.ToString("г. Тула");
            dataGridView1.Rows[2].Cells[2].Value = Convert.ToString("Отделение №1");

        }
    }
}
