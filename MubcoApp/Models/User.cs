using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MubcoApp.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }

    public class UserInit
    {
        public static List<User> Init()
        {
            return new List<User> {
            new User { UserID = 1, UserName = "Admin", Password = "1234", Role = "a" },
            new User { UserID = 2, UserName = "User2", Password = "User2", Role = "u" },
            new User { UserID = 3, UserName = "User3", Password = "User3", Role = "u" }
            };
        }
    }
}
