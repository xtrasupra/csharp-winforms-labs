using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project_21IT_Behteev_ЯМП6
{
    public partial class AboutProgram : Form
    {
        public AboutProgram()
        {
            InitializeComponent();
        }

        public void AboutProgramClose_Click (object sender, EventArgs e)
        {
            Close();
        }
    }
}
