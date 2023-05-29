using AutoMapper;
using MetaShop.Business.Interfaces;
using MetaShop.Common;
using MetaShop.Common.Dtos;
using MetaShop.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CartItemEntity = MetaShop.DAL.Entities.CartItem;

namespace MetaShop.Business.Services
{
    public class CartItemSerivce : ICartItemService
    {
        private readonly IBaseRepository<CartItemEntity> _baseRepository;
        private IMapper _mapper;

        public CartItemSerivce(IBaseRepository<CartItemEntity> baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }
        public async Task<CartItemDto> AddAsync(CartItemDto cartItemDto)
        {
            var cartItem = _mapper.Map<CartItemEntity>(cartItemDto);
            var item = await _baseRepository.AddAsync(cartItem);
            return _mapper.Map<CartItemDto>(item);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _baseRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<CartItemDto>> GetAllAsync()
        {
            var cartItem = await _baseRepository.GetAllAsync();
            return _mapper.Map<List<CartItemDto>>(cartItem);
        }

        public async Task<CartItemDto> GetByIdAsync(Guid id)
        {
            var cartItem = await _baseRepository.GetByIdAsync(id);
            return _mapper.Map<CartItemDto>(cartItem);
        }

        public Task<CartItemDto> GetByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResponseModel<CartItemDto>> PagedQueryAsync(string name, int page, int limit)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(CartItemDto cartItemDto)
        {
            var cartItem = _mapper.Map<CartItemEntity>(cartItemDto);
            await _baseRepository.UpdateAsync(cartItem);
        }
    }
}
