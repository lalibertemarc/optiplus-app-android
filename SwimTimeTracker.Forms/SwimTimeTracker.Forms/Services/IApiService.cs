using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using SwimTimeTracker.Models.Models;

namespace SwimTimeTracker.Forms.Services
{
    public interface IApiService
    {
        List<Time> GetAllTimes();
        List<Swimmer> GetAllSwimmers();
        List<Swim> GetAllSwims();
        List<Event> GetAllEvents();
        List<City> GetAllCities();
        List<Time> GetAllTimesForSwimmer(int swimmerId);

        void AddTime(Time time);
    }
}
