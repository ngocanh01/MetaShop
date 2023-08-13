using MetaShop.Common.Dtos;
using MetaShop.Common.Dtos.Product;
using MetaShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MetaShop.Business
{
    public class AutoMapperProfile : AutoMapper.Profile
    {
        public AutoMapperProfile()
        {
            FromDataAccessorLayer();
            FromPresentationLayer();
        }

        private void FromPresentationLayer()
        {
        }

        private void FromDataAccessorLayer()
        {
            CreateMap<Affiliate, AffiliateDto>();
            CreateMap<Asset, AssetDto>();
            CreateMap<DAL.Entities.Attribute, AttributeDto>();
            CreateMap<CartItem, CartItemDto>();
            CreateMap<Cart, CartDto>();
            CreateMap<Category, CategoryDto>();
            CreateMap<Coupon, CouponDto>();
            CreateMap<Customer, CustomerDto>();
            CreateMap<OrderItem, OrderItemDto>();
            CreateMap<Order, OrderDto>();
            CreateMap<ProductAsset, ProductAssetDto>();
            CreateMap<ProductInformation, ProductInformationDto>();
            CreateMap<DAL.Entities.Product, ProductDto>();
        }
    }
}
