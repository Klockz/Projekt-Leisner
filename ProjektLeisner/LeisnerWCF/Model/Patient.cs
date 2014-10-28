using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeisnerWCF.Model
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Questionnaire> Questionnaires { get; set; }
    }
}