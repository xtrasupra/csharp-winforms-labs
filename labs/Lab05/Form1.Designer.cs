namespace ProjectMod1v1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem actionMenuItem;
        private ToolStripMenuItem solutionMenuItem;
        private ToolStripMenuItem studentMenuItem;
        private ToolStripMenuItem cutItem;
        private ToolStripMenuItem copyItem;
        private ToolStripMenuItem insertItem;
        private ToolStripMenuItem deleteItem;
        private ToolStripMenuItem uslovieItem;
        private ToolStrip toolStrip1;
        private ToolStripButton cutButton;
        private ToolStripButton copyButton;
        private ToolStripButton insertButton;
        private ToolStripButton deleteButton;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem ctxCut;
        private ToolStripMenuItem ctxCopy;
        private ToolStripMenuItem ctxInsert;
        private ToolStripMenuItem ctxDelete;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            actionMenuItem = new ToolStripMenuItem("Действия");
            solutionMenuItem = new ToolStripMenuItem("Решение");
            studentMenuItem = new ToolStripMenuItem("Студент");

            // Подпункты Действия
            cutItem = new ToolStripMenuItem("Вырезать");
            copyItem = new ToolStripMenuItem("Копировать");
            insertItem = new ToolStripMenuItem("Вставить");
            deleteItem = new ToolStripMenuItem("Удалить");

            cutItem.Click += Cut_Click;
            copyItem.Click += Copy_Click;
            insertItem.Click += Insert_Click;
            deleteItem.Click += Delete_Click;

            actionMenuItem.DropDownItems.AddRange(new ToolStripMenuItem[] { cutItem, copyItem, insertItem, deleteItem });

            // Подпункт Решения
            uslovieItem = new ToolStripMenuItem("Задача с условием");
            uslovieItem.Click += TaskIf1_Click;
            solutionMenuItem.DropDownItems.Add(uslovieItem);

            studentMenuItem.Click += Student_Click;

            menuStrip1.Items.AddRange(new ToolStripMenuItem[] { actionMenuItem, solutionMenuItem, studentMenuItem });

            // Панель инструментов
            toolStrip1 = new ToolStrip();
            cutButton = new ToolStripButton("Вырезать");
            copyButton = new ToolStripButton("Копировать");
            insertButton = new ToolStripButton("Вставить");
            deleteButton = new ToolStripButton("Удалить");

            cutButton.Click += Cut_Click;
            copyButton.Click += Copy_Click;
            insertButton.Click += Insert_Click;
            deleteButton.Click += Delete_Click;

            toolStrip1.Items.AddRange(new ToolStripButton[] { cutButton, copyButton, insertButton, deleteButton });

            // Контекстное меню
            contextMenuStrip1 = new ContextMenuStrip(components);
            ctxCut = new ToolStripMenuItem("Вырезать");
            ctxCopy = new ToolStripMenuItem("Копировать");
            ctxInsert = new ToolStripMenuItem("Вставить");
            ctxDelete = new ToolStripMenuItem("Удалить");

            ctxCut.Click += Cut_Click;
            ctxCopy.Click += Copy_Click;
            ctxInsert.Click += Insert_Click;
            ctxDelete.Click += Delete_Click;

            contextMenuStrip1.Items.AddRange(new ToolStripMenuItem[] { ctxCut, ctxCopy, ctxInsert, ctxDelete });

            this.ContextMenuStrip = contextMenuStrip1;

            // Добавление элементов на форму
            this.Controls.Add(toolStrip1);
            this.Controls.Add(menuStrip1);
            this.MainMenuStrip = menuStrip1;

            this.AutoSize = true;
            this.Text = "Модуль № 1. Вариант 1.";
        }
    }
}