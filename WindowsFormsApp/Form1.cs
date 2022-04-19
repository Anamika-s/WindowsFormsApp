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
    public partial class Form1 : Form
    {
         

        
    

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "user" && txtPassword.Text == "password")
            {
               
                MessageBox.Show("Welcome user : " + txtUserName.Text);
                //AdditionForm additionForm = new AdditionForm();
                //additionForm.Show();
                DataEntryForm dataEntryForm = new DataEntryForm();
                dataEntryForm.Show();
            }
            else
                MessageBox.Show("Invalid User");
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
