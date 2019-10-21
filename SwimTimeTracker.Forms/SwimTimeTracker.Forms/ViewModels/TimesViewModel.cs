using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using SwimTimeTracker.Forms.Views;
using SwimTimeTracker.Models.Models;
using Xamarin.Forms;


namespace SwimTimeTracker.Forms.ViewModels
{
    public class TimesViewModel : BaseViewModel
    {
        public ObservableCollection<Time> Times { get; set; }
        public Command LoadItemsCommand { get; set; }

        public TimesViewModel()
        {
            Title = "Overview";
            Times = new ObservableCollection<Time>();
            LoadItemsCommand = new Command(async () => ExecuteLoadItemsCommand());

            MessagingCenter.Subscribe<NewTimePage, Time>(this, "AddItem", async (obj, item) =>
            {
                var newTime = item as Time;
                Times.Add(newTime);
                //todo: call api here
            });
        }

        void ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Times.Clear();
                //TODO: api call
                //var items = await DataStore
                //foreach (var item in items)
                //{
                //    Items.Add(item);
                //}
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
