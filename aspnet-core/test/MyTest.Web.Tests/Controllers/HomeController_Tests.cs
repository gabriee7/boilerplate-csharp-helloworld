using System.Threading.Tasks;
using MyTest.Models.TokenAuth;
using MyTest.Web.Controllers;
using Shouldly;
using Xunit;

namespace MyTest.Web.Tests.Controllers
{
    public class HomeController_Tests: MyTestWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}