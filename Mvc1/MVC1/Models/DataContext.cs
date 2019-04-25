using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC1.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection6")
        {

        }

        public System.Data.Entity.DbSet<MVC1.Models.Product> Products { get; set; }

        public System.Data.Entity.DbSet<MVC1.Models.Client> Clients { get; set; }

        public System.Data.Entity.DbSet<MVC1.Models.Sale> Sales { get; set; }
    }
}