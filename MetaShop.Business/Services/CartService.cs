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
using CartEntity = MetaShop.DAL.Entities.Cart;


namespace MetaShop.Business.Services
{
    public class CartService : ICartService
    {
        private readonly IBaseRepository<CartEntity> _baseRepository;
        private IMapper _mapper;

        public CartService(IBaseRepository<CartEntity> baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }
        public async Task<CartDto> AddAsync(CartDto cartDto)
        {
            var attribute = _mapper.Map<CartEntity>(cartDto);
            var item = await _baseRepository.AddAsync(attribute);
            return _mapper.Map<CartDto>(item);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _baseRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<CartDto>> GetAllAsync()
        {
            var carts = await _baseRepository.GetAllAsync();
            return _mapper.Map<List<CartDto>>(carts);
        }

        public async Task<CartDto> GetByIdAsync(Guid id)
        {
            var cart = await _baseRepository.GetByIdAsync(id);
            return _mapper.Map<CartDto>(cart);
        }

        public async Task<CartDto> GetByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<PagedResponseModel<CartDto>> PagedQueryAsync(string name, int page, int limit)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(CartDto cartDto)
        {
            var cart = _mapper.Map<CartEntity>(cartDto);
            await _baseRepository.UpdateAsync(cart);
        }
    }
}
