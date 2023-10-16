using MetaShop.Common;
using MetaShop.Common.Dtos;

namespace MetaShop.Business.Interfaces
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderDto>> GetAllAsync();

        Task<PagedResponseModel<OrderDto>> PagedQueryAsync(string name, int page, int limit);

        Task<OrderDto> GetByIdAsync(Guid id);

        Task<OrderDto> GetByNameAsync(string name);

        Task<OrderDto> AddAsync(OrderDto orderDto);

        Task DeleteAsync(Guid id);

        Task UpdateAsync(OrderDto orderDto);
    }
}
