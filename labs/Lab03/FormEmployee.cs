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

        private void Save()
        {
            DialogResult saveResult = MessageBox.Show
            (
                "Сохранить данные по сотруднику?",
                "Подтверждение сохранения",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (saveResult == DialogResult.Yes)
            {
                DialogResult errorResult = MessageBox.Show
                (
                    "Во время сохранения произошла ошибка. Что желаете сделать?",
                    "Ошибка сохранения",
                    MessageBoxButtons.AbortRetryIgnore,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button2
                );

                switch (errorResult)
                {
                    case DialogResult.Abort:
                        MessageBox.Show("Сохранение прервано");
                        break;
                    case DialogResult.Retry:
                        MessageBox.Show("Повторная попытка сохранения...");
                        break;
                    case DialogResult.Ignore:
                        MessageBox.Show("Ошибка проигнорирована");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Отмена сохранения данных");
            }
        }
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
            Save();
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

//private void button3_Click(object sender, EventArgs e)
//{
//    double x = 6.37;
//    double a = 2.56;
//    double b = 7.18;

//    double numerator = Math.Cos(x - a);

//    double exponentPart = Math.Exp(x - a);
//    double sqrtPart = Math.Sqrt(b * x);
//    double denominator = exponentPart + sqrtPart;

//    double Y = numerator / denominator;

//    MessageBox.Show($"Y = {Y.ToString("F5")}");
//}