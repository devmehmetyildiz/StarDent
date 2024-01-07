using Microsoft.EntityFrameworkCore;
using StarDentApi.Entities;

namespace StarDentApi.Repositories
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        //Auth
        public DbSet<AccesstokenEntity> Accesstokens { get; set; }
        public DbSet<RoleEntity> Roles { get; set; }
        public DbSet<RoleprivilegeEntity> Roleprivileges { get; set; }
        public DbSet<TablemetaconfigEntity> Tablemetaconfigs { get; set; }
        public DbSet<UserEntity> Users { get; set; }

    }
}
