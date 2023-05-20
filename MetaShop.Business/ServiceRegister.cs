using MetaShop.DAL;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MetaShop.Business
{
    public static class ServiceRegister
    {
        public static void AddBusinessLayer(this IServiceCollection services, IConfiguration configuration)
        {
            //Register Services here
            //Scope, Transitent,Singleton
            services.AddDataAccessorLayer(configuration);
        }
    }
}
