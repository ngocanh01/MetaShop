using AutoMapper;
using MetaShop.Business.Extensions;
using MetaShop.Business.Interfaces;
using MetaShop.Common;
using MetaShop.Common.Dtos;
using MetaShop.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductEntity = MetaShop.DAL.Entities.Product;

namespace MetaShop.Business.Services
{

    public class ProductService : IProductService
    {
        private readonly IBaseRepository<ProductEntity> _baseRepository;
        private IMapper _mapper;

        public ProductService(IBaseRepository<ProductEntity> baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }
        public async Task<ProductDto> AddAsync(ProductDto productDto)
        {
            var product = _mapper.Map<ProductEntity>(productDto);
            var item = await _baseRepository.AddAsync(product);
            return _mapper.Map<ProductDto>(item);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _baseRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<ProductDto>> GetAllAsync()
        {
            var products = await _baseRepository.GetAllAsync();
            return _mapper.Map<List<ProductDto>>(products);
        }

        public async Task<ProductDto> GetByIdAsync(Guid id)
        {
            var product = await _baseRepository.GetByIdAsync(id);
            return _mapper.Map<ProductDto>(product);
        }

        public async Task<ProductDto> GetByNameAsync(string name)
        {
            var product = await _baseRepository.GetByAsync(x => x.Name == name);
            return _mapper.Map<ProductDto>(product);
        }

        public async Task<PagedResponseModel<ProductDto>> PagedQueryAsync(string name, int page, int limit)
        {
            var query = _baseRepository.Entities;

            query = query.Where(x => string.IsNullOrEmpty(name) || x.Name.Trim().ToLower().Contains(name.Trim().ToLower()));

            query = query.OrderBy(x => x.Name);

            var products = await query.AsNoTracking().PaginateAsync(page, limit);

            return new PagedResponseModel<ProductDto>
            {
                CurrentPage = products.CurrentPage,
                TotalPages = products.TotalPages,
                TotalItems = products.TotalItems,
                Items = _mapper.Map<IEnumerable<ProductDto>>(products.Items)
            };
        }

        public async Task UpdateAsync(ProductDto productDto)
        {
            var product = _mapper.Map<ProductEntity>(productDto);
            await _baseRepository.UpdateAsync(product);
        }
    }
}
