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
	public partial class PharmacyDetailPage : ContentPage
	{
        PharmacyDetailViewModel viewModel;

        public PharmacyDetailPage (PharmacyDetailViewModel viewModel)
		{
			InitializeComponent ();

            BindingContext = this.viewModel = viewModel;
        }

        public PharmacyDetailPage()
        {
            InitializeComponent();

            var pharmacy = new Pharmacy
            {
                Name = "Pharmacy 1",
                City = "City 1"
            };

            viewModel = new PharmacyDetailViewModel(pharmacy);
            BindingContext = viewModel;
        }
    }
}