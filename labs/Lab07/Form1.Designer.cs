namespace Project_21IT_Behteev_ЯМП7
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBox1 = new TextBox();
            this.button1 = new Button();
            this.label1 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.SuspendLayout();
 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Text = "Вес в фунтах:";

            this.textBox1.Location = new System.Drawing.Point(150, 27);
            this.textBox1.Size = new System.Drawing.Size(120, 23);

            this.textBox1.KeyPress += new KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.TextChanged += new EventHandler(this.textBox1_TextChanged);

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 70);
            this.label3.Text = "=";

            this.button1.Location = new System.Drawing.Point(150, 65);
            this.button1.Size = new System.Drawing.Size(120, 30);
            this.button1.Text = "Ок";
            this.button1.Click += new EventHandler(this.button1_Click);

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 70);
            this.label2.Text = "";

            this.ClientSize = new System.Drawing.Size(450, 150);
            this.Text = "Фунты-килограммы";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}