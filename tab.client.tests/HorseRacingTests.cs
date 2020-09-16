using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Xunit;

namespace tab.client.tests
{
    public class HorseRacingTests
    {
        private readonly TabClient client = new TabClient();

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
            var actual = await client.GetMeets(System.DateTime.Now);
            Assert.NotNull(actual);
        }

        [Fact]
        public async Task Should_Get_Todays_Races()
        {
            var actual = await client.GetTodaysRaces();
            Assert.NotNull(actual);
        }

        [Fact]
        public async Task Should_Get_Race()
        {
            var actual = await client.GetRace(DateTime.Now, "DBN", 8);
            Assert.NotNull(actual);
        }

        [Fact]
        public async Task Should_Get_Race_Runners()
        {
            var actual = await client.GetRunners(DateTime.Now, "DBN", 8);
            Assert.NotNull(actual);
        }

        [Fact]
        public async Task Should_Place_Bet()
        {
            await client.Authenticate(0, "");

            var bet = new Models.Bet.Bet();
            bet.Type = "FIXED_ODDS";
            bet.Stake = "$1.00";
            bet.Legs.Add(new Models.Bet.Leg() { Type="WIN", Odds="10.00", PropositionId=161082});
            List<Models.Bet.Bet> bets = new List<Models.Bet.Bet>(1);
            bets.Add(bet);

            await client.Bet(bets);

            //Assert.NotNull(actual);
        }

        [Fact]
        public async Task Should_Get_Recent_Transactions()
        {
            await client.Authenticate(0, "");
            var actual = await client.GetTransactions(DateTime.Now.AddDays(-1), DateTime.Now);

            Assert.NotNull(actual);
        }
    }
}
