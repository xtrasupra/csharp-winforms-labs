using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project_21IT_Behteev_ЯМП2
{
    public partial class FormEmployee : Form
    {
        private void Undo()
        {
            MessageBox.Show("Метод 'Undo'");
        }

        public FormEmployee()
        {
            InitializeComponent();
        }
        public void actionToolStripMenuItem(object sender, EventArgs e)
        {

        }
        public void undoToolStripMenuItem(object sender, EventArgs e)
        {
            Undo();
        }
        public void createToolStripMenuItem(object sender, EventArgs e)
        {

        }
        public void editToolStripMenuItem(object sender, EventArgs e)
        {

        }
        public void saveToolStripMenuItem(object sender, EventArgs e)
        {

        }
        public void removeToolStripMenuIteme(object sender, EventArgs e)
        {

        }
        public void reportToolStripMenuItem(object sender, EventArgs e)
        {

        }
        public void reportToolStripMenuItem1(object sender, EventArgs e)
        {

        }
        public void reportToolStripMenuItem2(object sender, EventArgs e)
        {

        }
    }
}
