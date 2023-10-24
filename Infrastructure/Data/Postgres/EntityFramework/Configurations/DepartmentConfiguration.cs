using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework.Configurations.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class DepartmentConfiguration : BaseConfiguration<Department,int>
    {
        public override void Configure(EntityTypeBuilder<Department> builder)
        {
            base.Configure(builder);

            builder.HasKey(d => d.Id);

            builder.Property(d => d.Department_Name).IsRequired();
            builder.HasIndex(d => d.Department_Name).IsUnique();

        }
    }
}
