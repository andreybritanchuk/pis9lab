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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source = DESKTOP-A8G14L1\\SQLEXPRESS;" +
                "Initial Catalog = Реестр актов отлова; Integrated Security = True; " +
                "multipleactiveresultsets=True;";
            Controller.connect = new SqlConnection(connectionString);

            var user =Controller.LogIn(textBox1.Text, textBox2.Text);
            if (user != null)
            {
                Form2 form = new Form2();
                form.role = user.role;
                Hide();
                form.ShowDialog();
            }
            else MessageBox.Show("Неверный логин или пароль");
        }
    }
}
