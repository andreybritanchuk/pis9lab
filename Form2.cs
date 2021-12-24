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
    public partial class Form2 : Form
    {
        public string role;
        public Form1 form1;
        public Form2()
        {
            InitializeComponent();
        }

        private void реестрАктовОтловаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3(this);
            if (role != "Оператор по отлову")
            {
                form.button2.Visible = false;
                form.button3.Visible = false;
                form.button4.Visible = false;
            }
            Hide();
            form.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("© 2021, ПИС ПИ-19.02-2. Все права защищены");
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Close();
        }
    }
}
