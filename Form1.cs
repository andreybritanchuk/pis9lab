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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text == "1" && textBox2.Text == "1")
            //{
            //    Form2 dlg = new Form2();
            //    dlg.role = "Autor";
            //    dlg.Show(this);
            //}
            //else if (textBox1.Text == "2" && textBox2.Text == "2")
            //{
            //    Form2 dlg = new Form2();
            //    dlg.role = "Guest";
            //    dlg.Show(this);
            //}
            //else
            //{
            //    MessageBox.Show("Неверный логин или пароль");
            //}
            var user=Controller.LogIn(textBox1.Text, textBox2.Text);
            if (user != null)
            {
                Form2 form = new Form2();
                form.role = user.role;
                form.Show(this);
            }
            else MessageBox.Show("Неверный логин или пароль");
        }
    }
}
