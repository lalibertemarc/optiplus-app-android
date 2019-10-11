using System;
using Android.Text.Format;

namespace SwimTimeTracker.ViewModels
{
    public class TimeViewModel
    {
        int _id;
        int _distance;
        string _style;
        string _time;
        string _swimmerName;
        int _swimmerAge;
        string _city;
        DateTime _date;
        //eventName?

        public TimeViewModel(int id, int distance, string style, string time, string name, int age, string city, DateTime date)
        {
            _id = id;
            _distance = distance;
            _style = style;
            _time = time;
            _swimmerName = name;
            _swimmerAge = age;
            _city = city;
            _date = date;
        }

        public int GetId()
        {
            return _id;
        }
        public string GetDistance()
        {
            return _distance.ToString();
        }
        public string GetStyle()
        {
            return _style;
        }
        public string GetSwimmerName()
        {
            return _swimmerName;
        }
        public string GetSwimmerAge()
        {
            return _swimmerAge.ToString();
        }
        public string GetTime()
        {
            return _time;
        }
        public string GetCity()
        {
            return _city;
        }
        public string GetDate()
        {
            return _date.ToString();
        }

    }
}
