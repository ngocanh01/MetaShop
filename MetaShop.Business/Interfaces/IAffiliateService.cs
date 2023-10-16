using MetaShop.Common;
using MetaShop.Common.Dtos;

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
