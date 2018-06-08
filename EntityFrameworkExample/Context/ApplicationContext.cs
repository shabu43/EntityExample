using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using EntityFrameworkExample.Models;

namespace EntityFrameworkExample.Context
{
    public class ApplicationContext : DbContext

    {
        public DbSet<University> Universities { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}