using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Pandaloan.Models;

namespace Pandaloan.Models
{
    public class User
    {
        private string _password;
        CommonLib cl = new CommonLib();
        public int userID { get; set; }
        public string email { get; set; }
        public string password { get { return this._password; } set { this._password = cl.CreateMD5Hash(value); } }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zipcode { get; set; }
        public DateTime lastlogin { get; set; }
    }

    public class PandaloanDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}