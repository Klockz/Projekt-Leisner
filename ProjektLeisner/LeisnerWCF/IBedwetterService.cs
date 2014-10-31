using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using LeisnerWCF.Model;

namespace LeisnerWCF
{
    [ServiceContract]
    public interface IBedwetterService
    {
        [OperationContract]
        Customer GetCustomer(string email);
        [OperationContract]
        bool SubmitQuestionnaire(Questionnaire questionnaire, Patient patient);
        [OperationContract]
        List<Customer> GetAllCustomers();
        [OperationContract]
        bool AddCustomer(string name, string email, int phoneNo, int customerNo);
    }
}
