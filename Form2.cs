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
        public Form2()
        {
            InitializeComponent();
        }

        private void реестрАктовОтловаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (role == "Autor")
            {
                Form3 dlg = new Form3();
                dlg.Show(this);
            }
            if (role == "Guest")
            {
                Form3 dlg = new Form3();
                dlg.button2.Visible = false;
                dlg.button3.Visible = false;
                dlg.button4.Visible = false;
                dlg.Show(this);
            }
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("© 2021, ПИС ПИ-19.02-2. Все права защищены");
        }
    }
}
