using AutoMapper;
using MetaShop.Business.Interfaces;
using MetaShop.Common;
using MetaShop.Common.Dtos;
using MetaShop.DAL.Entities;
using MetaShop.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderEntity = MetaShop.DAL.Entities.Order;

namespace MetaShop.Business.Services
{
    public class OrderService : IOrderService
    {
        private readonly IBaseRepository<OrderEntity> _baseRepository;
        private IMapper _mapper;

        public OrderService(IBaseRepository<OrderEntity> baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }
        public async Task<OrderDto> AddAsync(OrderDto orderDto)
        {
            var order = _mapper.Map<OrderEntity>(orderDto);
            var item = await _baseRepository.AddAsync(order);
            return _mapper.Map<OrderDto>(order);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _baseRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<OrderDto>> GetAllAsync()
        {
            var orders = await _baseRepository.GetAllAsync();
            return _mapper.Map<List<OrderDto>>(orders);
        }

        public async Task<OrderDto> GetByIdAsync(Guid id)
        {
            var order = await _baseRepository.GetByIdAsync(id);
            return _mapper.Map<OrderDto>(order);
        }

        public async Task<OrderDto> GetByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<PagedResponseModel<OrderDto>> PagedQueryAsync(string name, int page, int limit)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(OrderDto orderDto)
        {
            var order = _mapper.Map<OrderEntity>(orderDto);
            await _baseRepository.UpdateAsync(order);
        }
    }
}
