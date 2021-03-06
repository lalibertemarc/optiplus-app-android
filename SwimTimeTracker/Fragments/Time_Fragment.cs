﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Arch.Lifecycle;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V4.Widget;
using Android.Support.V7.Widget;
using Android.Util;
using Android.Views;
using Android.Widget;
using Autofac;
using SwimTimeTracker.Adapters;
using SwimTimeTracker.Helpers;
using SwimTimeTracker.Services;
using SwimTimeTracker.ViewModels;

namespace SwimTimeTracker.Fragments
{
    public class Time_Fragment : Android.Support.V4.App.Fragment
    {
        [InjectView(Resource.Id.swimmersList)]
        RecyclerView _recyclerView;

        [InjectView(Resource.Id.fab)]
        FloatingActionButton _floatingActionButton;

        [InjectView(Resource.Id.listRefresher)]
        SwipeRefreshLayout _refresher;

        TimeAdapter _adapter;

        List<TimeViewModel> _list;

        public event EventHandler OnDataLoaded;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = inflater.Inflate(Resource.Layout.fragment, container, false);
            Cheeseknife.Inject(this, view);

            _list = App.Container.Resolve<IApiService>().GetAllTimes();
            _adapter = new TimeAdapter(_list);

            _adapter.OnItemClicked += Adapter_OnItemClicked;
            _recyclerView.SetAdapter(_adapter);
            _recyclerView.HasFixedSize = true;
            _recyclerView.SetLayoutManager(new LinearLayoutManager(Activity));

            OnDataLoaded?.Invoke(this, null);

            _refresher.Refresh += Refresher_OnRefresh;
            _floatingActionButton.Visibility = ViewStates.Visible;
            return view;
        }

        private void Refresher_OnRefresh(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void Adapter_OnItemClicked(object sender, TimeViewModel e)
        {
            throw new NotImplementedException();
        }

    }
}
