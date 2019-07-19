using Nivantis.Models.Form;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nivantis.ViewModels
{
    public class FormViewModel
    {
        public string Title { get; set; }
        public List<Form> Forms { get; set; }

        public FormViewModel(List<Form> forms)
        {
            Title = "Formulaires";
            Forms = forms;
        }
    }
}
