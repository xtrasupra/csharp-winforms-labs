using System.Windows.Forms;

namespace ProjectMod1v1
{
    public partial class StudentDialog : Form
    {
        private TextBox txtFIO;
        private TextBox txtVariant;
        private TextBox txtGroup;
        private Button btnOk;

        public StudentDialog()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.txtFIO = new TextBox();
            this.txtVariant = new TextBox();
            this.txtGroup = new TextBox();
            this.btnOk = new Button();
            this.SuspendLayout();

            // lblFIO
            Label lblFIO = new Label() { Text = "ФИО исполнителя:", Top = 20, Left = 20, Width = 120 };
            txtFIO.Location = new System.Drawing.Point(150, 18);
            txtFIO.Width = 200;

            Label lblVariant = new Label() { Text = "Номер варианта:", Top = 60, Left = 20, Width = 120 };
            txtVariant.Location = new System.Drawing.Point(150, 58);
            txtVariant.Width = 200;
            txtVariant.Text = "1";

            Label lblGroup = new Label() { Text = "Группа:", Top = 100, Left = 20, Width = 120 };
            txtGroup.Location = new System.Drawing.Point(150, 98);
            txtGroup.Width = 200;

            btnOk.Text = "OK";
            btnOk.Location = new System.Drawing.Point(150, 140);
            btnOk.Click += (s, e) => this.Close();

            this.Controls.Add(lblFIO);
            this.Controls.Add(txtFIO);
            this.Controls.Add(lblVariant);
            this.Controls.Add(txtVariant);
            this.Controls.Add(lblGroup);
            this.Controls.Add(txtGroup);
            this.Controls.Add(btnOk);

            this.Text = "Студент";
            this.Size = new System.Drawing.Size(400, 220);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ResumeLayout(false);
        }
    }
}