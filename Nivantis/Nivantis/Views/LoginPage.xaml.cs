using Nivantis.Internal;
using Nivantis.Services;
using Plugin.Toast;
using System;


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
                SetActivityIndicator(true);

                var user = await nivantisWebService.Connect(login, password);

                if (user != null)
                {
                    Singleton.Instance().User = user;
                    await Navigation.PushModalAsync(new MainPage());
                }
                else
                {
                    SetActivityIndicator(false);
                    CrossToastPopUp.Current.ShowToastError("Login ou mot de passe invalide !");
                }
            }
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            SetActivityIndicator(false);
        }

        private void SetActivityIndicator(bool state)
        {
            ActIndicator.IsEnabled = state;
            ActIndicator.IsRunning = state;
            ActIndicator.IsVisible = state;
        }
    }
}