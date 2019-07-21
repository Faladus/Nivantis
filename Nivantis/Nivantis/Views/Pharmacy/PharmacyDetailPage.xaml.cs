using Nivantis.Models.Pharmacy;
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
	public partial class PharmacyDetailPage : ContentPage
	{
        PharmacyDetailViewModel viewModel;

        public PharmacyDetailPage (PharmacyDetailViewModel viewModel)
		{
			InitializeComponent ();

            DisplayMedicamentsIfNotNull(viewModel.Pharmacy.PurchasedMedicaments);

            DisplayTrainingIfNotNull(viewModel.Pharmacy.TrainingCourses);

            BindingContext = this.viewModel = viewModel;
        }

        private void DisplayMedicamentsIfNotNull(List<Medicament> medicaments)
        {
            if (medicaments.Count > 0 && medicaments != null)
            {
                MedicamentLabel.IsVisible = true;
                MedicamentList.ItemsSource = medicaments;
                MedicamentList.IsVisible = true;
                
            }
        }

        private void DisplayTrainingIfNotNull(List<TrainingCourse> trainingCourses)
        {
            if (trainingCourses.Count > 0 && trainingCourses != null)
            {
                TrainingCourseLabel.IsVisible = true;
                TrainingCourseList.ItemsSource = trainingCourses;
                TrainingCourseList.IsVisible = true;
            }
        }

        public PharmacyDetailPage()
        {
            InitializeComponent();

            var pharmacy = new Pharmacy
            {
                Name = "Pharmacy 1",
                City = "City 1"
            };

            viewModel = new PharmacyDetailViewModel(pharmacy);
            BindingContext = viewModel;
        }
    }
}