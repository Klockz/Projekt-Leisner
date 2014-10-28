using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace LeisnerWCF.Model
{
    [DataContract]
    public class Questionnaire
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
        [DataMember]
        public List<WetBed> WetBeds { get; set; }
        [DataMember]
        public List<ToiletVisit> ToiletVisits { get; set; }
        [DataMember]
        public int Motivation { get; set; }
        [DataMember]
        public string Comment { get; set; }
        [DataMember]
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