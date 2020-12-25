using System;
using System.Threading.Tasks;
using Abp.TestBase;
using abp_core_v2.x.EntityFrameworkCore;
using abp_core_v2.x.Tests.TestDatas;

namespace abp_core_v2.x.Tests
{
    public class xTestBase : AbpIntegratedTestBase<xTestModule>
    {
        public xTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<xDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<xDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<xDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<xDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<xDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<xDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<xDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<xDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
