using MetaShop.Common;
using MetaShop.Common.Dtos;

namespace MetaShop.Business.Interfaces
{
    public interface IProductInformationService
    {
        Task<IEnumerable<ProductInformationDto>> GetAllAsync();

        Task<PagedResponseModel<ProductInformationDto>> PagedQueryAsync(string name, int page, int limit);

        Task<ProductInformationDto> GetByIdAsync(Guid id);

        Task<ProductInformationDto> GetByNameAsync(string name);

        Task<ProductInformationDto> AddAsync(ProductInformationDto productInformationDto);

        Task DeleteAsync(Guid id);

        Task UpdateAsync(ProductInformationDto productInformationDto);
    }
}
