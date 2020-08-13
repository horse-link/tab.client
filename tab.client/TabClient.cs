using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using tab.client.Models.Race;

namespace tab.client
{
    public class TabClient : IHorseRaceClient, IAuthenticationClient
    {
        private readonly Guid _transactionID;

        public String Token { get; set; }

        public Int32 AccountNumber { get; private set; }

        public String CustomerNumber { get; private set; }

        private readonly string _jurisdiction = "QLD";

        public TabClient()
        {
        }

        public TabClient(String token)
        {
            Token = token;
        }

        public TabClient(Guid transactionID, String token)
        {
            _transactionID = transactionID;
            Token = token;
        }

        public async Task Authenticate(Int32 accountNumber, String password)
        {
            using (HttpClient client = new HttpClient())
            {
                tab.client.Models.Authentication.Request request = new Models.Authentication.Request()
                {
                    accountNumber = accountNumber,
                    password = password,
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

        public async Task GetRace(DateTime date, string location, Int32 racenumber)
        {
            //WHERE LOCATION IS NMONIC
            
            using (HttpClient client = new HttpClient())
            {
                String url = String.Format("https://api.beta.tab.com.au/v1/tab-info-service/racing/dates/{0:yyyy-MM-dd}/meetings/R/{1}/races/{2}?returnPromo=false&returnOffers=false&jurisdiction=QLD", date, location, racenumber);
                var response = await client.GetAsync(url);
                var json = await response.Content.ReadAsStringAsync();

                var raceResponse = JsonConvert.DeserializeObject<Models.Race.Response>(json);
                return raceResponse;
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
                return raceResponse.runners;
            }
        }
    }
}