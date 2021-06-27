using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSA.DL
{
    public class User
    {
        private string email { get; set; }
        private string password { get; set; }

        public User(string email, string password)
        {
            this.email = email;
            this.password = password;
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
