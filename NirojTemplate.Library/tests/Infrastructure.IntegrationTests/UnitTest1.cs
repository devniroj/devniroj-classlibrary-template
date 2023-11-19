using NirojTemplate.Library.Infrastructure.IntegrationTests.Configurations;

namespace NirojTemplate.Library.Infrastructure.IntegrationTests
{
    public class UnitTest1:IClassFixture<InjectionFixture>
    {
        private readonly InjectionFixture _injection;
        public UnitTest1(InjectionFixture injection)
        {
            _injection = injection;
        }
        //test comment
        [Fact]
        public void Test1()
        {

        }
    }
}