using CustomerCare_App;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CustomerCare_App
{

    public partial class Form1 : Form
    {
        
        public Form1( Customer customer)
        {
            InitializeComponent();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pnlCustomer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlCustomer.Enabled = false;

            try
            {
                DbContext dbcontext = new DbContext();
                gdvCustomer.DataSource = dbcontext.GetCusotmerList();

            }
            catch (Exception exception)
            {
                MessageBox.Show("Error Occured:" + exception.Message);
            }
           
            

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            pnlCustomer.Enabled = true;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string Name = txtSearch.Text;
                DbContext dbcontext = new DbContext();
                gdvCustomer.DataSource = dbcontext.SearchCustomer(Name);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error Occured :" + exception.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
