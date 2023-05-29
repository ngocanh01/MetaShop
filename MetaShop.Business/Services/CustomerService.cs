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
using CustomerEntity = MetaShop.DAL.Entities.Customer;

namespace MetaShop.Business.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly IBaseRepository<CustomerEntity> _baseRepository;
        private IMapper _mapper;

        public CustomerService(IBaseRepository<CustomerEntity> baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }
        public async Task<CustomerDto> AddAsync(CustomerDto customerDto)
        {
            var customer = _mapper.Map<CustomerEntity>(customerDto);
            var item = await _baseRepository.AddAsync(customer);
            return _mapper.Map<CustomerDto>(item);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _baseRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<CustomerDto>> GetAllAsync()
        {
            var customers = await _baseRepository.GetAllAsync();
            return _mapper.Map<List<CustomerDto>>(customers);
        }

        public async Task<CustomerDto> GetByIdAsync(Guid id)
        {
            var customer = await _baseRepository.GetByIdAsync(id);
            return _mapper.Map<CustomerDto>(customer);
        }

        public async Task<CustomerDto> GetByNameAsync(string name)
        {
            var customer = await _baseRepository.GetByAsync(x => x.FirstName == name);
            return _mapper.Map<CustomerDto>(customer);
        }

        public async Task<PagedResponseModel<CustomerDto>> PagedQueryAsync(string name, int page, int limit)
        {
            var query = _baseRepository.Entities;

            query = query.Where(x => string.IsNullOrEmpty(name) || x.FirstName.Trim().ToLower().Contains(name.Trim().ToLower()));

            query = query.OrderBy(x => x.FirstName);

            var customers = await query.AsNoTracking().PaginateAsync(page, limit);

            return new PagedResponseModel<CustomerDto>
            {
                CurrentPage = customers.CurrentPage,
                TotalPages = customers.TotalPages,
                TotalItems = customers.TotalItems,
                Items = _mapper.Map<IEnumerable<CustomerDto>>(customers.Items)
            };
        }

        public async Task UpdateAsync(CustomerDto customerDto)
        {
            var customer = _mapper.Map<CustomerEntity>(customerDto);
            await _baseRepository.UpdateAsync(customer);
        }
    }
}
