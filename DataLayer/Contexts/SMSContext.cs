using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DataLayer.Models;

namespace DataLayer.Contexts
{
    public class SMSContext : DbContext
    {
        public SMSContext()
        {
            
        }
        public DbSet<IncomingSMS> IncomingMessages { get; set; }
    }
}
