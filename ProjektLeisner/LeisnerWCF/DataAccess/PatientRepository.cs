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

        public List<Patient> GetPatientCustomerId(int Id)
        {
            List<Patient> patients = new List<Patient>();

            DbProviderFactory fac = DbProviderFactories.GetFactory("System.Data.SqlClient");
            
            using(IDbConnection con = fac.CreateConnection())
            using (IDbCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Patient WHERE Id = @Id";

                IDataParameter idParam = cmd.CreateParameter();
                cmd.Parameters.Add(idParam);
                idParam.ParameterName = "@Id";
                idParam.Value = Id;

                con.Open();
                IDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = (int)reader["Id"];
                    string name = (string)reader["Name"];
                    int age = (int)reader["Age"];

                    Patient patient = new Patient(name, age);

                    patient.Id = id;

                    patient.Questionnaires = new List<Questionnaire>();

                    patients.Add(patient);
                }
            }
            return patients;
        }
    }
}