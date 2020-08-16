using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace tab.client
{
    public interface IHorseRaceClient
    {
        Task<IEnumerable<Models.Meeting.Meeting>> GetMeets(DateTime date);

        //Task GetRaces(DateTime date, String location);
    }
}