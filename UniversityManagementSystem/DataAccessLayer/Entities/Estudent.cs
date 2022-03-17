using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Estudent
    {
        private string id,email, firstname, lastname, department, password;
        public string Id
        {
            set;
            get;
        }
        public string Email
        {
            set;
            get;
        }
        public string Firstname
        {
            set;
            get;
        }
        public string Lastname
        {
            set;
            get;
        }
        public string Department
        {
            set;
            get;
        }
        public string Password
        {
            set;
            get;
        }



    }
}
