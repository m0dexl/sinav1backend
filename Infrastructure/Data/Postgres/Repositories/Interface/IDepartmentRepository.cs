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
    public interface IDepartmentRepository : IRepository<Department,int>
    {
        Task<IList<Department>> GetAllDepartmentAsync(Expression<Func<Department,bool>>? filter = null);
        Task<IList<Department>> GetDepartmentByIdAsync(int id);
    }
}
