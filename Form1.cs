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
            string connectionString = @"Server=(LocalDB)\MSSQLLocalDB; AttachDBFilename=|DataDirectory|\Database1.mdf;" +
                "multipleactiveresultsets=True;";
            Controller.connect = new SqlConnection(connectionString);

            var user =Controller.LogIn(textBox1.Text, textBox2.Text);
            if (user != null)
            {
                Form2 form = new Form2();
                form.role = user.role;
                form.form1 = this;
                Hide();
                form.Show();
            }
            else MessageBox.Show("Неверный логин или пароль");
        }
    }
}
