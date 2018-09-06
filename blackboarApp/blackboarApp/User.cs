using System;
using System.Collections.Generic;
using System.Text;

namespace blackboarApp
{
    class User
    {
        public string UserName { get; set; }
        public string Password { get; set;}

        public User() { }
        public User(string Username, string Password)
        {
            this.UserName = Username;
            this.Password = Password;
        }
    }
}
