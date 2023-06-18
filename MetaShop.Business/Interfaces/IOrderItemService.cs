using MetaShop.Common.Dtos;
using MetaShop.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaShop.Business.Interfaces
{
    public interface IOrderItemService
    {
        Task<IEnumerable<OrderItemDto>> GetAllAsync();

        Task<PagedResponseModel<OrderItemDto>> PagedQueryAsync(string name, int page, int limit);

        Task<OrderItemDto> GetByIdAsync(Guid id);

        Task<OrderItemDto> GetByNameAsync(string name);

        Task<OrderItemDto> AddAsync(OrderItemDto orderItemDto);

        Task DeleteAsync(Guid id);

        Task UpdateAsync(OrderItemDto orderItemDto);
    }
}
