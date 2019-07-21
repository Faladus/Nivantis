using Nivantis.Models.Form;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nivantis.ViewModels
{  
    public class FormDetailViewModel
    {
        public Formulaire Formulaire { get; set; }

        public FormDetailViewModel(Formulaire formulaire)
        {
            Formulaire = formulaire;
        }
    }
}
