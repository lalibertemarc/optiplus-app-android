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
using SwimTimeTracker.Models.Models;
using System.Collections.ObjectModel;

namespace SwimTimeTracker.Forms.Views
{
    [DesignTimeVisible(false)]
    public partial class TimesPage : ContentPage
    {
        TimesViewModel viewModel;
        public TimesPage()
        {
            InitializeComponent();
            viewModel = new TimesViewModel();

            BindingContext = viewModel.Items;
            TimesListView.ItemsSource = viewModel.Items;
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

            if (viewModel.Items.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }
    }
}