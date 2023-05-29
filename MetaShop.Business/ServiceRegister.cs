using MetaShop.Business.Interfaces;
using MetaShop.Business.Services;
using MetaShop.DAL;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace MetaShop.Business
{
    public static class ServiceRegister
    {
        public static void AddBusinessLayer(this IServiceCollection services, IConfiguration configuration)
        {
            //Register Services here
            //Scope, Transitent,Singleton
            services.AddDataAccessorLayer(configuration);
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddTransient<IAttributeService, AttributeService>();
            services.AddTransient<IAffiliateService, AffiliateService>();
            services.AddTransient<IAssetService, AssetService>();
            services.AddTransient<ICartItemService, CartItemSerivce>();
            services.AddTransient<ICartService, CartService>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<ICouponService, CouponService>();
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<IOrderItemService, OrderItemService>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IProductAssetService, ProductAssetService>();
            services.AddTransient<IProductInformationService, ProductInformationService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IReviewService, ReviewService>();

        }
    }
}
