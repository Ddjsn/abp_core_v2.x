using abp_core_v2.x.EntityFrameworkCore;

namespace abp_core_v2.x.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly xDbContext _context;

        public TestDataBuilder(xDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}