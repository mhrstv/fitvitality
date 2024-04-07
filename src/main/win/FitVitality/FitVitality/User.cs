using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitVitality
{
    internal class User
    {
        public string Id;
        public string Username;
        public User(string id, string username)
        {
            Id = id;
            Username = username;
        }
    }
}
