using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using SwimTimeTracker.Forms.Services;
using SwimTimeTracker.Forms.Views;
using SwimTimeTracker.Models.Models;
using Xamarin.Forms;


namespace SwimTimeTracker.Forms.ViewModels
{
    public class TimesViewModel : BaseViewModel
    {
        public ObservableCollection<Time> Items { get; set; }
        public Command LoadItemsCommand { get; set; }

        public TimesViewModel()
        {
            Title = "Overview";
            Items = new ObservableCollection<Time>();
            LoadItemsCommand = new Command(async () => ExecuteLoadItemsCommand());

            MessagingCenter.Subscribe<NewTimePage, Time>(this, "AddItem", async (obj, item) =>
            {
                var newTime = item as Time;
                Items.Add(newTime);
                //DependencyService.Get<IApiService>();
            });
        }

        void ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            List<Time> list = null;
            try
            {
                Items.Clear();

                try
                {
                    list = DependencyService.Get<IApiService>().GetAllTimesForSwimmer(31);
                }
                catch (Exception ex)
                {
                    //todo: handle error
                    list = new List<Time>();
                }

                foreach (var time in list)
                {
                    Items.Add(time);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }

}
