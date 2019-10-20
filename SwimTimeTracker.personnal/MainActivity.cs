using System;
using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using SwimTimeTracker.Helpers;

namespace SwimTimeTracker.personnal
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        [InjectView(Resource.Id.bottom_navigation)]
        BottomNavigationView _bottomNavigationView;

        [InjectView(Resource.Id.content_frame)]
        FrameLayout _contentFrame;

        [InjectView(Resource.Id.progressBar)]
        LinearLayout _progressBarLayout;

        List<string> _fragmentTagsHistory;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);

            SetContentView(Resource.Layout.activity_main);
            Cheeseknife.Inject(this);
            SetToolbarInfo("Swim Time Tracker", string.Empty, false);
            _fragmentTagsHistory = new List<string>();
            _bottomNavigationView.NavigationItemSelected += BottomNavigationView_NavigationItemSelected;

        }

        private void BottomNavigationView_NavigationItemSelected(object sender, BottomNavigationView.NavigationItemSelectedEventArgs e)
        {
            switch (e.Item.ItemId)
            {
                case Resource.Id.menu_swimmers:
                    _progressBarLayout.Visibility = ViewStates.Visible;

                    break;
                case Resource.Id.menu_events:
                    _progressBarLayout.Visibility = ViewStates.Visible;

                    break;


            }
        }

        private void SwimmerFragment_OnDataLoaded(object sender, EventArgs e)
        {
            _progressBarLayout.Visibility = ViewStates.Gone;
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        public virtual void SetToolbarInfo(string title, string subTitle, bool showSubTitle)
        {
            SupportActionBar.Title = title;
            if (showSubTitle)
                SupportActionBar.Subtitle = subTitle;
        }

        void LoadFragment(Android.Support.V4.App.Fragment fragment)
        {
            // load fragment
            var transaction = SupportFragmentManager.BeginTransaction();
            transaction.Replace(Resource.Id.content_frame, fragment);
            transaction.AddToBackStack(null);
            transaction.Commit();
        }

        public Android.Support.V4.App.Fragment GetTopFragment()
        {
            string lastFragmentTag = _fragmentTagsHistory.Count > 0 ? _fragmentTagsHistory[_fragmentTagsHistory.Count - 1] : null;

            if (string.IsNullOrEmpty(lastFragmentTag))
                return null;

            return SupportFragmentManager.FindFragmentByTag(lastFragmentTag);
        }
        public void PopTopFragment()
        {
            var topFragment = GetTopFragment();
        }

        void ReleaseFragmentEvents(Android.Support.V4.App.Fragment fragment)
        {

        }
    }
}

