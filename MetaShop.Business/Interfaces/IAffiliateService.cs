using MetaShop.Common;
using MetaShop.Common.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaShop.Business.Interfaces
{
    public interface IAffiliateService
    {
        Task<IEnumerable<AffiliateDto>> GetAllAsync();

        Task<PagedResponseModel<AffiliateDto>> PagedQueryAsync(string code, int page, int limit);

        Task<AffiliateDto> GetByIdAsync(Guid id);

        Task<AffiliateDto> GetByCodeAsync(string code);

        Task<AffiliateDto> AddAsync(AffiliateDto affiliateDto);

        Task UpdateAsync(AffiliateDto affiliateDto);

        Task DeleteAsync(Guid id);
    }
}
