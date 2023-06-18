using MetaShop.Common.Dtos;
using MetaShop.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaShop.Business.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetAllAsync();

        Task<PagedResponseModel<ProductDto>> PagedQueryAsync(string name, int page, int limit);

        Task<ProductDto> GetByIdAsync(Guid id);

        Task<ProductDto> GetByNameAsync(string name);

        Task<ProductDto> AddAsync(ProductDto productDto);

        Task DeleteAsync(Guid id);

        Task UpdateAsync(ProductDto productDto);
    }
}
