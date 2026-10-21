namespace Project_21IT_Behteev
{
    partial class Form1
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
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Firebrick;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Dock = DockStyle.Right;
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(309, 0);
            button2.Name = "button2";
            button2.Size = new Size(75, 361);
            button2.TabIndex = 0;
            button2.Text = "Red";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.Dock = DockStyle.Left;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 361);
            button1.TabIndex = 1;
            button1.Text = "Blue";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightGreen;
            button3.Dock = DockStyle.Fill;
            button3.Location = new Point(75, 0);
            button3.Name = "button3";
            button3.Size = new Size(234, 361);
            button3.TabIndex = 2;
            button3.Text = "Решение";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DimGray;
            button4.Dock = DockStyle.Bottom;
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(75, 338);
            button4.Name = "button4";
            button4.Size = new Size(234, 23);
            button4.TabIndex = 3;
            button4.Text = "Исполнитель";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.IndianRed;
            button5.Dock = DockStyle.Bottom;
            button5.Location = new Point(75, 315);
            button5.Name = "button5";
            button5.Size = new Size(234, 23);
            button5.TabIndex = 4;
            button5.Text = "Закрыть";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
