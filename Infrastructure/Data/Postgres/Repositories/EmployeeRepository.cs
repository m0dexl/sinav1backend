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
    public class EmployeeRepository: Repository<Employee,int>, IEmployeeRepository
    {
        public EmployeeRepository(PostgresContext postgresContext): base(postgresContext) 
        { 
        
        }

        public virtual async Task<IList<Employee>> GetAllEmployeeAsync(Expression<Func<Employee, bool>>? filter = null)
        {
            return filter == null
                ? await PostgresContext.Set<Employee>().ToListAsync()
                : await PostgresContext.Set<Employee>().Where(filter).ToListAsync();
        }

        public async Task<IList<Employee>> GetEmployeeByIdAsync(int id)
        {

            var category = await PostgresContext.Employees
                .Where(c => c.Id == id)
                .ToListAsync();

            return category;
        }
    }
}
