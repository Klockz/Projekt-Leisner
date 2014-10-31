using LeisnerWCF.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;

namespace LeisnerWCF.DataAccess
{
    public class PatientRepository
    {
        private QuestionnaireRepository questionnaireRepo;

        public PatientRepository(QuestionnaireRepository questionnaireRepo)
        {
            this.questionnaireRepo = questionnaireRepo;
        }

        public List<Patient> GetPatientsByCustomerId(int customerId)
        {
            List<Patient> patients = new List<Patient>();

            DbProviderFactory fac = DbProviderFactories.GetFactory(DbHelper.ProviderName);

            using (IDbConnection con = fac.CreateConnection())
            using (IDbCommand cmd = con.CreateCommand())
            {
                con.ConnectionString = DbHelper.ConnectionString;

                cmd.CommandText = "SELECT * FROM Patient WHERE Customer = @CustomerId";

                IDataParameter idParam = cmd.CreateParameter();
                cmd.Parameters.Add(idParam);
                idParam.ParameterName = "@CustomerId";
                idParam.Value = customerId;

                con.Open();
                IDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = (int)reader["Id"];
                    string name = (string)reader["Name"];
                    int age = (int)reader["Age"];

                    Patient patient = new Patient(name, age);
                    patient.Id = id;

                    patient.Questionnaires = questionnaireRepo.GetQuestionnairesByPatientId(id);
                    patients.Add(patient);
                }
            }
            return patients;
        }

        internal bool AddPatient(string name, int age, Customer customer)
        {
            DbProviderFactory fac = DbProviderFactories.GetFactory(DbHelper.ProviderName);
            using (IDbConnection con = fac.CreateConnection())
            using (IDbCommand cmd = con.CreateCommand())
            {
                con.ConnectionString = DbHelper.ConnectionString;

                cmd.CommandText = @"
                    INSERT INTO Patient(Name, Age, Customer)
                    VALUES (@Name, @Age, @Customer)";

                IDataParameter nameParam = cmd.CreateParameter();
                cmd.Parameters.Add(nameParam);
                nameParam.ParameterName = "@Name";
                nameParam.Value = name;

                IDataParameter ageParam = cmd.CreateParameter();
                cmd.Parameters.Add(ageParam);
                ageParam.ParameterName = "@Age";
                ageParam.Value = age;

                IDataParameter customerParam = cmd.CreateParameter();
                cmd.Parameters.Add(customerParam);
                customerParam.ParameterName = "@Customer";
                customerParam.Value = customer.Id;

                con.Open();
                cmd.ExecuteNonQuery();
            }
            return true;
        }
    }
}