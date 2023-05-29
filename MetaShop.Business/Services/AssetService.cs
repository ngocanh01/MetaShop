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
using AssetEnitty = MetaShop.DAL.Entities.Asset;

namespace MetaShop.Business.Services
{
    public class AssetService : IAssetService
    {
        private readonly IBaseRepository<AssetEnitty> _baseRepository;
        private IMapper _mapper;

        public AssetService(IBaseRepository<AssetEnitty> baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }
        public async Task<AssetDto> AddAsync(AssetDto assetDto)
        {
            var asset = _mapper.Map<AssetEnitty>(assetDto);
            var item = await _baseRepository.AddAsync(asset);
            return _mapper.Map<AssetDto>(item);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _baseRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<AssetDto>> GetAllAsync()
        {
            var assets = await _baseRepository.GetAllAsync();
            return _mapper.Map<List<AssetDto>>(assets);
        }

        public async Task<AssetDto> GetByIdAsync(Guid id)
        {
            var asset = await _baseRepository.GetByIdAsync(id);
            return _mapper.Map<AssetDto>(asset);
        }

        public async Task<AssetDto> GetByNameAsync(string filename)
        {
            var asset = await _baseRepository.GetByAsync(x => x.FileName == filename);
            return _mapper.Map<AssetDto>(asset);
        }

        public async Task<PagedResponseModel<AssetDto>> PagedQueryAsync(string filename, int page, int limit)
        {
            var query = _baseRepository.Entities;
            query = query.Where(x => string.IsNullOrEmpty(filename) || x.FileName.Trim().ToLower().Contains(filename.Trim().ToLower()));
            query = query.OrderBy(x => x.FileName);
            var assets = await query.AsNoTracking().PaginateAsync(page, limit);
            return new PagedResponseModel<AssetDto>
            {
                CurrentPage = assets.CurrentPage,
                TotalPages = assets.TotalPages,
                TotalItems = assets.TotalItems,
                Items = _mapper.Map<IEnumerable<AssetDto>>(assets.Items)
            };
        }

        public async Task UpdateAsync(AssetDto assetDto)
        {
            var asset = _mapper.Map<AssetEnitty>(assetDto);
            await _baseRepository.UpdateAsync(asset);
        }
    }
}
