namespace Project_21IT_Behteev_ЯМП2
{
    partial class LinearTaskForm
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
            lblTitle = new Label();
            lblFIOLabel = new Label();
            lblFIO = new Label();
            lblVariantLabel = new Label();
            lblVariant = new Label();
            lblInputLabel = new Label();
            lblInputData = new Label();
            lblResultLabel = new Label();
            lblResult = new Label();
            btnOK = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(167, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Результаты линейной задачи";
            // 
            // lblFIOLabel
            // 
            lblFIOLabel.AutoSize = true;
            lblFIOLabel.Location = new Point(12, 24);
            lblFIOLabel.Name = "lblFIOLabel";
            lblFIOLabel.Size = new Size(124, 15);
            lblFIOLabel.TabIndex = 0;
            lblFIOLabel.Text = "1. ФИО исполнителя:";
            // 
            // lblFIO
            // 
            lblFIO.AutoSize = true;
            lblFIO.Location = new Point(12, 39);
            lblFIO.Name = "lblFIO";
            lblFIO.Size = new Size(0, 15);
            lblFIO.TabIndex = 0;
            // 
            // lblVariantLabel
            // 
            lblVariantLabel.AutoSize = true;
            lblVariantLabel.Location = new Point(12, 54);
            lblVariantLabel.Name = "lblVariantLabel";
            lblVariantLabel.Size = new Size(113, 15);
            lblVariantLabel.TabIndex = 0;
            lblVariantLabel.Text = "2. Номер варианта:";
            // 
            // lblVariant
            // 
            lblVariant.AutoSize = true;
            lblVariant.Location = new Point(12, 69);
            lblVariant.Name = "lblVariant";
            lblVariant.Size = new Size(0, 15);
            lblVariant.TabIndex = 0;
            // 
            // lblInputLabel
            // 
            lblInputLabel.AutoSize = true;
            lblInputLabel.Location = new Point(12, 84);
            lblInputLabel.Name = "lblInputLabel";
            lblInputLabel.Size = new Size(121, 15);
            lblInputLabel.TabIndex = 0;
            lblInputLabel.Text = "3. Исходные данные:";
            // 
            // lblInputData
            // 
            lblInputData.AutoSize = true;
            lblInputData.Location = new Point(12, 99);
            lblInputData.Name = "lblInputData";
            lblInputData.Size = new Size(0, 15);
            lblInputData.TabIndex = 0;
            // 
            // lblResultLabel
            // 
            lblResultLabel.AutoSize = true;
            lblResultLabel.Location = new Point(12, 114);
            lblResultLabel.Name = "lblResultLabel";
            lblResultLabel.Size = new Size(128, 15);
            lblResultLabel.TabIndex = 0;
            lblResultLabel.Text = "4. Результат решения:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(12, 129);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 0;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(713, 415);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 1;
            btnOK.Text = "Ок";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // LinearTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOK);
            Controls.Add(lblResult);
            Controls.Add(lblResultLabel);
            Controls.Add(lblInputData);
            Controls.Add(lblInputLabel);
            Controls.Add(lblVariant);
            Controls.Add(lblVariantLabel);
            Controls.Add(lblFIO);
            Controls.Add(lblFIOLabel);
            Controls.Add(lblTitle);
            Name = "LinearTaskForm";
            Text = "LinearTaskForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblFIOLabel;
        private Label lblFIO;
        private Label lblVariantLabel;
        private Label lblVariant;
        private Label lblInputLabel;
        private Label lblInputData;
        private Label lblResultLabel;
        private Label lblResult;
        private Button btnOK;
    }
}