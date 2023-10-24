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
    public class EmployeeConfiguration : BaseConfiguration<Employee,int>
    {
        public override void Configure(EntityTypeBuilder<Employee> builder)
        {
            base.Configure(builder);

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Date_Of_Birth).IsRequired();
            builder.Property(e => e.Phone_Number).IsRequired();
            builder.HasIndex(e => e.Phone_Number).IsUnique();
            builder.Property(e => e.User_Id).IsRequired();
            builder.Property(e => e.Department_Id).IsRequired();

            builder.HasOne(e => e.Department)
                .WithMany(d => d.Employees)
                .HasForeignKey(e => e.Department_Id);
        }
    }
}
