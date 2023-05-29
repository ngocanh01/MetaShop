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
using CouponEntity = MetaShop.DAL.Entities.Coupon;

namespace MetaShop.Business.Services
{
    public class CouponService : ICouponService
    {
        private readonly IBaseRepository<CouponEntity> _baseRepository;
        private IMapper _mapper;

        public CouponService(IBaseRepository<CouponEntity> baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }
        public async Task<CouponDto> AddAsync(CouponDto couponDto)
        {
            var coupon = _mapper.Map<CouponEntity>(couponDto);
            var item = await _baseRepository.AddAsync(coupon);
            return _mapper.Map<CouponDto>(item);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _baseRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<CouponDto>> GetAllAsync()
        {
            var coupons = await _baseRepository.GetAllAsync();
            return _mapper.Map<List<CouponDto>>(coupons);
        }

        public async Task<CouponDto> GetByIdAsync(Guid id)
        {
            var coupon = await _baseRepository.GetByIdAsync(id);
            return _mapper.Map<CouponDto>(coupon);
        }

        public async Task<CouponDto> GetByCouponCodeAsync(string code)
        {
            var coupon = await _baseRepository.GetByAsync(x => x.CouponCode == code);
            return _mapper.Map<CouponDto>(coupon);
        }

        public async Task<PagedResponseModel<CouponDto>> PagedQueryAsync(string code, int page, int limit)
        {
            var query = _baseRepository.Entities;

            query = query.Where(x => string.IsNullOrEmpty(code) || x.CouponCode.Trim().ToLower().Contains(code.Trim().ToLower()));

            query = query.OrderBy(x => x.CouponCode);

            var coupons = await query.AsNoTracking().PaginateAsync(page, limit);

            return new PagedResponseModel<CouponDto>
            {
                CurrentPage = coupons.CurrentPage,
                TotalPages = coupons.TotalPages,
                TotalItems = coupons.TotalItems,
                Items = _mapper.Map<IEnumerable<CouponDto>>(coupons.Items)
            };
        }

        public async Task UpdateAsync(CouponDto couponDto)
        {
            var coupon = _mapper.Map<CouponEntity>(couponDto);
            await _baseRepository.UpdateAsync(coupon);
        }
    }
}
