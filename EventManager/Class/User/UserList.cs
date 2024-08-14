using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager
{
    public static class UserList
    {
        private static List<User> _users = new List<User>();
        public static List<User> users
        {
            get => _users;
            set => _users = value;
        }
    }
}
