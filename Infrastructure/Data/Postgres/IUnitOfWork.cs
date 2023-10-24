using Infrastructure.Data.Postgres.Repositories.Interface;

namespace Infrastructure.Data.Postgres;

public interface IUnitOfWork : IDisposable
{
    IUserRepository Users { get; }
    IUserTokenRepository UserTokens { get; }
    IEmployeeRepository Employees { get; }
    IDepartmentRepository Departments { get; }

    Task<int> CommitAsync();
}