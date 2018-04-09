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
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }
        

        private void btnStudent_Click(object sender, EventArgs e)
        {
            StudentUI studentUIObj = new StudentUI();
            studentUIObj.Show();
            this.Hide();
        }

        private void btnSubject_Click(object sender, EventArgs e)
        {
            SubjectUI subjectUIObj = new SubjectUI();
            subjectUIObj.Show();
            this.Hide();
        }
    }
}
