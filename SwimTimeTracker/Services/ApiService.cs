using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using Org.Apache.Http.Impl.Client;
using SwimTimeTracker.Models;

namespace SwimTimeTracker.Services
{
    public interface IApiService
    {
        List<Time> GetAllTimes();
        List<Swimmer> GetAllSwimmers();
        List<Swim> GetAllSwims();
        List<Event> GetAllEvents();
        List<City> GetAllCities();
    }

    public class ApiService : IApiService
    {
        HttpClient client = new HttpClient();

        public List<City> GetAllCities()
        {
            List<City> model = null;
            var task = client.GetAsync("http://108.61.78.227:10500/read/cities")
              .ContinueWith((taskwithresponse) =>
              {
                  var response = taskwithresponse.Result;
                  var jsonString = response.Content.ReadAsStringAsync();
                  jsonString.Wait();
                  model = JsonConvert.DeserializeObject<List<City>>(jsonString.Result);

              });
            task.Wait();
            return model;
        }

        public List<Event> GetAllEvents()
        {
            List<Event> model = null;
            var task = client.GetAsync("http://108.61.78.227:10500/read/events")
              .ContinueWith((taskwithresponse) =>
              {
                  var response = taskwithresponse.Result;
                  var jsonString = response.Content.ReadAsStringAsync();
                  jsonString.Wait();
                  model = JsonConvert.DeserializeObject<List<Event>>(jsonString.Result);

              });
            task.Wait();
            return model;
        }

        public List<Swimmer> GetAllSwimmers()
        {
            List<Swimmer> model = null;
            var task = client.GetAsync("http://108.61.78.227:10500/read/swimmers")
              .ContinueWith((taskwithresponse) =>
              {
                  var response = taskwithresponse.Result;
                  var jsonString = response.Content.ReadAsStringAsync();
                  jsonString.Wait();
                  model = JsonConvert.DeserializeObject<List<Swimmer>>(jsonString.Result);

              });
            task.Wait();
            return model;
        }

        public List<Swim> GetAllSwims()
        {
            List<Swim> model = null;
            var task = client.GetAsync("http://108.61.78.227:10500/read/swims")
              .ContinueWith((taskwithresponse) =>
              {
                  var response = taskwithresponse.Result;
                  var jsonString = response.Content.ReadAsStringAsync();
                  jsonString.Wait();
                  model = JsonConvert.DeserializeObject<List<Swim>>(jsonString.Result);

              });
            task.Wait();
            return model;
        }

        public List<Time> GetAllTimes()
        {
            List<Time> model = null;
            var task = client.GetAsync("http://108.61.78.227:10500/read/times")
              .ContinueWith((taskwithresponse) =>
              {
                  var response = taskwithresponse.Result;
                  var jsonString = response.Content.ReadAsStringAsync();
                  jsonString.Wait();
                  model = JsonConvert.DeserializeObject<List<Time>>(jsonString.Result);

              });
            task.Wait();
            return model;
        }
    }
}
