using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLibrary;

namespace unit_test_moive
{
    public class MockUser : iUser
    {
        private List<UserClass> users;
        public MockUser()
        {
            users = new List<UserClass>();
        }

        public bool CreateUser(UserClass user)
        {
            users.Add(user);
            return user != null;
        }

        public bool DeleteUser(int id)
        {
            return true;
        }

        public UserClass Login(UserClass user)
        {
            users.Add(user);
            return user;
        }

        public List<UserClass> ReturnAllUsers()
        {
           return users;
        }

        public bool UpdateUser(UserClass user)
        {
            return true;
        }

    }
}
