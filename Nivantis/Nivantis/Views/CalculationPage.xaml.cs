using Nivantis.Models;
using Nivantis.ViewModels;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Nivantis.Controller;

namespace Nivantis.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CalculationPage : ContentPage
	{      

		public CalculationPage ()
		{
			InitializeComponent ();
		}

        async void CalculationButton_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(GrossPrice.Text) && !string.IsNullOrWhiteSpace(NetPrice.Text) && !string.IsNullOrWhiteSpace(Multiplier.Text))
            {
                Calculation calculation = new Calculation()
                {
                    GrossPurchasePrice = Convert.ToDecimal(GrossPrice.Text),
                    NetPurchasePrice = Convert.ToDecimal(NetPrice.Text),
                    Multiplier = Convert.ToDecimal(Multiplier.Text)
                };

                await Navigation.PushAsync(new CalculationDetailPage(new CalculationViewModel(calculation)));
            }
            else
            {
                DependencyService.Get<IToast>().Show("Valeur(s) manquante...");
            }
        }       
    }
}