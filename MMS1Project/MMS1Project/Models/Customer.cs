using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MMS1Project.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Interests { get; set; }

    }
    public class CustomerDBContext : DbContext
    {
        public DbSet<Customer> Movies { get; set; }
    }
}