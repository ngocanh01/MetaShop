using AutoMapper;
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
using ReviewEntity = MetaShop.DAL.Entities.Review;

namespace MetaShop.Business.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IBaseRepository<ReviewEntity> _baseRepository;
        private IMapper _mapper;

        public ReviewService(IBaseRepository<ReviewEntity> baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }
        public async Task<ReviewDto> AddAsync(ReviewDto reviewDto)
        {
            var review = _mapper.Map<ReviewEntity>(reviewDto);
            var item = await _baseRepository.AddAsync(review);
            return _mapper.Map<ReviewDto>(item);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _baseRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<ReviewDto>> GetAllAsync()
        {
            var reviews = await _baseRepository.GetAllAsync();
            return _mapper.Map<List<ReviewDto>>(reviews);
        }

        public async Task<ReviewDto> GetByIdAsync(Guid id)
        {
            var review = await _baseRepository.GetByIdAsync(id);
            return _mapper.Map<ReviewDto>(review);
        }

        public async Task<ReviewDto> GetByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<PagedResponseModel<ReviewDto>> PagedQueryAsync(string name, int page, int limit)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(ReviewDto reviewDto)
        {
            var review = _mapper.Map<ReviewEntity>(reviewDto);
            await _baseRepository.UpdateAsync(review);
        }
    }
}
