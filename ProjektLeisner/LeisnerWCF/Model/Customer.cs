using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace LeisnerWCF.Model
{
    [DataContract]
    public class Customer
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public int PhoneNo { get; set; }
        [DataMember]
        public int CustomerNo { get; set; }
        [DataMember]
        public List<Patient> Patients { get; set; }

        public Customer(string name, string email, int phoneNo, int customerNo)
        {
            Name = name;
            Email = email;
            PhoneNo = phoneNo;
            CustomerNo = customerNo;
        }
    }
}