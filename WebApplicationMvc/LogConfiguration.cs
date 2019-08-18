using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationMvc.Models;

namespace WebApplicationMvc
{
    public class LogConfiguration : IEntityTypeConfiguration<FilterModel>
    {
        public void Configure(EntityTypeBuilder<FilterModel> builder)
        {
            builder.ToTable("MVCLogs");
            builder.HasKey(_=>_.UserName);
        }
    }
}