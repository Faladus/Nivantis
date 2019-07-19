using Nivantis.Models;
using Nivantis.Models.Form;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nivantis.Internal
{
    sealed class Singleton
    {
        
        private static Singleton _instance = null;

        private Singleton()
        {
        }

        static internal Singleton Instance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }

        public User User { get; set; }
        public List<Form> Forms { get; set; }
    }
}
