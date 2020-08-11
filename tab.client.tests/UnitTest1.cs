using System;
using System.Threading.Tasks;
using Xunit;

namespace tab.client.tests
{
    public class UnitTest1
    {
        [Fact]
        public async Task Should_Auth()
        {
            TabClient client = new TabClient(1, "");
            await client.Authenticate();
        }
    }
}
