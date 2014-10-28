using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeisnerWCF.Model
{
    public class Questionnaire
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public List<WetBed> WetBeds { get; set; }
        public List<ToiletVisit> ToiletVisits { get; set; }
        public int Motivation { get; set; }
        public string Comment { get; set; }
        public bool PleaseContact { get; set; }
    }
}