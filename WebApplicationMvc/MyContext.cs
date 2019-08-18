using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationMvc.Models;

namespace WebApplicationMvc
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
        }

        public virtual DbSet<FilterModel> LogFilter { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        { 
            base.OnModelCreating(builder.
                ApplyConfiguration(new LogConfiguration()));
        }
    }
}