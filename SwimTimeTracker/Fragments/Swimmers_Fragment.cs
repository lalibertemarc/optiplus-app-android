
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
    public class Swimmers_Fragment : Android.Support.V4.App.Fragment
    {
        [InjectView(Resource.Id.swimmersList)]
        RecyclerView _recyclerView;

        [InjectView(Resource.Id.fab)]
        FloatingActionButton _floatingActionButton;

        public event EventHandler OnDataLoaded;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = inflater.Inflate(Resource.Layout.fragment, container, false);
            Cheeseknife.Inject(this, view);

            var list = App.Container.Resolve<IApiService>().GetAllSwimmers();
            var adapter = new SwimmerAdapter(list);

            adapter.OnItemClicked += Adapter_OnItemClicked;
            _recyclerView.SetAdapter(adapter);
            _recyclerView.HasFixedSize = true;
            _recyclerView.SetLayoutManager(new LinearLayoutManager(Activity));

            OnDataLoaded?.Invoke(this, null);
            _floatingActionButton.Visibility = ViewStates.Visible;
            return view;
        }

        void Adapter_OnItemClicked(object sender, SwimmerViewModel e)
        {
            throw new NotImplementedException();
        }

    }
}
