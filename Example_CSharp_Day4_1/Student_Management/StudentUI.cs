using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using Emgu.CV;
//using Emgu.CV.CvEnum;
//using Emgu.CV.Features2D;
//using Emgu.CV.Flann;
//using Emgu.CV.Structure;
//using Emgu.CV.Util;


namespace EX_01_WindowsForm_Project
{
    public partial class StudentUI : Form
    {
        public StudentUI()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ComboBox cmb = new ComboBox();

              //  DataSet dt = new DataSet();
             //   cmbSubject.SelectedItem()

                //Set AutoGenerateColumns False
                dgvSubject.AutoGenerateColumns = false;

                //Set Columns Count
                dgvSubject.ColumnCount = 3;

                //Add Columns
                
                dgvSubject.Columns[0].HeaderText = "Subject Name";
                dgvSubject.Columns[0].Name = "Name";
                dgvSubject.Columns[0].DataPropertyName = "SubjectName";

               
           //     dgvSubject.DataSource = dt;
            

        }

        private void StudentUI_FormClosing(object sender, FormClosingEventArgs e)
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
