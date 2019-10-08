
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
using Android.Support.V7.Widget;
using Android.Util;
using Android.Views;
using Android.Widget;
using Autofac;
using SwimTimeTracker.Adapters;
using SwimTimeTracker.Helpers;
using SwimTimeTracker.Services;
using SwimTimeTracker.ViewModels;
using static Android.Support.V7.Widget.RecyclerView;

namespace SwimTimeTracker.Fragments
{
    public class Swimmers_Fragment : Android.Support.V4.App.Fragment
    {
        [InjectView(Resource.Id.swimmersList)]
        RecyclerView _recyclerView;

        [InjectView(Resource.Id.progressBar)]
        ProgressBar _progressBar;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = inflater.Inflate(Resource.Layout.fragment, container, false);
            Cheeseknife.Inject(this, view);

            _progressBar.Visibility = ViewStates.Visible;
            var list = App.Container.Resolve<IApiService>().GetAllSwimmers();
            _progressBar.Visibility = ViewStates.Gone;
            var adapter = new SwimmerAdapter(list);

            adapter.OnItemClicked += Adapter_OnItemClicked;
            _recyclerView.SetAdapter(adapter);
            _recyclerView.HasFixedSize = true;
            _recyclerView.SetLayoutManager(new LinearLayoutManager(Activity));
            return view;
        }

        private void Adapter_OnItemClicked(object sender, SwimmerViewModel e)
        {
            throw new NotImplementedException();
        }

    }
}
