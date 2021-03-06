﻿using System;
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

[assembly: ExportRenderer(typeof(LoginEntry), typeof(LoginEntryRenderer))]
namespace Nivantis.Droid.Renderers
{
    public class LoginEntryRenderer : EntryRenderer
    {
        public LoginEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(Android.Graphics.Color.ParseColor("#63a4ff"));                
            }
        }
    }
}