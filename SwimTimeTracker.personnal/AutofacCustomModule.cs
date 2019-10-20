using System;
using Autofac;
using SwimTimeTracker;
using SwimTimeTracker.Services;

namespace SwimTimeTracker
{
    public class AutofacCustomModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ApiService>().As<IApiService>().SingleInstance();
        }
    }
}
