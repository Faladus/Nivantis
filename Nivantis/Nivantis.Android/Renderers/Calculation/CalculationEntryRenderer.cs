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

[assembly: ExportRenderer(typeof(CalculationEntry), typeof(CalculationEntryRenderer))]
namespace Nivantis.Droid.Renderers
{
    public class CalculationEntryRenderer : EntryRenderer
    {
        public CalculationEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(Android.Graphics.Color.Transparent);
                Control.SetHintTextColor(Android.Graphics.Color.ParseColor("#1976d2"));                
            }
        }
    }
}