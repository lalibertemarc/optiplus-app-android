using System;
using System.Collections.Generic;
using Android.Support.V7.Widget;
using Android.Views;
using SwimTimeTracker.Models;
using SwimTimeTracker.ViewHolders;
using SwimTimeTracker.ViewModels;

namespace SwimTimeTracker.Adapters
{
    public class SwimmerAdapter : RecyclerView.Adapter
    {
        List<SwimmerViewModel> _swimmers;
        public event EventHandler<SwimmerViewModel> OnItemClicked;

        public SwimmerAdapter(List<SwimmerViewModel> list)
        {
            _swimmers = list;
        }

        public override int ItemCount => _swimmers.Count;

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            var viewHolder = holder as ListItemViewHolder;
            viewHolder.Title.Text = _swimmers[position].GetName();
            viewHolder.SubTitle1.Text = _swimmers[position].GetCoachName();
            viewHolder.SubTitle1.Visibility = ViewStates.Visible;
            viewHolder.SubTitle2.Text = _swimmers[position].GetSex();
            viewHolder.SubTitle2.Visibility = ViewStates.Visible;

            viewHolder.OnItemClicked += (args, e) =>
            {
                OnItemClicked?.Invoke(this, _swimmers[position]);
            };
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            var view = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.list_item_viewHolder, parent, false);
            var viewHolder = new ListItemViewHolder(view);
            return viewHolder;
        }
    }
}
