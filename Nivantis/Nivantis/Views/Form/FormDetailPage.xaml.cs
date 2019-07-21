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
	public partial class FormDetailPage : ContentPage
	{
        FormDetailViewModel FormDetailViewModel;

        public FormDetailPage (FormDetailViewModel formDetailViewModel)
		{
			InitializeComponent ();

            BindingContext = FormDetailViewModel = formDetailViewModel;
        }

        private void GenerateForm(Formulaire formulaire)
        {
            formulaire.FormItems.ForEach((item) =>
            {
                if (item.Type == "question")
                {
                    Label label = new Label();
                    label.Text = item.Question;
                    label.FontSize = 14;
                    Entry entry = new Entry();
                    MainForm.Children.Add(label);
                    MainForm.Children.Add(entry);
                }
                else if (item.Type == "radio")
                {

                }
                else if (item.Type == "rating")
                {

                }
                else if (item.Type == "checkbox")
                {

                }
            });
        }

	}
}