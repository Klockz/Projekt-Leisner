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
                return new CustomerRepository(PatientRepo);
            }
        }

        QuestionnaireRepository QuestionnaireRepo
        {
            get
            {
                return new QuestionnaireRepository();
            }
        }

        PatientRepository PatientRepo
        {
            get
            {
                return new PatientRepository(QuestionnaireRepo);
            }
        }

        public Customer GetCustomer(string email)
        {
            return customerRepo.GetCustomerByEmail(email);
        }

        public bool SubmitQuestionnaire(Questionnaire questionnaire, Patient patient)
        {
            return QuestionnaireRepo.InsertQuestionnaire(questionnaire, patient);
        }

        public List<Customer> GetAllCustomers()
        {
            throw new NotImplementedException();
        }
    }
}
