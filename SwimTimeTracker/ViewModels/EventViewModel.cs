using System;
using Android.Arch.Lifecycle;

namespace SwimTimeTracker.ViewModels
{
    public class EventViewModel : ViewModel
    {
        int _id;
        string _description;
        DateTime _startDate;
        DateTime _endDate;
        string _city;
        string _level;

        public EventViewModel(int id, string description, DateTime startDate, DateTime endDate, string city, string level)
        {
            _id = id;
            _description = description;
            _startDate = startDate;
            _endDate = endDate;
            _city = city;
            _level = level;
        }

        public int GetId()
        {
            return _id;
        }
        public string GetDescription()
        {
            return _description;
        }
        public string GetStartDate()
        {
            return _startDate.ToString();
        }
        public string GetEndDate()
        {
            return _endDate.ToString();
        }
        public string GetCity()
        {
            return _city;
        }
        public string GetLevel()
        {
            return _level;
        }

    }
}
