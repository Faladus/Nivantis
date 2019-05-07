using Nivantis.Internal;
using Nivantis.Services;
using Plugin.Toast;
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
	public partial class LoginPage : ContentPage
	{
        private NivantisWebService nivantisWebService;

		public LoginPage ()
		{
			InitializeComponent ();
            nivantisWebService = new NivantisWebService();
		}

        async private void LoginButton_Clicked(object sender, EventArgs e)
        {
            var login = Login.Text;
            var password = Password.Text;

            if (!string.IsNullOrWhiteSpace(login) && !string.IsNullOrWhiteSpace(password))
            {
                ActIndicator.IsEnabled = true;
                ActIndicator.IsRunning = true;
                ActIndicator.IsVisible = true;

                var user = await nivantisWebService.Connect(login, password);

                if (user != null)
                {
                    Singleton.Instance().User = user;
                    await Navigation.PushModalAsync(new MainPage());
                }
                else
                {
                    CrossToastPopUp.Current.ShowToastError("Login ou mot de passe invalide !");
                }
                

                
            }
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();  

            ActIndicator.IsEnabled = false;
            ActIndicator.IsRunning = false;
            ActIndicator.IsVisible = false;
        }
    }
}