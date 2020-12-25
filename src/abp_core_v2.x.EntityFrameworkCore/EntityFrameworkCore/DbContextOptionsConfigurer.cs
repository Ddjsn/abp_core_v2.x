using Microsoft.EntityFrameworkCore;

namespace abp_core_v2.x.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<xDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for xDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
