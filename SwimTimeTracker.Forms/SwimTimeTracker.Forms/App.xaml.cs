using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SwimTimeTracker.Forms.Services;
using SwimTimeTracker.Forms.Views;
using Autofac;

namespace SwimTimeTracker.Forms
{
    public partial class App : Application
    {
        public static IContainer Container;
        public App()
        {
            InitializeComponent();
            var builder = new ContainerBuilder();
            builder.RegisterType<ApiService>().As<IApiService>();
            Container = builder.Build();
            //DependencyService.Register<MockDataStore>();
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
