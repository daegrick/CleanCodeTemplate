using CleanCode.Domain.Common;

namespace CleanCode.Application.Contracts.Persistence
{
    public interface IAsyncRepository<T> where T : RecordBase
    {
        Task<T> GetAsync(Guid UID);
        Task<T> SaveAsync(T entity);
        Task<T> DeleteAsync(T entity);
        Task<IReadOnlyCollection<T>> ListAllAsync();
    }
}
