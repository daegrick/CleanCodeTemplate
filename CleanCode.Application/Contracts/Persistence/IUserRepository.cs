using CleanCode.Domain.Entities;

namespace CleanCode.Application.Contracts.Persistence
{
    internal interface IUserRepository : IAsyncRepository<User>
    {
    }
}
