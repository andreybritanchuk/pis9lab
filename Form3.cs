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
            dataGridView1.ColumnCount = 3;
            dataGridView1.Rows[0].Cells[0].Value = Convert.ToString("Акт:");
            dataGridView1.Rows[0].Cells[1].Value = Convert.ToString("Город:");
            dataGridView1.Rows[0].Cells[2].Value = Convert.ToString("Отделение:");
            

            dataGridView1.Rows[1].Cells[0].Value = Convert.ToString("Акт 2");
            dataGridView1.Rows[1].Cells[1].Value = Convert.ToString("г. Пермь");
            dataGridView1.Rows[1].Cells[2].Value = Convert.ToString("Отделение №3");

            dataGridView1.Rows[2].Cells[0].Value = Convert.ToString("Акт 3");
            dataGridView1.Rows[2].Cells[1].Value = Convert.ToString("г. Тула");
            dataGridView1.Rows[2].Cells[2].Value = Convert.ToString("Отделение №1");

        }
    }
}
