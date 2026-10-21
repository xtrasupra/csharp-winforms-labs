namespace Project_21IT_Behteev_ЯМП6
{
    partial class Student
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnQuadratic = new Button();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtPersonalFile = new MaskedTextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox6 = new TextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            label8 = new Label();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // btnQuadratic
            // 
            btnQuadratic.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnQuadratic.Location = new Point(422, 48);
            btnQuadratic.Name = "btnQuadratic";
            btnQuadratic.Size = new Size(150, 30);
            btnQuadratic.TabIndex = 0;
            btnQuadratic.Text = "Квадратное уравнение";
            btnQuadratic.Click += TaskIf1_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(422, 12);
            button1.Name = "button1";
            button1.Size = new Size(150, 30);
            button1.TabIndex = 0;
            button1.Text = "О программе";
            button1.UseVisualStyleBackColor = true;
            button1.Click += AboutProgram_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(226, 30);
            label1.TabIndex = 1;
            label1.Text = "Сведение о студенте";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(158, 20);
            label2.TabIndex = 1;
            label2.Text = "Номер личного дела:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(12, 107);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 1;
            label3.Text = "Фамилия:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(12, 136);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 1;
            label4.Text = "Имя:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(12, 165);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 1;
            label5.Text = "Отчество:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(12, 194);
            label6.Name = "label6";
            label6.Size = new Size(40, 20);
            label6.TabIndex = 1;
            label6.Text = "Пол:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(12, 260);
            label7.Name = "label7";
            label7.Size = new Size(122, 20);
            label7.TabIndex = 1;
            label7.Text = "Характеристика:";
            // 
            // txtPersonalFile
            // 
            txtPersonalFile.Location = new Point(176, 75);
            txtPersonalFile.Mask = ">LL-0000";
            txtPersonalFile.Name = "txtPersonalFile";
            txtPersonalFile.Size = new Size(100, 23);
            txtPersonalFile.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(94, 104);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(182, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(94, 133);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(182, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(94, 162);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(182, 23);
            textBox4.TabIndex = 2;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(12, 293);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(264, 105);
            textBox6.TabIndex = 2;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(94, 197);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(78, 19);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Мужской";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(194, 197);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(76, 19);
            checkBox2.TabIndex = 3;
            checkBox2.Text = "Женский";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.Location = new Point(12, 225);
            label8.Name = "label8";
            label8.Size = new Size(44, 20);
            label8.TabIndex = 1;
            label8.Text = "Курс:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(94, 222);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(182, 23);
            textBox5.TabIndex = 2;
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 461);
            Controls.Add(btnQuadratic);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(textBox6);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox5);
            Controls.Add(txtPersonalFile);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Student";
            Text = "Student";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnQuadratic;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private MaskedTextBox txtPersonalFile;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox6;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label8;
        private TextBox textBox5;
    }
}
