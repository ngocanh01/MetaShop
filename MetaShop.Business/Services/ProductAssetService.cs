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
using ProductAssetEntity = MetaShop.DAL.Entities.ProductAsset;

namespace MetaShop.Business.Services
{
    public class ProductAssetService : IProductAssetService
    {
        private readonly IBaseRepository<ProductAssetEntity> _baseRepository;
        private IMapper _mapper;

        public ProductAssetService(IBaseRepository<ProductAssetEntity> baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }
        public async Task<ProductAssetDto> AddAsync(ProductAssetDto productAssetDto)
        {
            var productAsset = _mapper.Map<ProductAssetEntity>(productAssetDto);
            var item = await _baseRepository.AddAsync(productAsset);
            return _mapper.Map<ProductAssetDto>(item);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _baseRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<ProductAssetDto>> GetAllAsync()
        {
            var productAssets = await _baseRepository.GetAllAsync();
            return _mapper.Map<List<ProductAssetDto>>(productAssets);
        }

        public async Task<ProductAssetDto> GetByIdAsync(Guid id)
        {
            var productAsset = await _baseRepository.GetByIdAsync(id);
            return _mapper.Map<ProductAssetDto>(productAsset);
        }

        public async Task<ProductAssetDto> GetByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<PagedResponseModel<ProductAssetDto>> PagedQueryAsync(string name, int page, int limit)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(ProductAssetDto productAssetDto)
        {
            var productAsset = _mapper.Map<ProductAssetEntity>(productAssetDto);
            await _baseRepository.UpdateAsync(productAsset);
        }
    }
}
