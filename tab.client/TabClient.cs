using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using tab.client.Models.Race;

namespace tab.client
{
    public class TabClient : IHorseRaceClient
    {
        private readonly Guid _transactionID;

        public String Token { get; set; }

        public Int32 AccountNumber { get; private set; }

        public String CustomerNumber { get; private set; }

        private readonly string _jurisdiction = "QLD";

        private readonly string _username;

        private readonly string _password;

        public TabClient()
        {
        }

        public TabClient(String token)
        {
            Token = token;
        }

        // public TabClient(Guid transactionID, String token)
        // {
        //     _transactionID = transactionID;
        //     Token = token;
        // }

        public TabClient(Int32 accountNumber, String password)
        {
            AccountNumber = accountNumber;
            _password = password;
        }

        public async Task Authenticate()
        {
            using (HttpClient client = new HttpClient())
            {
                tab.client.Models.Authentication.Request request = new Models.Authentication.Request()
                {
                    accountNumber = AccountNumber,
                    password = _password,
                    tmxSession = Guid.NewGuid(),
                    channel = "TABCOMAU",
                    extendedTokenLifeTime = true
                };

                const String url = "https://webapi.tab.com.au/v1/account-service/tab/authenticate";
                String jsonRequest = JsonConvert.SerializeObject(request);
                StringContent content = new StringContent(jsonRequest, UnicodeEncoding.UTF8, "application/json");

                var result = await client.PostAsync(url, content);
                var json = await result.Content.ReadAsStringAsync();

                var response = JsonConvert.DeserializeObject<Models.Authentication.Response>(json);

                this.Token = response.authentication.token;
            }
        }

        public async Task Bet()
        {
            using (HttpClient client = new HttpClient())
            {
                String url = String.Format("https://webapi.tab.com.au/v1/tab-betting-service/accounts/{0}/betslip?TabcorpAuth={1}", AccountNumber, Token);
                var response = await client.GetAsync(url);
                var json = await response.Content.ReadAsStringAsync();


                // List<Meet> meetings = new List<Meet>();
                // foreach(Models.TAB.Meeting meeting in meetingResponse.Meetings)
                // {
                //     meetings.Add(new Meet() { Location = meeting.Location, Name = meeting.MeetingName });
                // }
            }
        }

        public async Task<IEnumerable<Models.Meeting.Meeting>> GetMeets(DateTime date)
        {
            using (HttpClient client = new HttpClient())
            {
                String url = String.Format("https://api.beta.tab.com.au/v1/tab-info-service/racing/dates/{0:yyyy-MM-dd}/meetings?jurisdiction=QLD", date);
                var response = await client.GetAsync(url);
                var json = await response.Content.ReadAsStringAsync();

                var meetingResponse = JsonConvert.DeserializeObject<Models.Meeting.Response>(json);
                return meetingResponse.Meetings;
            }
        }

        public async Task GetRaces(DateTime date, string location)
        {
            //WHERE LOCATION IS NMONIC
            
            using (HttpClient client = new HttpClient())
            {
                String url = String.Format("https://api.beta.tab.com.au/v1/tab-info-service/racing/dates/{0:yyyy-MM-dd}/meetings/R/{1}/races/1?returnPromo=false&returnOffers=false&jurisdiction=QLD", date, location);
                var response = await client.GetAsync(url);
                var json = await response.Content.ReadAsStringAsync();

                var raceResponse = JsonConvert.DeserializeObject<Models.Race.Response>(json);

                // List<Meet> meetings = new List<Meet>();
                // foreach(Models.TAB.Meeting meeting in meetingResponse.Meetings)
                // {
                //     meetings.Add(new Meet() { Location = meeting.Location, Name = meeting.MeetingName });
                // }

                // return meetings;
            }
        }


        public async Task<List<Runner>> GetRunners(DateTime date, string location, int number)
        {
            //WHERE LOCATION IS MNEMONIC
            
            using (HttpClient client = new HttpClient())
            {
                String url = String.Format("https://api.beta.tab.com.au/v1/tab-info-service/racing/dates/{0:yyyy-MM-dd}/meetings/R/{1}/races/{2}?returnPromo=false&returnOffers=false&jurisdiction=QLD", date, location, number);
                var response = await client.GetAsync(url);
                var json = await response.Content.ReadAsStringAsync();

                var raceResponse = JsonConvert.DeserializeObject<Models.Race.Response>(json);

                // List<Runner> runners = new List<Runner>();
                // foreach(Models.TAB.Race.Runner runner in raceResponse.runners)
                // {
                //     runners.Add(new Runner() { Name = runner.runnerName, Number = runner.runnerNumber, Barrier = runner.barrierNumber});
                // }

                return raceResponse.runners;
            }
        }
    }
}