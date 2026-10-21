using System;
using System.Windows.Forms;

namespace ProjectMod1v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Модуль № 1. Вариант 1.";
        }

        // Заглушки для подпунктов "Действия"
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

        // Заглушка TaskIf1 для задачи с условием
        private void TaskIf1_Click(object sender, EventArgs e)
        {
            double a = 0.54;
            double b = 2.23;

            Random rand = new Random();
            double x = rand.Next(1, 9); // [1;8]

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
                    // Проверка области: подкоренное выражение >= 0
                    double inner = a + Math.Pow(x, 1.0 / 3.0); // кубический корень
                    if (inner < 0)
                        isDomainValid = false;
                    else
                    {
                        y = Math.Sqrt(inner) / Math.Exp(-b * x);
                        MessageBox.Show($"Значение x = {x}\nРешение по формуле 1.\ny = {y:F6}",
                                        "Результат",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                }
                else // x > b
                {
                    double arg = 0.1 * b * x;
                    // tg^3 = (tan)^3
                    y = Math.Pow(Math.Tan(arg), 3);
                    MessageBox.Show($"Значение x = {x}\nРешение по формуле 2.\ny = {y:F6}",
                                    "Результат",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }

                if (!isDomainValid)
                {
                    MessageBox.Show($"Значение x = {x} не входит в область допустимых решений.",
                                    "Ошибка области",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Отмена действий", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Студент - модальное окно
        private void Student_Click(object sender, EventArgs e)
        {
            StudentDialog dialog = new StudentDialog();
            dialog.ShowDialog(this);
        }
    }
}