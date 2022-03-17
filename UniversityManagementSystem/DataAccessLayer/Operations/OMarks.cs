using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Operations
{
    public class OMarks
    {
        public int Insert(EMarks eMarks)
        {
            SqlConnection connection = new SqlConnection("Data Source=PROMA\\PROMA01;Initial Catalog=Databaseconnection;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("insert into MarksTable(id,name,marks)values('" +eMarks.Id + "','" + eMarks.Name + "','" + eMarks.Marks+"')", connection);
            int check = command.ExecuteNonQuery();
            connection.Close();
            return check;
        }
        
        public int Delete(EMarks eMarks)
        {
            SqlConnection connection = new SqlConnection("Data Source=PROMA\\PROMA01;Initial Catalog=Databaseconnection;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("Delete from MarksTable where id='" + eMarks.Id + "'", connection);
            int check = command.ExecuteNonQuery();
            connection.Close();
            return check;
        }

       
        public SqlDataAdapter Show()
        {
            SqlConnection connection = new SqlConnection("Data Source=PROMA\\PROMA01;Initial Catalog=Databaseconnection;Integrated Security=True");
            connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from MarksTable", connection);
            connection.Close();
            return sqlDataAdapter;
        }
    }
}
