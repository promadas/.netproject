using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Operations
{
    public class Ostudent
    {
        
        public int Insert(Estudent eStudent)
        {
            SqlConnection connection = new SqlConnection("Data Source=PROMA\\PROMA01;Initial Catalog=Databaseconnection;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("insert into StudentTable(id,email,firstname,lastname,department,password)values('" + eStudent.Id + "','" + eStudent.Email + "','"+eStudent.Firstname+"','"+eStudent.Lastname+"','"+eStudent.Department+"','"+eStudent.Password+"')",connection);
            int check = command.ExecuteNonQuery();
            connection.Close();
            return check;
        }
        

    }
            
}
