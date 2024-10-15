using Nop.Core;
using Nop.Core.Domain.Custom;

namespace Nop.Services.Custom
{
    public interface ICustomService
    {
        Task<CustomTable> GetEntityByIdAsync(int entityId);
        Task InsertEntityAsync(CustomTable entity);
        Task UpdateEntityAsync(CustomTable entity);
        Task DeleteEntityAsync(CustomTable entity);
        Task<IPagedList<CustomTable>> GetAllEntitiesAsync(int pageIndex = 0, int pageSize = int.MaxValue);
    }
}

