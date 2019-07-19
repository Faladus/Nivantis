using Nivantis.Controller;
using Nivantis.Internal;
using Nivantis.Services;
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
	public partial class SearchPharmacyPage : ContentPage
	{
		public SearchPharmacyPage ()
		{
			InitializeComponent ();
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var city = CitySearch.Text.Trim().ToLower();

            if (!string.IsNullOrWhiteSpace(city))
            {

                var pharmacies = await new NivantisWebService().GetPharmaciesByCity(Singleton.Instance().User.Key, city);
                if (pharmacies.Count > 0)
                {
                    await Navigation.PushAsync(new PharmacyPage(new PharmacyViewModel(pharmacies)));
                }
                else
                {
                    DependencyService.Get<IToast>().Show("Aucune pharmacies trouvé dans cette ville.");
                }                    
            }
            else
            {
                DependencyService.Get<IToast>().Show("Veuillez remplir le champ.");
            }
        }
    }
}