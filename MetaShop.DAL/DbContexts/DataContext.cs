using MetaShop.DAL.Entities;
using MetaShop.DAL.EntityConfigurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaShop.DAL.DbContexts
{
    internal class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            #region table
            builder.ApplyConfiguration(new AffiliateEntityConfiguration());
            builder.ApplyConfiguration(new AssetEntityConfiguration());
            builder.ApplyConfiguration(new AttributeEntityConfiguration());
            builder.ApplyConfiguration(new CartEntityConfiguration());
            builder.ApplyConfiguration(new CartItemEntityConfiguration());
            builder.ApplyConfiguration(new CategoryEntityConfiguration());
            builder.ApplyConfiguration(new CouponEntityConfiguration());
            builder.ApplyConfiguration(new CustomerEntityConfiguration());
            builder.ApplyConfiguration(new OrderEntityConfiguration());
            builder.ApplyConfiguration(new OrderItemEntityConfiguration());
            builder.ApplyConfiguration(new ProductEntityConfiguration());
            builder.ApplyConfiguration(new ProductAssetEntityConfiguration());
            builder.ApplyConfiguration(new ProductInformationEntityConfiguration());
            builder.ApplyConfiguration(new ReviewEntityConfiguration());
            #endregion
        }

        public DbSet<Affiliate> Affiliates { get; set; }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<MetaShop.DAL.Entities.Attribute> Attributes { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductAsset> ProductAssets { get; set; }
        public DbSet<ProductInformation> ProductInformations { get; set; }
        public DbSet<Review> Reviews { get; set; }

    }
}
