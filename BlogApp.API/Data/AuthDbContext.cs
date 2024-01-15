using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.API.Data
{
    public class AuthDbContext : IdentityDbContext
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var readerRoleId = "1e917e2f-f7f4-43f0-bad1-810530c727de";
            var writerRoleId = "ed485741-f84f-47fc-8854-dec5a5fe9bee";

            //create reader/writer roles
            var roles = new List<IdentityRole>
            {
                new IdentityRole()
                {
                    Id = readerRoleId,
                    Name = "Reader",
                    NormalizedName = "Reader".ToUpper(),
                    ConcurrencyStamp = readerRoleId
                },
                new IdentityRole()
                {
                    Id = writerRoleId,
                    Name = "Writer",
                    NormalizedName = "Writer".ToUpper(),
                    ConcurrencyStamp = writerRoleId
                }
            };


            //seed the roles
            builder.Entity<IdentityRole>().HasData(roles);

            //create an admin user
            var adminUserId = "910823b0-4612-4442-9c23-2ed73e64c953";
            var admin = new IdentityUser()
            {
                Id = adminUserId,
                UserName = "admin@blogapp.com",
                Email = "admin@blogapp.com",
                NormalizedEmail = "admin@blogapp.com".ToUpper(),
                NormalizedUserName = "admin@blogapp.com".ToUpper(),
            };

            admin.PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(admin, "Admin@123");

            builder.Entity<IdentityUser>().HasData(admin);

            //give roles to the admin user
            var adminRoles = new List<IdentityUserRole<string>>()
            {
                new()
                {
                    UserId = adminUserId,
                    RoleId = readerRoleId
                },
                new()
                {
                    UserId = adminUserId,
                    RoleId = writerRoleId
                },
            };

            builder.Entity<IdentityUserRole<string>>().HasData(adminRoles);
        }
    }
}
