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
    }
}
