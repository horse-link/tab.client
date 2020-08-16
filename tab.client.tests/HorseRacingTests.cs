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
            IAuthenticationClient client = new TabClient();
            await client.Authenticate(0, "");

            Assert.NotNull(client.Token);
        }


        [Fact]
        public async Task Should_Get_Todays_Meets()
        {
            TabClient client = new TabClient();
            var actual = await client.GetMeets(System.DateTime.Now);

            Assert.NotNull(actual);
        }

        [Fact]
        public async Task Should_Get_Todays_Races()
        {
            TabClient client = new TabClient();
            var actual = await client.GetTodaysRaces();

            Assert.NotNull(actual);
        }
    }
}
