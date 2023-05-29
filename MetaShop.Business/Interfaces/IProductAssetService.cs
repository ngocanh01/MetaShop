using MetaShop.Common.Dtos;
using MetaShop.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaShop.Business.Interfaces
{
    public interface IProductAssetService
    {
        Task<IEnumerable<ProductAssetDto>> GetAllAsync();

        Task<PagedResponseModel<ProductAssetDto>> PagedQueryAsync(string name, int page, int limit);

        Task<ProductAssetDto> GetByIdAsync(Guid id);

        Task<ProductAssetDto> GetByNameAsync(string name);

        Task<ProductAssetDto> AddAsync(ProductAssetDto productAssetDto);

        Task DeleteAsync(Guid id);

        Task UpdateAsync(ProductAssetDto productAssetDto);
    }
}
