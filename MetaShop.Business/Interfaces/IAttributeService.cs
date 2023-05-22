using MetaShop.Common;
using MetaShop.Common.Dtos;

namespace MetaShop.Business.Interfaces
{
    internal interface IAttributeService
    {
        Task<IEnumerable<AttributeDto>> GetAllAsync();

        Task<PagedResponseModel<AttributeDto>> PagedQueryAsync(string name, int page, int limit);

        Task<AttributeDto> GetByIdAsync(Guid id);

        Task<AttributeDto> GetByNameAsync(string name);

        Task<AttributeDto> AddAsync(AttributeDto attributeDto);

        Task DeleteAsync(Guid id);

        Task UpdateAsync(AttributeDto attributeDto);
    }
}
