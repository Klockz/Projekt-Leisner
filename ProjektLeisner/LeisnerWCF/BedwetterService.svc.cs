using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using LeisnerWCF.Model;
using LeisnerWCF.DataAccess;

namespace LeisnerWCF
{
    public class BedwetterService : IBedwetterService
    {
        CustomerRepository customerRepo 
        {
            get
            {
                var questionnaireRepo = new QuestionnaireRepository();
                var patientRepo = new PatientRepository(questionnaireRepo);
                return new CustomerRepository(patientRepo);
            }
        }

        public Customer GetCustomer(string email)
        {
            return customerRepo.GetCustomerByEmail(email);
        }

        public bool SubmitQuestionnaire(Questionnaire questionnaire, Patient patient)
        {
            return true;
        }
    }
}
