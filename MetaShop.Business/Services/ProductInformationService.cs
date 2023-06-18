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
using ProductInformationEntity = MetaShop.DAL.Entities.ProductInformation;

namespace MetaShop.Business.Services
{
    public class ProductInformationService : IProductInformationService
    {
        private readonly IBaseRepository<ProductInformationEntity> _baseRepository;
        private IMapper _mapper;

        public ProductInformationService(IBaseRepository<ProductInformationEntity> baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }
        public async Task<ProductInformationDto> AddAsync(ProductInformationDto productInformationDto)
        {
            var attribute = _mapper.Map<ProductInformationEntity>(productInformationDto);
            var item = await _baseRepository.AddAsync(attribute);
            return _mapper.Map<ProductInformationDto>(item);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _baseRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<ProductInformationDto>> GetAllAsync()
        {
            var attributes = await _baseRepository.GetAllAsync();
            return _mapper.Map<List<ProductInformationDto>>(attributes);
        }

        public async Task<ProductInformationDto> GetByIdAsync(Guid id)
        {
            var attribute = await _baseRepository.GetByIdAsync(id);
            return _mapper.Map<ProductInformationDto>(attribute);
        }

        public async Task<ProductInformationDto> GetByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<PagedResponseModel<ProductInformationDto>> PagedQueryAsync(string name, int page, int limit)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(ProductInformationDto productInformationDto)
        {
            var attribute = _mapper.Map<ProductInformationEntity>(productInformationDto);
            await _baseRepository.UpdateAsync(attribute);
        }
    }
}
