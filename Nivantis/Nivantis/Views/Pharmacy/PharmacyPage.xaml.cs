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

        public PharmacyPage ()
		{
			InitializeComponent ();
            BindingContext = viewModel = new PharmacyViewModel();
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

        private async void AddPharmacy_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewPharmacyPage()));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Pharmacies.Count == 0)
                viewModel.LoadPharmaciesCommand.Execute(null);
        }        
    }
}