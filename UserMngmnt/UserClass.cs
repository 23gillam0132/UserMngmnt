using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserMngmnt
{
    public class User
    {
        public string user;
        public string pass;

        public User(string user, string pass)
        {
            this.user = user;
            this.pass = pass;
        }
    }
    public class Guest : User
    {
        public Guest(string user, string pass) : base(user, pass)
        {
        }
    }
    public class Administrator : User
    {
        public Administrator(string user, string pass) : base(user, pass)
        {
        }
    }
}
