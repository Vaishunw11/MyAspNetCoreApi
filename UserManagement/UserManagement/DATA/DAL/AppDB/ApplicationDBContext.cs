using Microsoft.EntityFrameworkCore;  
using UserManagement.Core.Entity;    
namespace UserManagement.DATA.DAL.AppDB
{
    public class ApplicationDBContext : DbContext   
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

        public DbSet<Users> user { get; set; }  
    }
}

