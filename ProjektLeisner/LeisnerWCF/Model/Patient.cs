using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace LeisnerWCF.Model
{
    [DataContract]
    public class Patient
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Age { get; set; }
        [DataMember]
        public List<Questionnaire> Questionnaires { get; set; }

        public Patient(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}