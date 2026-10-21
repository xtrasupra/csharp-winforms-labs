using System;
using System.Windows.Forms;

namespace Project_21IT_Behteev_ЯМП7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
            label2.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Text = "";

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }

            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            if (e.KeyChar == ',')
            {
                if (textBox1.Text.Length == 0)
                {
                    e.Handled = true;
                    return;
                }

                if (textBox1.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    button1.Focus();
                }
                return;
            }

            e.Handled = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double funt;
            double kg;

            try
            {
                funt = Convert.ToDouble(textBox1.Text);
                kg = funt * 409.5;
                label2.Text = kg.ToString("F2") + " г.";
            }
            catch
            {
                MessageBox.Show("Введите корректное число", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                textBox1.SelectAll();
            }
        }
    }
}