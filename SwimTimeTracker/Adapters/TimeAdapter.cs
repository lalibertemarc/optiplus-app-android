using System;
using System.Collections.Generic;
using Android.Support.V7.Widget;
using Android.Views;
using SwimTimeTracker.ViewHolders;
using SwimTimeTracker.ViewModels;

namespace SwimTimeTracker.Adapters
{
    public class TimeAdapter : RecyclerView.Adapter
    {
        List<TimeViewModel> _events;
        public event EventHandler<TimeViewModel> OnItemClicked;

        public TimeAdapter(List<TimeViewModel> list)
        {
            _events = list;
        }

        public override int ItemCount => _events.Count;

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            var viewHolder = holder as ListItemViewHolder;
            viewHolder.Title.Text = _events[position].GetTime();
            viewHolder.SubTitle1.Text = _events[position].GetSwimmerName();
            viewHolder.SubTitle1.Visibility = ViewStates.Visible;
            viewHolder.SubTitle2.Text = _events[position].GetSwimmerAge();
            viewHolder.SubTitle2.Visibility = ViewStates.Visible;
            viewHolder.SubTitle3.Text = _events[position].GetCity();
            viewHolder.SubTitle3.Visibility = ViewStates.Visible;
            viewHolder.SubTitle4.Text = _events[position].GetDistance();
            viewHolder.SubTitle4.Visibility = ViewStates.Visible;
            viewHolder.SubTitle5.Text = _events[position].GetStyle();
            viewHolder.SubTitle5.Visibility = ViewStates.Visible;
            viewHolder.SubTitle7.Text = _events[position].GetDate();
            viewHolder.SubTitle7.Visibility = ViewStates.Visible;



            viewHolder.OnItemClicked += (args, e) =>
            {
                OnItemClicked?.Invoke(this, _events[position]);
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
