using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MMS1Project.Models
{
    public class Vendor1
    {
        public int Id { get; set; }
        public string VendorName { get; set; }
        public string VendorAddress { get; set; }
        public string URL { get; set; }
        public string VendorType { get; set; }
        public string Messages{ get; set; }
        public string email { get; set; }

    }

    public class VendorDBContext : DbContext
    {
        public DbSet<Vendor1> Vendor1s { get; set; }
    }
}