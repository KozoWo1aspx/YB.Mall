﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using YB.Mall.Model;
using YB.Mall.Data.Configurations;
namespace YB.Mall.Data
{
    public class MallContext : DbContext
    {
        public MallContext()
            : base("MallContext")
        {
        }
        public DbSet<UserInfo> UserInfo { get; set; }
        public DbSet<OrderInfo> OrderInfo { get; set; }
        public DbSet<OrderItemInfo> OrderItemInfo { get; set; }
        public DbSet<CategoryInfo> CategoryInfo { get; set; }
        public DbSet<ProductInfo> ProductInfo { get; set; }
        public DbSet<BrandInfo> BrandInfo { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserInfoConfiguration());
            modelBuilder.Configurations.Add(new CategoryInfoConfiguration());
            modelBuilder.Configurations.Add(new OrderInfoConfiguration());
            modelBuilder.Configurations.Add(new OrderItemInfoConfiguration());
            modelBuilder.Configurations.Add(new ProductInfoConfiguration());
            modelBuilder.Configurations.Add(new BrandInfoConfiguration());

        }
    }
    public class MallDbInitializer : DropCreateDatabaseIfModelChanges<MallContext>
    {

    }
}