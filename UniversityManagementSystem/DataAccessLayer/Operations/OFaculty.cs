using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Operations
{
    public class OFaculty
    {
        
        public int Insert2(EFaculty eFaculty)
        {
            SqlConnection connection = new SqlConnection("Data Source=PROMA\\PROMA01;Initial Catalog=Databaseconnection;Integrated Security=True");
            connection.Open();
            SqlCommand command1 = new SqlCommand("insert into FacultyTable(id,email,firstname,lastname,department,password)values('" + eFaculty.Id + "','" + eFaculty.Email + "','" + eFaculty.Firstname + "','" + eFaculty.Lastname + "','" + eFaculty.Department + "','" + eFaculty.Password + "')", connection);
            int check1 = command1.ExecuteNonQuery();
            connection.Close();
            return check1;
        }
    }
}
