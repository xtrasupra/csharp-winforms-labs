namespace Project_21IT_Behteev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Color tempColor = button1.BackColor;

            button1.BackColor = button2.BackColor;
            button2.BackColor = tempColor;

            MessageBox.Show("Вы изменили цвет '1' кнопки на цвет '2' кнопки");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Color tempColor = button1.BackColor;

            button1.BackColor = button2.BackColor;
            button2.BackColor = tempColor;

            MessageBox.Show("Вы изменили цвет '2' кнопки на цвет '1' кнопки");
        }


        private void button3_Click(object sender, EventArgs e)
        {
            double x = 6.37;
            double a = 2.56;
            double b = 7.18;

            double numerator = Math.Cos(x - a);

            double exponentPart = Math.Exp(x - a);
            double sqrtPart = Math.Sqrt(b * x);
            double denominator = exponentPart + sqrtPart;

            double Y = numerator / denominator;

            MessageBox.Show($"Y = {Y.ToString("F5")}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string executorInfo = "Исполнитель: [Бехтеев], группа [21ИТ]";
            this.Text = executorInfo;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
