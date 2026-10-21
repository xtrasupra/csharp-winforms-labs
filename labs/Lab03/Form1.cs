namespace Project_21IT_Behteev_ЯМП2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void objektToolStripMenuItem(object sender, EventArgs e)
        {
            MessageBox.Show("Пункт меню 'Объект'");
        }

        public void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void HelpToolStripMenuItem(object sender, EventArgs e)
        {

        }
        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Создать объект FEmployee класса FormEmployee
            FormEmployee FEmployee = new FormEmployee();
            // Установить родительское окно для дочернего
            FEmployee.MdiParent = this;
            // Вывести на экран дочерее окно
            FEmployee.Show();

        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.ShowDialog(this);
        }
        private void linearTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double x = 6.37;
            double a = 2.56;
            double b = 7.18;

            double numerator = Math.Cos(x - a);
            double exponentPart = Math.Exp(x - a);
            double sqrtPart = Math.Sqrt(b * x);
            double denominator = exponentPart + sqrtPart;
            double Y = numerator / denominator;

            LinearTaskForm dialog = new LinearTaskForm();

            dialog.SetData(
                "Бехтеев Д.Н.",
                "Вариант 1",
                $"x = {x:F2}, a = {a:F2}, b = {b:F2}",
                $"Y = {Y:F5}"
            );

            dialog.ShowDialog();
        }
    }
}
