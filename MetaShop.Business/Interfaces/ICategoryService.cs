using MetaShop.Common;
using MetaShop.Common.Dtos;

namespace MetaShop.Business.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDto>> GetAllAsync();

        Task<PagedResponseModel<CategoryDto>> PagedQueryAsync(string name, int page, int limit);

        Task<CategoryDto> GetByIdAsync(Guid id);

        Task<CategoryDto> GetByNameAsync(string name);

        Task<CategoryDto> AddAsync(CategoryDto categoryDto);

        Task DeleteAsync(Guid id);

        Task UpdateAsync(CategoryDto categoryDto);
    }
}
