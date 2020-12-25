using Abp.EntityFrameworkCore;
using abp_core_v2.x.Tasks;
using Microsoft.EntityFrameworkCore;

namespace abp_core_v2.x.EntityFrameworkCore
{
    public class xDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...
        public DbSet<Task> Tasks { get; set; }

        public xDbContext(DbContextOptions<xDbContext> options) 
            : base(options)
        {

        }
    }
}
