using System;
using System.Collections.Generic;
using Android.Arch.Lifecycle;
using Android.Support.V7.Widget;
using Autofac;
using Java.Lang;
using SwimTimeTracker.Models.Models;
using SwimTimeTracker.Services;

namespace SwimTimeTracker.personnal.ViewModels
{
    public class TimeViewModel : ViewModel, IBaseViewModel
    {
        private List<Time> _times;

        public RecyclerView.Adapter GetAdapter()
        {
            throw new NotImplementedException();
        }

        public List<Time> GetItems()
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

    public class TimeViewModelFactory : Java.Lang.Object, ViewModelProvider.IFactory
    {
        public Java.Lang.Object Create(Class p0)
        {
            return new TimeViewModel();
        }
    }
}
