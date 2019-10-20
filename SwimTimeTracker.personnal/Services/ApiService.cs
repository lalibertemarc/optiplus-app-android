using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using SwimTimeTracker.Models.Models;

namespace SwimTimeTracker.Services
{
    public interface IApiService
    {
        List<Time> GetAllTimes();
        List<Swimmer> GetAllSwimmers();
        List<Swim> GetAllSwims();
        List<Event> GetAllEvents();
        List<City> GetAllCities();
        List<Time> GetAllTimesForSwimmer(int swimmerId);
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
            //var output = new List<EventViewModel>();
            //model.ForEach(item => { output.Add(new EventViewModel(item.Id, item.Description, item.Start_Date, item.End_Date, item.City, item.Level)); });
            //return output;
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

            //var output = new List<SwimmerViewModel>();
            //model.ForEach(swimmer => { output.Add(new SwimmerViewModel(swimmer.Id, swimmer.Name, swimmer.Sexe, swimmer.CoachName)); });
            //return output;
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
            //var output = new List<TimeViewModel>();
            //model.ForEach(time => { output.Add(new TimeViewModel(time.Id, time.Distance, time.Style, time.ActualTime, time.Name, time.Age, time.City, time.Date)); }); ;
            //return output;
            return model;
        }
        public List<Time> GetAllTimesForSwimmer(int swimmerId)
        {
            List<Time> model = null;
            var task = client.GetAsync($"http://108.61.78.227:10500/read/times/{swimmerId}")
              .ContinueWith((taskwithresponse) =>
              {
                  var response = taskwithresponse.Result;
                  var jsonString = response.Content.ReadAsStringAsync();
                  jsonString.Wait();
                  model = JsonConvert.DeserializeObject<List<Time>>(jsonString.Result);

              });
            task.Wait();
            //var output = new List<TimeViewModel>();
            //model.ForEach(time => { output.Add(new TimeViewModel(time.Id, time.Distance, time.Style, time.ActualTime, time.Name, time.Age, time.City, time.Date)); }); ;
            //return output;
            return model;
        }
    }
}
