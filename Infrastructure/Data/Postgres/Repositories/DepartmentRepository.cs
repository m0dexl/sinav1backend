using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Repositories
{
    public class DepartmentRepository : Repository<Department,int>, IDepartmentRepository
    {
        public DepartmentRepository(PostgresContext postgresContext) : base(postgresContext)
        {

        }

        public virtual async Task<IList<Department>> GetAllDepartmentAsync(Expression<Func<Department, bool>>? filter = null)
        {
            return filter == null
                ? await PostgresContext.Set<Department>().ToListAsync()
                : await PostgresContext.Set<Department>().Where(filter).ToListAsync();
        }

        public async Task<IList<Department>> GetDepartmentByIdAsync(int id)
        {

            var category = await PostgresContext.Departments
                .Where(c => c.Id == id)
                .ToListAsync();

            return category;
        }
    }
}
