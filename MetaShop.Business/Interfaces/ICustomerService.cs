using MetaShop.Common.Dtos;
using MetaShop.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
