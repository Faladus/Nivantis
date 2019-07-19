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
using Nivantis.Custom.Calculation;

using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CalculationButton), typeof(CalculationButtonRenderer))]
namespace Nivantis.Droid.Renderers
{
    public class CalculationButtonRenderer : ButtonRenderer
    {
        public CalculationButtonRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(Android.Graphics.Color.ParseColor("#1976d2"));
            }
        }
    }
}