using MetaShop.Common.Dtos;
using MetaShop.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
