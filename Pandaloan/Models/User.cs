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
        public int userID { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
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