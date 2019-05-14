using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using Nivantis.Droid.Renderers;
using Nivantis.Custom.Login;

using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(LoginButton), typeof(LoginButtonRenderer))]
namespace Nivantis.Droid.Renderers
{
    public class LoginButtonRenderer : ButtonRenderer
    {
        public LoginButtonRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(Android.Graphics.Color.ParseColor("#42a5f5"));
            }
        }
    }
}