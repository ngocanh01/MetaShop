using AutoMapper;
using MetaShop.Business.Extensions;
using MetaShop.Business.Interfaces;
using MetaShop.Common;
using MetaShop.Common.Dtos;
using MetaShop.DAL;
using MetaShop.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Net;
using AttributeEntity = MetaShop.DAL.Entities.Attribute;

namespace MetaShop.Business.Services
{
    public class AttributeService : IAttributeService
    {
        private readonly IBaseRepository<AttributeEntity> _baseRepository;
        private IMapper _mapper;

        public AttributeService(IBaseRepository<AttributeEntity> baseRepository, IMapper mapper) 
        { 
            _baseRepository = baseRepository; 
            _mapper = mapper;
        }

        public async Task<AttributeDto> AddAsync(AttributeDto attributeDto)
        {
            var attribute = _mapper.Map<AttributeEntity>(attributeDto);
            var item = await _baseRepository.AddAsync(attribute);
            return _mapper.Map<AttributeDto>(item);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _baseRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<AttributeDto>> GetAllAsync()
        {
            var attributes = await _baseRepository.GetAllAsync();
            return _mapper.Map<List<AttributeDto>>(attributes);
        }

        public async Task<AttributeDto> GetByIdAsync(Guid id)
        {
            var attribute = await _baseRepository.GetByIdAsync(id);
            return _mapper.Map<AttributeDto>(attribute);
        }

        public async Task<AttributeDto> GetByNameAsync(string name)
        {
            var attribute = await _baseRepository.GetByAsync(x => x.Name == name);
            return _mapper.Map<AttributeDto>(attribute);
        }

        public async Task<PagedResponseModel<AttributeDto>> PagedQueryAsync(string name, int page, int limit)
        {
            var query = _baseRepository.Entities;

            query = query.Where(x => string.IsNullOrEmpty(name) || x.Name.Trim().ToLower().Contains(name.Trim().ToLower()));

            query = query.OrderBy(x => x.Name);

            var attributes = await query.AsNoTracking().PaginateAsync(page, limit);

            return new PagedResponseModel<AttributeDto>
            {
                CurrentPage = attributes.CurrentPage,
                TotalPages = attributes.TotalPages,
                TotalItems = attributes.TotalItems,
                Items = _mapper.Map<IEnumerable<AttributeDto>>(attributes.Items)
            };
        }

        public async Task UpdateAsync(AttributeDto attributeDto)
        {
            var attribute = _mapper.Map<AttributeEntity>(attributeDto);
            await _baseRepository.UpdateAsync(attribute);
        }
    }
}
