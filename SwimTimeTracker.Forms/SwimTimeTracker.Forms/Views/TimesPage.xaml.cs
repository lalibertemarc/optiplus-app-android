using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using SwimTimeTracker.Forms.Models;
using SwimTimeTracker.Forms.Views;
using SwimTimeTracker.Forms.ViewModels;

namespace SwimTimeTracker.Forms.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class TimesPage : ContentPage
    {
        TimesViewModel viewModel;

        public TimesPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new TimesViewModel();
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Item;
            if (item == null)
                return;

            await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));

            // Manually deselect item.
            TimesListView.SelectedItem = null;
        }

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewTimePage()));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Times.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }
    }
}