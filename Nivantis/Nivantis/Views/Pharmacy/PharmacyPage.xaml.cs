using Nivantis.Models.Pharmacy;
using Nivantis.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nivantis.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PharmacyPage : ContentPage
	{
        PharmacyViewModel viewModel;

        public PharmacyPage(PharmacyViewModel pharmacyViewModel)
		{
			InitializeComponent ();

            BindingContext = viewModel = pharmacyViewModel;
        } 

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var pharmacy = args.SelectedItem as Pharmacy;
            if (pharmacy == null)
                return;

            await Navigation.PushAsync(new PharmacyDetailPage(new PharmacyDetailViewModel(pharmacy)));

            // Manually deselect item.
            PharmacyList.SelectedItem = null;
        }
        
        //protected override void OnAppearing()
        //{
        //    base.OnAppearing();

        //    if (viewModel.Pharmacies.Count == 0)
        //        viewModel.LoadPharmaciesCommand.Execute(null);
        //}
    }
}