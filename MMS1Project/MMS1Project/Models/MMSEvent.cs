using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MMS1Project.Models
{
    public class MMSEvent
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Host { get; set; }
        public string Tags { get; set; }
        public string Related { get; set; }
    }

    public class MMSEventContext : DbContext
    {
        public DbSet<MMSEvent> MMSEvents { get; set; }
    }
}