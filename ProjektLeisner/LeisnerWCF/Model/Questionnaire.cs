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

        public Questionnaire(DateTime date, List<WetBed> wetBeds, List<ToiletVisit> toiletVisits, int motivation, string comment, bool pleaseContact)
        {
            Date = date;
            WetBeds = wetBeds;
            ToiletVisits = toiletVisits;
            Motivation = motivation;
            Comment = comment;
            PleaseContact = pleaseContact;
        }
    }
}