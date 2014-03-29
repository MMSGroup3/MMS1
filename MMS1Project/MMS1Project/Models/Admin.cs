using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MMS1Project.Models
{
    public class Admin1
    {
        public int Id { get; set; }
        public string userName { get; set; }
        public string Password { get; set; }
    }

    public class AdminDBContext : DbContext
    {
        public DbSet<Admin1> Admin1s { get; set; }
    }
}