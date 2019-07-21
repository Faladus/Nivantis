using Nivantis.Internal;
using Nivantis.Models.Form;
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
	public partial class FormPage : ContentPage
	{
        private FormViewModel formViewModel;

        public FormPage ()
		{
			InitializeComponent();

            BindingContext = formViewModel = new FormViewModel(Singleton.Instance().Forms);
        }        

        private void FormsList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}