using CafeMenu.Data.Entities;
using CafeMenu.Data.Entities.Customers;
using CafeMenu.Data.Entities.Discount;
using CafeMenu.Data.Entities.Order;
using CafeMenu.Data.Entities.Product;
using CafeMenu.Data.Entities.User;
using CafeMenu.Data.Entities.User.Connections;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu.Data.Context
{
    public class CafeContext : DbContext
    {
        public CafeContext(DbContextOptions<CafeContext> options) : base(options){

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerSex> CustomerSexes { get; set; }
        public DbSet<CustomerPhoneNumber> CustomerPhoneNumbers { get; set; }


        public DbSet<OrderDiscount> OrderDiscounts { get; set; }
        public DbSet<ProductModelDiscount> ProductModelDiscounts { get; set; }


        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderTax> OrderTaxes { get; set; }
        public DbSet<OrderType> OrderTypes { get; set; }
        public DbSet<SubOrder> SubOrders { get; set; }
        public DbSet<Table> Tables { get; set; }


        public DbSet<ExteraProduct> ExteraProducts { get; set; }
        public DbSet<ExteraProductSubOrderConnection> ExteraProductSubOrderConnections { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductExteraConnection> ProductExteraConnections { get; set; }
        public DbSet<ProductGroup> ProductGroups { get; set; }
        public DbSet<ProductModel> ProductModels { get; set; }


        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Sex> Sexes { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<RolePermissionConnection> RolePermissionConnections { get; set; }



        public DbSet<DeleteHistory> DeleteHistories { get; set; }




    }
}
