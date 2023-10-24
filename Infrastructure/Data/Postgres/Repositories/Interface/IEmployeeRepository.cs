using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.Repositories.Base.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Repositories.Interface
{
    public interface IEmployeeRepository : IRepository<Employee,int>
    {
        Task<IList<Employee>> GetAllEmployeeAsync(Expression<Func<Employee,bool>>? filter = null);
        Task<IList<Employee>> GetEmployeeByIdAsync(int id);
    }
}
