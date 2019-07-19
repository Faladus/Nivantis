using Nivantis.Models.Pharmacy;
using Nivantis.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Nivantis.ViewModels
{
    class PharmacyViewModel : BasePharmacyViewModel
    {
        public ObservableCollection<Pharmacy> Pharmacies { get; set; }
        public Command LoadPharmaciesCommand { get; set; }

        public PharmacyViewModel()
        {
            Title = "Browse";
            Pharmacies = new ObservableCollection<Pharmacy>();
            LoadPharmaciesCommand = new Command(async () => await ExecuteLoadPharmaciesCommand());

            MessagingCenter.Subscribe<NewPharmacyPage, Pharmacy>(this, "AddItem", async (obj, pharmacy) =>
            {
                var newPharmacy = pharmacy as Pharmacy;
                Pharmacies.Add(newPharmacy);
                await DataStore.AddItemAsync(newPharmacy);
            });
        }

        async Task ExecuteLoadPharmaciesCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Pharmacies.Clear();
                var items = await DataStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    Pharmacies.Add(item);
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
