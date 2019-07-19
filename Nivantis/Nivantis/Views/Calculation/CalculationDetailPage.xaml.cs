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
	public partial class CalculationDetailPage : ContentPage
	{
        CalculationViewModel viewModel;

        public CalculationDetailPage()
        {
            InitializeComponent();
        }

        public CalculationDetailPage(CalculationViewModel viewModel)
		{
			InitializeComponent ();

            BindingContext = this.viewModel = viewModel;
        }
    }
}