using MetaShop.Common;
using MetaShop.Common.Dtos;

namespace MetaShop.Business.Interfaces
{
    public interface ICustomerService
    {
        Task<IEnumerable<CustomerDto>> GetAllAsync();

        Task<PagedResponseModel<CustomerDto>> PagedQueryAsync(string name, int page, int limit);

        Task<CustomerDto> GetByIdAsync(Guid id);

        Task<CustomerDto> GetByNameAsync(string name);

        Task<CustomerDto> AddAsync(CustomerDto customerDto);

        Task DeleteAsync(Guid id);

        Task UpdateAsync(CustomerDto customerDto);
    }
}
