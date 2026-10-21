namespace Project_21IT_Behteev_ЯМП6
{
    partial class AboutProgram
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(202, 30);
            label1.TabIndex = 0;
            label1.Text = "Лабораторная №6";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(12, 39);
            label2.Name = "label2";
            label2.Size = new Size(211, 15);
            label2.TabIndex = 1;
            label2.Text = "Автор: Бехтеев Дмитрий Николаевич";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(12, 54);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 1;
            label3.Text = "Группа: 21ИТ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(12, 69);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 1;
            label4.Text = "МелГУ";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Location = new Point(297, 176);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Закрыть";
            button1.UseVisualStyleBackColor = false;
            button1.Click += AboutProgramClose_Click;
            // 
            // AboutProgram
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(384, 211);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AboutProgram";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}