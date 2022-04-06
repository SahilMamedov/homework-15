using Homework_15.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_15
{
    class User : IEntity
    {
        public int ID { get; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public Role Role { get; set; }
        public User(string username, string email,Role role)
        {
            UserName = username;
            Email = email;
            Role = role;
           
        }
        public void ShowInfo()
        {
            Console.WriteLine($"UserName: {UserName} Email: {Email}");
        }

    }
}
