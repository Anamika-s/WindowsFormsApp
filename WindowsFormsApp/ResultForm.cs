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
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
           
           
            lblName.Text = string.Concat(DataEntryForm.FName, " ", DataEntryForm.LName);
            lblBatch.Text = DataEntryForm.BCode;
            lblTotalMarks.Text = DataEntryForm.TotalMarks;
            lblPer.Text = DataEntryForm.Per + "%";
        }
    }
}
