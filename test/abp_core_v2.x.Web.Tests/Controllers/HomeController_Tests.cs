using System.Threading.Tasks;
using abp_core_v2.x.Web.Controllers;
using Shouldly;
using Xunit;

namespace abp_core_v2.x.Web.Tests.Controllers
{
    public class HomeController_Tests: xWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
