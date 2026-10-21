using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project_21IT_Behteev_ЯМП2
{
    public partial class LinearTaskForm : Form
    {
        public LinearTaskForm()
        {
            InitializeComponent();
            this.Text = "Линейная задача — результаты";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        public void SetData(string fio, string variant, string inputData, string result)
        {
            lblFIO.Text = fio;
            lblVariant.Text = variant;
            lblInputData.Text = inputData;
            lblResult.Text = result;
        }
    }
}
