using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class DataEntryForm : Form
    {
        public static string FName;
        public static string LName;
        public static string BCode;
        public static string TotalMarks;
        public static string Per;


        public DataEntryForm()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)

        {
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataEntryForm_Load(object sender, EventArgs e)
        {

        }

        private void txtScience_TextChanged(object sender, EventArgs e)
        {
            txtTotalMarks.Text = (Byte.Parse(txtEnglish.Text) + Byte.Parse(txtMaths.Text)
                + Byte.Parse(txtScience.Text)).ToString();
            txtPer.Text = (Int16.Parse(txtTotalMarks.Text) / 3).ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            FName = txtFName.Text;
            LName = txtLName.Text;
            BCode = txtBatch.Text;
            TotalMarks  = txtTotalMarks.Text;
            Per = txtPer.Text;
            ResultForm resultForm = new ResultForm();
            resultForm.Show();
        }
    }
}
