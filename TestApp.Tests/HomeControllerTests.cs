using TestApp.Controllers;
using Xunit;

namespace TestApp.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void DoesExist()
        {
            var controller = new HomeController();

            Assert.NotNull(controller);
        }
    }
}
