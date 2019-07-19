using Android.Widget;
using Nivantis.Controller;
using Nivantis.Droid.Controller;

[assembly: Xamarin.Forms.Dependency(typeof(ToastAndroid))]

namespace Nivantis.Droid.Controller
{
    public class ToastAndroid : IToast
    {
        public void Show(string message)
        {
            Toast.MakeText(Android.App.Application.Context, message, ToastLength.Long).Show();
        }
    }
}