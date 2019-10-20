
using Android.App;
using Android.OS;
using Android.Support.V7.Widget;
using Android.Views;
using System.Collections.Generic;
using Android.Support.V4.App;
using Android.Widget;
using SwimTimeTracker.personnal.Helpers;
using SwimTimeTracker.personnal.ViewModels;
using Android.Support.Design.Widget;
using Android.Support.V4.Widget;
using Android.Arch.Lifecycle;

namespace SwimTimeTracker.personnal.fragments
{
    public class TimeFragment : Android.Support.V4.App.Fragment
    {
        [InjectView(Resource.Id.mainList)]
        RecyclerView _recyclerView;

        [InjectView(Resource.Id.fab)]
        FloatingActionButton _floatingActionButton;

        [InjectView(Resource.Id.listRefresher)]
        SwipeRefreshLayout _refresher;

        TimeViewModel _timeViewModel;

        public override void OnCreate(Bundle savedInstanceState)
        {


        }
        // Create your fragment here

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = inflater.Inflate(Resource.Layout.fragment, container, false);
            Cheeseknife.Inject(this, view);

            return view;
        }
    }
}
