using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Api1.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnectionC")
        {

        }

        public System.Data.Entity.DbSet<Api1.Models.Product> Products { get; set; }

        public System.Data.Entity.DbSet<Api1.Models.Client> Clients { get; set; }

        public System.Data.Entity.DbSet<Api1.Models.Sale> Sales { get; set; }
    }
}