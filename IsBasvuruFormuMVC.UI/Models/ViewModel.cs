using IsBasvuruFormu.DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IsBasvuruFormuMVC.UI.Models
{
    public class ViewModel
    {
        public Person person { get; set; }
        public Contact contact { get; set; }
        public Education education { get; set; }
        public OtherEducation otherEducation { get; set; }
        public Language language { get; set; }
        public WorkExperience workExperience { get; set; }
        public Reference reference { get; set; }
    }
}