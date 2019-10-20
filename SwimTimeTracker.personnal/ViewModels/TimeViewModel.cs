using System;
using System.Collections.Generic;
using Android.Arch.Lifecycle;
using Autofac;
using SwimTimeTracker.Models;
using SwimTimeTracker.Services;

namespace SwimTimeTracker.personnal.ViewModels
{
    public class TimeViewModel : ViewModel
    {
        private List<Time> _times;


        public List<Time> GetTimes()
        {
            if (_times == null)
            {
                LoadTimes();
            }
            return _times;
        }

        private void LoadTimes()
        {
            _times = App.Container.Resolve<IApiService>().GetAllTimesForSwimmer(38);
        }
    }
}
