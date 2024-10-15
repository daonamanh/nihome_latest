using Nop.Core;
using Nop.Core.Domain.Custom;
using Nop.Data;
using System.Threading.Tasks;

namespace Nop.Services.Custom
{
    public class CustomService : ICustomService
    {
        private readonly IRepository<CustomTable> _customEntityRepository;

        public CustomService(IRepository<CustomTable> customEntityRepository)
        {
            _customEntityRepository = customEntityRepository;
        }

        public async Task<CustomTable> GetEntityByIdAsync(int entityId)
        {
            return await _customEntityRepository.GetByIdAsync(entityId);
        }

        public async Task InsertEntityAsync(CustomTable entity)
        {
            await _customEntityRepository.InsertAsync(entity);
        }

        public async Task UpdateEntityAsync(CustomTable entity)
        {
            await _customEntityRepository.UpdateAsync(entity);
        }

        public async Task DeleteEntityAsync(CustomTable entity)
        {
            await _customEntityRepository.DeleteAsync(entity);
        }

        public async Task<IPagedList<CustomTable>> GetAllEntitiesAsync(int pageIndex = 0, int pageSize = int.MaxValue)
        {
            return await _customEntityRepository.GetAllPagedAsync(query =>
            {
                return query.OrderBy(e => e.Name);
            }, pageIndex, pageSize);
        }
    }
}

