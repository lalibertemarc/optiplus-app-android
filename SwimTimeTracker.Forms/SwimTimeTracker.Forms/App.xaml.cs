using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SwimTimeTracker.Forms.Services;
using SwimTimeTracker.Forms.Views;
using System.ComponentModel;

namespace SwimTimeTracker.Forms
{
    public partial class App : Application
    {
        static IContainer container;
        //static readonly ContainerBuilder builder = new ContainerBuilder();

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
