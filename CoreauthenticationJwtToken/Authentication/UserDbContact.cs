using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CoreauthenticationJwtToken.Authentication
{
    public class UserDbContact:IdentityDbContext<UserAuthentication>
    {
        public UserDbContact(DbContextOptions<UserDbContact> options)
            :base(options)
        { 

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }


    }
}
