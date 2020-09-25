using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BeAFuckingSenior.Models;

namespace BeAFuckingSenior.Context
{
    public class BafsContext : DbContext
    {
        public BafsContext()
            : base("BafsContext")
        {

        }

        public DbSet<Client> Clients { get; set; }
    }
}