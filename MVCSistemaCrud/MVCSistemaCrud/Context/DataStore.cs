using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVCSistemaCrud.Models;

namespace MVCSistemaCrud.Context
{
    public class DataStore:DbContext
    {
        public DbSet<Product> Products { set; get; }
}
}