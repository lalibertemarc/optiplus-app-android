using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;
using SwimTimeTracker.Models.Models;

namespace SwimTimeTracker.Forms.Views
{
    [DesignTimeVisible(false)]
    public partial class NewTimePage : ContentPage
    {
        public Time Time { get; set; }

        public NewTimePage()
        {
            InitializeComponent();

            Time = new Time
            {
                Distance = 0,
                Style = "",
                ActualTime = "",
                Date = DateTime.Now,
                City = ""

            };

            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddTime", Time);
            await Navigation.PopModalAsync();
        }

        async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

    }
}
