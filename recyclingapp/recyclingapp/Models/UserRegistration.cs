using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace recyclingapp.Models
{
    public class UserRegistration
    {
        [PrimaryKey, AutoIncrement]
        public int UserID { get; set; }
        public string Username  { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
