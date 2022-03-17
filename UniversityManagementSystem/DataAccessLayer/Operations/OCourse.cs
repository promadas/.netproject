using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Operations
{
    public class OCourse
    {
        SqlConnection connection = new SqlConnection("Data Source=PROMA\\PROMA01;Initial Catalog=Databaseconnection;Integrated Security=True");

        public int Insert1(ECourse eCourse)
        {

            connection.Open();
            SqlCommand command = new SqlCommand("insert into RegistrationTable(classid,courses,section)values('" + eCourse.Classid + "','" + eCourse.Courses + "','" + eCourse.Section + "')", connection);
            int check = command.ExecuteNonQuery();
            connection.Close();
            return check;
        }
        
    }
}

