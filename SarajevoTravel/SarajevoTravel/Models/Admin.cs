using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarajevoTravel.Models
{
    class Admin
    {
        public string username { get => username; set => username = value; }
        public string password { get => password; set => password = value; }

        public Admin(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

       
    }
}
