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
using AffiliateEntity = MetaShop.DAL.Entities.Affiliate;

namespace MetaShop.Business.Services
{
    internal class AffiliateService : IAffiliateService
    {
        private readonly IBaseRepository<AffiliateEntity> _baseRepository;
        private IMapper _mapper;

        public AffiliateService(IBaseRepository<AffiliateEntity> baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }

        public async Task<AffiliateDto> AddAsync(AffiliateDto affiliateDto)
        {
            var affiliate = _mapper.Map<AffiliateEntity>(affiliateDto);
            var item = await _baseRepository.AddAsync(affiliate);
            return _mapper.Map<AffiliateDto>(item);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _baseRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<AffiliateDto>> GetAllAsync()
        {
            var affiliates = await _baseRepository.GetAllAsync();
            return _mapper.Map<List<AffiliateDto>>(affiliates);
        }

        public async Task<AffiliateDto> GetByIdAsync(Guid id)
        {
            var affiliate = await _baseRepository.GetByIdAsync(id);
            return _mapper.Map<AffiliateDto>(affiliate);
        }

        public async Task<AffiliateDto> GetByCodeAsync(string code)
        {
            var affiliate = await _baseRepository.GetByAsync(x => x.Code == code);
            return _mapper.Map<AffiliateDto>(affiliate);
        }

        public async Task<PagedResponseModel<AffiliateDto>> PagedQueryAsync(string code, int page, int limit)
        {
            var query = _baseRepository.Entities;

            query = query.Where(x => string.IsNullOrEmpty(code) || x.Code.Trim().ToLower().Contains(code.Trim().ToLower()));

            query = query.OrderBy(x => x.Code);
            
            var affiliates = await query.AsNoTracking().PaginateAsync(page, limit);

            return new PagedResponseModel<AffiliateDto>
            {
                CurrentPage = affiliates.CurrentPage,
                TotalPages = affiliates.TotalPages,
                TotalItems = affiliates.TotalItems,
                Items = _mapper.Map<IEnumerable<AffiliateDto>>(affiliates.Items)
            };
        }

        public async Task UpdateAsync(AffiliateDto affiliateDto)
        {
            var affiliate = _mapper.Map<AffiliateEntity>(affiliateDto);
            await _baseRepository.UpdateAsync(affiliate);
        }
    }
}
