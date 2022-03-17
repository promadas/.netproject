using DataAccessLayer.Entities;
using DataAccessLayer.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityManagementSystem
{
    public partial class AddMarks : Form
    {
        public AddMarks()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            EMarks eMarks = new EMarks();
            OMarks oMarks = new OMarks();
            eMarks.Id = txtBoxID.Text;
            eMarks.Name = txtBoxName.Text;
            eMarks.Marks = txtBoxMarks.Text;
            int check = oMarks.Insert(eMarks);
            if(check > 0)
            {
                MessageBox.Show("Successfully Inserted");
            }
            else
            {
                MessageBox.Show("error");
            }

        }

       private void btnDelete_Click(object sender, EventArgs e)
        {
            EMarks eMarks = new EMarks();
            OMarks oMarks = new OMarks();
            eMarks.Id = txtBoxID.Text;
            eMarks.Name = txtBoxName.Text;
            eMarks.Marks = txtBoxMarks.Text;
            int check = oMarks.Delete(eMarks);
            if (check > 0)
            {
                MessageBox.Show("Successfully deleted");
            }
            else
            {
                MessageBox.Show("error");
            }

        }
        

        private void btnShow_Click(object sender, EventArgs e)
        {
            EMarks eMarks = new EMarks();
            OMarks oMarks = new OMarks();
            eMarks.Id = txtBoxID.Text;
            eMarks.Name = txtBoxName.Text;
            eMarks.Marks = txtBoxMarks.Text;
            SqlDataAdapter sqlDataAdapter = oMarks.Show();
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EMarks eMarks = new EMarks();
            OMarks oMarks = new OMarks();
            eMarks.Id = txtBoxID.Text;
            eMarks.Name = txtBoxName.Text;
            eMarks.Marks = txtBoxMarks.Text;
            SqlDataAdapter sqlDataAdapter = oMarks.Show();
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void AddMarks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseconnectionDataSet.MarksTable' table. You can move, or remove it, as needed.
            this.marksTableTableAdapter.Fill(this.databaseconnectionDataSet.MarksTable);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }
    }


}
