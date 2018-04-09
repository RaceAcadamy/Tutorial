using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EX_01_WindowsForm_Project
{
    public partial class SubjectUI : Form
    {
        public SubjectUI()
        {
            InitializeComponent();
        }

        private void SubjectUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainUI mainUIObj = new MainUI();
            mainUIObj.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
