using System;
using System.Collections.Generic;
using Android.Support.V7.Widget;
using Android.Views;
using SwimTimeTracker.ViewHolders;
using SwimTimeTracker.ViewModels;

namespace SwimTimeTracker.Adapters
{
    public class EventAdapter : RecyclerView.Adapter
    {
        List<EventViewModel> _events;
        public event EventHandler<EventViewModel> OnItemClicked;

        public EventAdapter(List<EventViewModel> list)
        {
            _events = list;
        }

        public override int ItemCount => _events.Count;

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            var viewHolder = holder as ListItemViewHolder;
            viewHolder.Title.Text = _events[position].GetDescription();
            viewHolder.SubTitle1.Text = _events[position].GetCity();
            viewHolder.SubTitle1.Visibility = ViewStates.Visible;
            viewHolder.SubTitle2.Text = _events[position].GetStartDate();
            viewHolder.SubTitle2.Visibility = ViewStates.Visible;
            viewHolder.SubTitle8.Text = _events[position].GetEndDate();
            viewHolder.SubTitle8.Visibility = ViewStates.Visible;
            viewHolder.SubTitle4.Text = _events[position].GetLevel();
            viewHolder.SubTitle4.Visibility = ViewStates.Visible;

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
