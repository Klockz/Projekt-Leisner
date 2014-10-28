using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeisnerWCF.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int PhoneNo { get; set; }
        public int CustomerNo { get; set; }
        public List<Patient> Patients { get; set; }
    }
}