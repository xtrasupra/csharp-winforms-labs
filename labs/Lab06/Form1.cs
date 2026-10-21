using System;
using System.Windows.Forms;

namespace Project_21IT_Behteev_ЯМП6
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        public void AboutProgram_Click(object sender, EventArgs e)
        {
            AboutProgram dialog = new AboutProgram();
            dialog.ShowDialog(this);
        }

        private void Cut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вырезать", "Действие");
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Копировать", "Действие");
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вставить", "Действие");
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Удалить", "Действие");
        }

        private void TaskIf1_Click(object sender, EventArgs e)
        {
            double a = 0.54;
            double b = 2.23;

            Random rand = new Random();
            double x = rand.Next(1, 9);

            DialogResult result = MessageBox.Show(
                $"Вычислить значение y при x = {x}?",
                "Решение задачи",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                double y;
                bool isDomainValid = true;

                if (x <= b)
                {
                    double inner = a + Math.Pow(x, 1.0 / 3.0);
                    if (inner < 0)
                        isDomainValid = false;
                    else
                    {
                        y = Math.Sqrt(inner) / Math.Exp(-b * x);
                        MessageBox.Show($"Значение x = {x}\nРешение по формуле 1.\ny = {y:F6}",
                                        "Результат");
                    }
                }
                else
                {
                    double arg = 0.1 * b * x;
                    y = Math.Pow(Math.Tan(arg), 3);
                    MessageBox.Show($"Значение x = {x}\nРешение по формуле 2.\ny = {y:F6}",
                                    "Результат");
                }

                if (!isDomainValid)
                {
                    MessageBox.Show($"Значение x = {x} не входит в область допустимых решений.",
                                    "Ошибка");
                }
            }
            else
            {
                MessageBox.Show("Отмена действий", "Сообщение");
            }
        }
    }
}