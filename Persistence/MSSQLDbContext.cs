using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Persistence.Models;

namespace Persistence
{
    public class MSSQLDbContext : IdentityDbContext
    {
        public MSSQLDbContext(DbContextOptions<MSSQLDbContext> options)
            : base(options)
        {

        }


        #region DBSets
             




        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        









       
    }
}
