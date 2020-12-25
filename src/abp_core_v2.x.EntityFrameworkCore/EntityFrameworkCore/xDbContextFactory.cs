using abp_core_v2.x.Configuration;
using abp_core_v2.x.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace abp_core_v2.x.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class xDbContextFactory : IDesignTimeDbContextFactory<xDbContext>
    {
        public xDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<xDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(xConsts.ConnectionStringName)
            );

            return new xDbContext(builder.Options);
        }
    }
}