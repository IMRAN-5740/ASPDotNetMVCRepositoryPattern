using ASPDotNetMVCRepositoryApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASPDotNetMVCRepositoryApp.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext() : base("connectionString")
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}