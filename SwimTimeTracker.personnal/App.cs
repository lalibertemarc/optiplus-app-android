﻿using System;
using Android.App;
using Android.Runtime;
using Autofac;

namespace SwimTimeTracker
{
    [Application(Icon = "@drawable/ic_launcher", Label = "@strings/ApplicationName")]
    public class App : Application
    {

        public App() : base()
        {
        }

        public App(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        public override void OnCreate()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new AutofacCustomModule());

            Container = builder.Build();

            //var config = ImageLoaderConfiguration.CreateDefault(Context);
            //ImageLoader.Instance.Init(config);

            base.OnCreate();
        }

        public static IContainer Container { get; set; }
    }
}
