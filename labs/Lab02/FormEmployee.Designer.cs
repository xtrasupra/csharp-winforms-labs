namespace Project_21IT_Behteev_ЯМП2
{
    partial class FormEmployee
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
            menuStrip1 = new MenuStrip();
            действиеToolStripMenuItem = new ToolStripMenuItem();
            отменитьToolStripMenuItem = new ToolStripMenuItem();
            редактироватьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            отчетToolStripMenuItem = new ToolStripMenuItem();
            поСотрудникуToolStripMenuItem = new ToolStripMenuItem();
            поВсемСотрудникамToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { действиеToolStripMenuItem, отчетToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(464, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // действиеToolStripMenuItem
            // 
            действиеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { отменитьToolStripMenuItem, редактироватьToolStripMenuItem, сохранитьToolStripMenuItem, удалитьToolStripMenuItem });
            действиеToolStripMenuItem.Name = "действиеToolStripMenuItem";
            действиеToolStripMenuItem.Size = new Size(70, 20);
            действиеToolStripMenuItem.Text = "Действие";
            действиеToolStripMenuItem.Click += actionToolStripMenuItem;
            // 
            // отменитьToolStripMenuItem
            // 
            отменитьToolStripMenuItem.Name = "отменитьToolStripMenuItem";
            отменитьToolStripMenuItem.Size = new Size(180, 22);
            отменитьToolStripMenuItem.Text = "Отменить";
            отменитьToolStripMenuItem.Click += undoToolStripMenuItem;
            // 
            // редактироватьToolStripMenuItem
            // 
            редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            редактироватьToolStripMenuItem.Size = new Size(180, 22);
            редактироватьToolStripMenuItem.Text = "Редактировать";
            редактироватьToolStripMenuItem.Click += editToolStripMenuItem;
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(180, 22);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            сохранитьToolStripMenuItem.Click += saveToolStripMenuItem;
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(180, 22);
            удалитьToolStripMenuItem.Text = "Удалить";
            удалитьToolStripMenuItem.Click += removeToolStripMenuIteme;
            // 
            // отчетToolStripMenuItem
            // 
            отчетToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { поСотрудникуToolStripMenuItem, поВсемСотрудникамToolStripMenuItem });
            отчетToolStripMenuItem.Name = "отчетToolStripMenuItem";
            отчетToolStripMenuItem.Size = new Size(51, 20);
            отчетToolStripMenuItem.Text = "Отчет";
            отчетToolStripMenuItem.Click += reportToolStripMenuItem;
            // 
            // поСотрудникуToolStripMenuItem
            // 
            поСотрудникуToolStripMenuItem.Name = "поСотрудникуToolStripMenuItem";
            поСотрудникуToolStripMenuItem.Size = new Size(195, 22);
            поСотрудникуToolStripMenuItem.Text = "По сотруднику";
            поСотрудникуToolStripMenuItem.Click += reportToolStripMenuItem1;
            // 
            // поВсемСотрудникамToolStripMenuItem
            // 
            поВсемСотрудникамToolStripMenuItem.Name = "поВсемСотрудникамToolStripMenuItem";
            поВсемСотрудникамToolStripMenuItem.Size = new Size(195, 22);
            поВсемСотрудникамToolStripMenuItem.Text = "По всем сотрудникам";
            поВсемСотрудникамToolStripMenuItem.Click += reportToolStripMenuItem2;
            // 
            // FormEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 341);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormEmployee";
            Text = "Данные по сотрудникам";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem действиеToolStripMenuItem;
        private ToolStripMenuItem отменитьToolStripMenuItem;
        private ToolStripMenuItem редактироватьToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripMenuItem отчетToolStripMenuItem;
        private ToolStripMenuItem поСотрудникуToolStripMenuItem;
        private ToolStripMenuItem поВсемСотрудникамToolStripMenuItem;
    }
}