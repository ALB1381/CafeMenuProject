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

        public DbSet<Role> Roles { get; set; }
        public DbSet<Sex> Sex { get; set; }
        public DbSet<RolePermissionConnection> RolePermissionConnections { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Permission> Permissions { get; set; }

    }
}
