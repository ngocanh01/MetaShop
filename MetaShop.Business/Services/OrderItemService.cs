using AutoMapper;
using MetaShop.Business.Extensions;
using MetaShop.Business.Interfaces;
using MetaShop.Common;
using MetaShop.Common.Dtos;
using MetaShop.DAL.Entities;
using MetaShop.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderItemEntity = MetaShop.DAL.Entities.OrderItem;

namespace MetaShop.Business.Services
{
    public class OrderItemService : IOrderItemService
    {
        private readonly IBaseRepository<OrderItemEntity> _baseRepository;
        private IMapper _mapper;

        public OrderItemService(IBaseRepository<OrderItemEntity> baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }
        public async Task<OrderItemDto> AddAsync(OrderItemDto orderItemDto)
        {
            var orderItem = _mapper.Map<OrderItemEntity>(orderItemDto);
            var item = await _baseRepository.AddAsync(orderItem);
            return _mapper.Map<OrderItemDto>(item);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _baseRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<OrderItemDto>> GetAllAsync()
        {
            var orderItems = await _baseRepository.GetAllAsync();
            return _mapper.Map<List<OrderItemDto>>(orderItems);
        }

        public async Task<OrderItemDto> GetByIdAsync(Guid id)
        {
            var orderItem = await _baseRepository.GetByIdAsync(id);
            return _mapper.Map<OrderItemDto>(orderItem);
        }

        public async Task<OrderItemDto> GetByNameAsync(string name)
        {
            var orderItem = await _baseRepository.GetByAsync(x => x.Name == name);
            return _mapper.Map<OrderItemDto>(orderItem);
        }

        public async Task<PagedResponseModel<OrderItemDto>> PagedQueryAsync(string name, int page, int limit)
        {
            var query = _baseRepository.Entities;

            query = query.Where(x => string.IsNullOrEmpty(name) || x.Name.Trim().ToLower().Contains(name.Trim().ToLower()));

            query = query.OrderBy(x => x.Name);

            var orderItems = await query.AsNoTracking().PaginateAsync(page, limit);

            return new PagedResponseModel<OrderItemDto>
            {
                CurrentPage = orderItems.CurrentPage,
                TotalPages = orderItems.TotalPages,
                TotalItems = orderItems.TotalItems,
                Items = _mapper.Map<IEnumerable<OrderItemDto>>(orderItems.Items)
            };
        }

        public async Task UpdateAsync(OrderItemDto orderItemDto)
        {
            var orderItem = _mapper.Map<OrderItemEntity>(orderItemDto);
            await _baseRepository.UpdateAsync(orderItem);
        }
    }
}
