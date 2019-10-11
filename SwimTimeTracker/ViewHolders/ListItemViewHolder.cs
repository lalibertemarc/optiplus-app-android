using System;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using SwimTimeTracker.Helpers;

namespace SwimTimeTracker.ViewHolders
{
    public class ListItemViewHolder : RecyclerView.ViewHolder
    {
        public event EventHandler OnItemClicked;

        public ListItemViewHolder(View itemView) : base(itemView)
        {
            Cheeseknife.Inject(this, itemView);
            ItemView.Click += ItemView_Click;
        }

        private void ItemView_Click(object sender, EventArgs e)
        {
            OnItemClicked?.Invoke(this, null);
        }

        [InjectView(Resource.Id.list_item_title)]
        public TextView Title { get; set; }
        [InjectView(Resource.Id.list_item_subtitle1)]
        public TextView SubTitle1 { get; set; }
        [InjectView(Resource.Id.list_item_subtitle2)]
        public TextView SubTitle2 { get; set; }
        [InjectView(Resource.Id.list_item_subtitle3)]
        public TextView SubTitle3 { get; set; }
        [InjectView(Resource.Id.list_item_subtitle4)]
        public TextView SubTitle4 { get; set; }
        [InjectView(Resource.Id.list_item_subtitle5)]
        public TextView SubTitle5 { get; set; }
        [InjectView(Resource.Id.list_item_subtitle6)]
        public TextView SubTitle6 { get; set; }
        [InjectView(Resource.Id.list_item_subtitle7)]
        public TextView SubTitle7 { get; set; }
        [InjectView(Resource.Id.list_item_subtitle8)]
        public TextView SubTitle8 { get; set; }

    }
}
