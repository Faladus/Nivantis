using System;
using Xamarin.Forms;

namespace Nivantis.Behaviors
{
    public class DecimalValidationBehavior : Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry entry)
        {
            entry.TextChanged += OnEntryTextChanged;
            base.OnAttachedTo(entry);
        }

        protected override void OnDetachingFrom(Entry entry)
        {
            entry.TextChanged -= OnEntryTextChanged;
            base.OnDetachingFrom(entry);
        }

        private static void OnEntryTextChanged(object sender, TextChangedEventArgs args)
        {

            if (!string.IsNullOrWhiteSpace(args.NewTextValue))
            {
                bool isValid = decimal.TryParse(args.NewTextValue, out decimal value);
                ((Entry)sender).Text = isValid ? args.NewTextValue : args.NewTextValue.Remove(args.NewTextValue.Length - 1);
            }
        }
    }
}