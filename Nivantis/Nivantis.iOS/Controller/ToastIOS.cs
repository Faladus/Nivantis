﻿using Foundation;
using Nivantis.Controller;
using Nivantis.iOS.Controller;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(ToastIOS))]
namespace Nivantis.iOS.Controller
{
    public class ToastIOS : IToast
    {
        const double LONG_DELAY = 3.5;

        NSTimer alertDelay;
        UIAlertController alert;

        public void Show(string message)
        {
            ShowAlert(message, LONG_DELAY);
        }


        void ShowAlert(string message, double seconds)
        {
            alertDelay = NSTimer.CreateScheduledTimer(seconds, (obj) =>
            {
                dismissMessage();
            });
            alert = UIAlertController.Create(null, message, UIAlertControllerStyle.Alert);
            UIApplication.SharedApplication.KeyWindow.RootViewController.PresentViewController(alert, true, null);
        }
        void dismissMessage()
        {
            if (alert != null)
            {
                alert.DismissViewController(true, null);
            }
            if (alertDelay != null)
            {
                alertDelay.Dispose();
            }
        }

    }
}