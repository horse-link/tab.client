using System;
using System.Threading.Tasks;
using Xunit;

namespace tab.client.tests
{
    public class HorseRacingTests
    {
        [Fact]
        public async Task Should_Auth()
        {
            TabClient client = new TabClient(1, "");
            await client.Authenticate();

            Assert.NotNull(client.Token);
        }


        [Fact]
        public async Task Should_Get_Todays_Meets()
        {
            TabClient client = new TabClient();
            var actual = await client.GetMeets(System.DateTime.Now);

            Assert.NotNull(actual);
        }
    }
}
