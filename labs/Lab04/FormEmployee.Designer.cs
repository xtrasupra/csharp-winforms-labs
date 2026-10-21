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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployee));
            menuStrip1 = new MenuStrip();
            действиеToolStripMenuItem = new ToolStripMenuItem();
            отменитьToolStripMenuItem = new ToolStripMenuItem();
            редактироватьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            отчетToolStripMenuItem = new ToolStripMenuItem();
            поСотрудникуToolStripMenuItem = new ToolStripMenuItem();
            поВсемСотрудникамToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButtonUndo = new ToolStripButton();
            toolStripButtonNew = new ToolStripButton();
            toolStripButtonEdit = new ToolStripButton();
            toolStripButtonSave = new ToolStripButton();
            toolStripButtonRemove = new ToolStripButton();
            contextMenuStrip1 = new ContextMenuStrip(components);
            отменитьToolStripMenuItem1 = new ToolStripMenuItem();
            создатьToolStripMenuItem = new ToolStripMenuItem();
            редактироватьToolStripMenuItem1 = new ToolStripMenuItem();
            сохранитьToolStripMenuItem1 = new ToolStripMenuItem();
            удалитьToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
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
            отменитьToolStripMenuItem.Size = new Size(154, 22);
            отменитьToolStripMenuItem.Text = "Отменить";
            отменитьToolStripMenuItem.Click += undoToolStripMenuItem;
            // 
            // редактироватьToolStripMenuItem
            // 
            редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            редактироватьToolStripMenuItem.Size = new Size(154, 22);
            редактироватьToolStripMenuItem.Text = "Редактировать";
            редактироватьToolStripMenuItem.Click += editToolStripMenuItem;
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(154, 22);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            сохранитьToolStripMenuItem.Click += saveToolStripMenuItem;
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(154, 22);
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
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonUndo, toolStripButtonNew, toolStripButtonEdit, toolStripButtonSave, toolStripButtonRemove });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(464, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonUndo
            // 
            toolStripButtonUndo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonUndo.Image = (Image)resources.GetObject("toolStripButtonUndo.Image");
            toolStripButtonUndo.ImageTransparentColor = Color.Magenta;
            toolStripButtonUndo.Name = "toolStripButtonUndo";
            toolStripButtonUndo.Size = new Size(23, 22);
            toolStripButtonUndo.Text = "toolStripButton1";
            toolStripButtonUndo.ToolTipText = "Отменить";
            toolStripButtonUndo.Click += toolStripButtonUndo_Click;
            // 
            // toolStripButtonNew
            // 
            toolStripButtonNew.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonNew.Image = (Image)resources.GetObject("toolStripButtonNew.Image");
            toolStripButtonNew.ImageTransparentColor = Color.Magenta;
            toolStripButtonNew.Name = "toolStripButtonNew";
            toolStripButtonNew.Size = new Size(23, 22);
            toolStripButtonNew.Text = "toolStripButton2";
            toolStripButtonNew.ToolTipText = "Добавить";
            // 
            // toolStripButtonEdit
            // 
            toolStripButtonEdit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonEdit.Image = (Image)resources.GetObject("toolStripButtonEdit.Image");
            toolStripButtonEdit.ImageTransparentColor = Color.Magenta;
            toolStripButtonEdit.Name = "toolStripButtonEdit";
            toolStripButtonEdit.Size = new Size(23, 22);
            toolStripButtonEdit.Text = "toolStripButton3";
            toolStripButtonEdit.ToolTipText = "Редактировать";
            // 
            // toolStripButtonSave
            // 
            toolStripButtonSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonSave.Image = (Image)resources.GetObject("toolStripButtonSave.Image");
            toolStripButtonSave.ImageTransparentColor = Color.Magenta;
            toolStripButtonSave.Name = "toolStripButtonSave";
            toolStripButtonSave.Size = new Size(23, 22);
            toolStripButtonSave.Text = "toolStripButton4";
            toolStripButtonSave.ToolTipText = "Сохранить";
            // 
            // toolStripButtonRemove
            // 
            toolStripButtonRemove.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonRemove.Image = (Image)resources.GetObject("toolStripButtonRemove.Image");
            toolStripButtonRemove.ImageTransparentColor = Color.Magenta;
            toolStripButtonRemove.Name = "toolStripButtonRemove";
            toolStripButtonRemove.Size = new Size(23, 22);
            toolStripButtonRemove.Text = "toolStripButton1";
            toolStripButtonRemove.ToolTipText = "Вырезать";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { отменитьToolStripMenuItem1, создатьToolStripMenuItem, редактироватьToolStripMenuItem1, сохранитьToolStripMenuItem1, удалитьToolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(155, 114);
            // 
            // отменитьToolStripMenuItem1
            // 
            отменитьToolStripMenuItem1.Name = "отменитьToolStripMenuItem1";
            отменитьToolStripMenuItem1.Size = new Size(154, 22);
            отменитьToolStripMenuItem1.Text = "Отменить";
            // 
            // создатьToolStripMenuItem
            // 
            создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            создатьToolStripMenuItem.Size = new Size(154, 22);
            создатьToolStripMenuItem.Text = "Создать";
            // 
            // редактироватьToolStripMenuItem1
            // 
            редактироватьToolStripMenuItem1.Name = "редактироватьToolStripMenuItem1";
            редактироватьToolStripMenuItem1.Size = new Size(154, 22);
            редактироватьToolStripMenuItem1.Text = "Редактировать";
            // 
            // сохранитьToolStripMenuItem1
            // 
            сохранитьToolStripMenuItem1.Name = "сохранитьToolStripMenuItem1";
            сохранитьToolStripMenuItem1.Size = new Size(154, 22);
            сохранитьToolStripMenuItem1.Text = "Сохранить";
            // 
            // удалитьToolStripMenuItem1
            // 
            удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            удалитьToolStripMenuItem1.Size = new Size(154, 22);
            удалитьToolStripMenuItem1.Text = "Удалить";
            // 
            // FormEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 341);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormEmployee";
            Text = "Данные по сотрудникам";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
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
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonUndo;
        private ToolStripButton toolStripButtonNew;
        private ToolStripButton toolStripButtonEdit;
        private ToolStripButton toolStripButtonSave;
        private ToolStripButton toolStripButtonRemove;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem отменитьToolStripMenuItem1;
        private ToolStripMenuItem создатьToolStripMenuItem;
        private ToolStripMenuItem редактироватьToolStripMenuItem1;
        private ToolStripMenuItem сохранитьToolStripMenuItem1;
        private ToolStripMenuItem удалитьToolStripMenuItem1;
    }
}