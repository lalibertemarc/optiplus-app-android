using System;
using System.Collections.Generic;
using Android.Support.V7.Widget;
using SwimTimeTracker.Models.Models;

namespace SwimTimeTracker.personnal.ViewModels
{
    public interface IBaseViewModel
    {
        RecyclerView.Adapter GetAdapter();
    }
}
