using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using LeisnerWCF.Model;

namespace LeisnerWCF
{
    public class BedwetterService : IBedwetterService
    {
        public Customer GetCustomer(string email)
        {
            throw new NotImplementedException();
        }

        public bool SubmitQuestionnaire(Questionnaire questionnaire, Patient patient)
        {
            throw new NotImplementedException();
        }
    }
}
