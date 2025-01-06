using MetaShop.Common;
using MetaShop.Common.Dtos;

namespace MetaShop.Business.Interfaces
{
    public interface ICouponService
    {
        Task<IEnumerable<CouponDto>> GetAllAsync();

        Task<PagedResponseModel<CouponDto>> PagedQueryAsync(string code, int page, int limit);

        Task<CouponDto> GetByIdAsync(Guid id);

        Task<CouponDto> GetByCouponCodeAsync(string code);

        Task<CouponDto> AddAsync(CouponDto couponDto);

        Task DeleteAsync(Guid id);

        Task UpdateAsync(CouponDto couponDto);
    }
}
