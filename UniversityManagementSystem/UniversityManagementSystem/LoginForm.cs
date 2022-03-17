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
    public partial class LoginForm : Form
    {
        SqlDataReader sr;
        SqlDataReader fr;
       
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string Id = txtBox3.Text;
            string Password = txtBox4.Text;
            SqlConnection connection = new SqlConnection("Data Source=PROMA\\PROMA01;Initial Catalog=Databaseconnection;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("select * from StudentTable where id='" + txtBox3.Text + "'and password='" + txtBox4.Text + "'", connection);
           
            sr = command.ExecuteReader();
            
             if (sr.Read())
            {
                new ViewandEditStudentProfile().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("We can't match your data.Register First");
            }

            connection.Close();
            this.Hide();
      
            connection.Open();
            SqlCommand command1 = new SqlCommand("select * from FacultyTable where id='" + txtBox3.Text + "'and password='" + txtBox4.Text + "'", connection);
            fr = command1.ExecuteReader();
             if (fr.Read())
            {
                new ViewandEditFacultyProfile().Show();
                this.Hide();
            }
            

            connection.Close();

            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new SignupForm().Show();
            this.Hide();
        }

        private void txtBox3_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text= "id name should be in 8 character";
        }

        private void txtBox4_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "password should be in 8 charcter and contain mathematical character(!,=)";
        }
    }
}
