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
using Nivantis.Exceptions;

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
            if (string.IsNullOrWhiteSpace(GrossPrice.Text) || string.IsNullOrWhiteSpace(Discount.Text) || string.IsNullOrWhiteSpace(Multiplier.Text))
            {
                ShowToast("Valeur(s) manquante...");
                return;
            }

            Calculation calculation = new Calculation()
            {
                GrossPurchasePrice = Convert.ToDecimal(GrossPrice.Text),
                Discount = Convert.ToDecimal(Discount.Text),
                Multiplier = Convert.ToDecimal(Multiplier.Text)
            };

            if (calculation.GrossPurchasePrice == 0)
            {
                ShowToast(CalculationExceptions.GrossPriceEqualZero);
                return;
            }
            if (calculation.Discount < 0)
            {
                ShowToast(CalculationExceptions.DiscountUnderZero);
                return;
            }
            if (calculation.Multiplier < 0)
            {
                ShowToast(CalculationExceptions.MultiplierUnderZero);
                return;
            }

            await Navigation.PushAsync(new CalculationDetailPage(new CalculationViewModel(calculation)));
        }    
        
        private void ShowToast(string message)
        {
            DependencyService.Get<IToast>().Show(message);
        }
    }
}