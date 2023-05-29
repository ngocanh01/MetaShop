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
using CategoryEntity = MetaShop.DAL.Entities.Category;

namespace MetaShop.Business.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IBaseRepository<CategoryEntity> _baseRepository;
        private IMapper _mapper;

        public CategoryService(IBaseRepository<CategoryEntity> baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }
        public async Task<CategoryDto> AddAsync(CategoryDto categoryDto)
        {
            var attribute = _mapper.Map<CategoryEntity>(categoryDto);
            var item = await _baseRepository.AddAsync(attribute);
            return _mapper.Map<CategoryDto>(item);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _baseRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<CategoryDto>> GetAllAsync()
        {
            var categories = await _baseRepository.GetAllAsync();
            return _mapper.Map<List<CategoryDto>>(categories);
        }

        public async Task<CategoryDto> GetByIdAsync(Guid id)
        {
            var category = await _baseRepository.GetByIdAsync(id);
            return _mapper.Map<CategoryDto>(category);
        }

        public async Task<CategoryDto> GetByNameAsync(string name)
        {
            var category = await _baseRepository.GetByAsync(x => x.Name == name);
            return _mapper.Map<CategoryDto>(category);
        }

        public async Task<PagedResponseModel<CategoryDto>> PagedQueryAsync(string name, int page, int limit)
        {
            var query = _baseRepository.Entities;

            query = query.Where(x => string.IsNullOrEmpty(name) || x.Name.Trim().ToLower().Contains(name.Trim().ToLower()));

            query = query.OrderBy(x => x.Name);

            var categories = await query.AsNoTracking().PaginateAsync(page, limit);

            return new PagedResponseModel<CategoryDto>
            {
                CurrentPage = categories.CurrentPage,
                TotalPages = categories.TotalPages,
                TotalItems = categories.TotalItems,
                Items = _mapper.Map<IEnumerable<CategoryDto>>(categories.Items)
            };
        }

        public async Task UpdateAsync(CategoryDto categoryDto)
        {
            var category = _mapper.Map<CategoryEntity>(categoryDto);
            await _baseRepository.UpdateAsync(category);
        }
    }
}
