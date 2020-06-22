using ProWebSite.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProWebSite.Context
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DataContext")
        {

        }
        public virtual DbSet<Pessoa> Pessoas { get; set; }

    }
}