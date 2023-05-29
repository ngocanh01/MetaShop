using MetaShop.Common.Dtos;
using MetaShop.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaShop.Business.Interfaces
{
    public interface ICartService
    {
        Task<IEnumerable<CartDto>> GetAllAsync();

        Task<PagedResponseModel<CartDto>> PagedQueryAsync(string name, int page, int limit);

        Task<CartDto> GetByIdAsync(Guid id);

        Task<CartDto> GetByNameAsync(string name);

        Task<CartDto> AddAsync(CartDto cartDto);

        Task DeleteAsync(Guid id);

        Task UpdateAsync(CartDto cartDto);
    }
}
