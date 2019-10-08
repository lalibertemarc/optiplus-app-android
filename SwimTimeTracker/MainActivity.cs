using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Support.Design.Widget;
using SwimTimeTracker.Helpers;
using System.Collections.Generic;
using System;
using SwimTimeTracker.Fragments;

namespace SwimTimeTracker
{
    [Activity(Label = "MainActivity", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        [InjectView(Resource.Id.bottom_navigation)]
        BottomNavigationView _bottomNavigationView;

        [InjectView(Resource.Id.content_frame)]
        FrameLayout _contentFrame;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            Cheeseknife.Inject(this);
            SetToolbarInfo("Swim Time Tracker", string.Empty, false);
            _bottomNavigationView.NavigationItemSelected += BottomNavigationView_NavigationItemSelected;

        }

        private void BottomNavigationView_NavigationItemSelected(object sender, BottomNavigationView.NavigationItemSelectedEventArgs e)
        {
            switch (e.Item.ItemId)
            {
                case Resource.Id.menu_swimmers:
                    var swimmerFragment = new Swimmers_Fragment();
                    LoadFragment(swimmerFragment);
                    break;
                case Resource.Id.menu_events:
                    break;
                case Resource.Id.menu_time:
                    break;
                case Resource.Id.menu_records:
                    break;

            }
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

        private void LoadFragment(Android.Support.V4.App.Fragment fragment)
        {
            // load fragment
            var transaction = SupportFragmentManager.BeginTransaction();
            transaction.Replace(Resource.Id.content_frame, fragment);
            transaction.AddToBackStack(null);
            transaction.Commit();
        }
    }
}