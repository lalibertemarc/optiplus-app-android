using System;
using System.Collections.Generic;
using Android.Support.V7.Widget;
using Android.Views;
using SwimTimeTracker.Models;

namespace SwimTimeTracker.Adapters
{
    public class SwimmerAdapter : RecyclerView.Adapter
    {
        List<Swimmer> _swimmers;

        public SwimmerAdapter(List<Swimmer> list)
        {
            _swimmers = list;
        }

        public override int ItemCount => _swimmers.Count;

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            throw new NotImplementedException();
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            throw new NotImplementedException();
        }
    }
}
