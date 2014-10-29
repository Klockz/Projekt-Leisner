using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;

using LeisnerWCF.Model;

namespace LeisnerWCF.DataAccess
{
    public class CustomerRepository
    {
        private PatientRepository patientRepo;

        public CustomerRepository(PatientRepository patientRepo)
        {
            this.patientRepo = patientRepo;
        }
        // returns null if customer not found
        public Customer GetCustomerByEmail(string email)
        {
            Customer customer = null;

            DbProviderFactory fac = DbProviderFactories.GetFactory(DbHelper.ProviderName);
            using (IDbConnection con = fac.CreateConnection())
            using (IDbCommand cmd = con.CreateCommand())
            {
                con.ConnectionString = DbHelper.ConnectionString;

                cmd.CommandText = "SELECT * FROM Customer WHERE Email = @Email";

                IDataParameter emailParam = cmd.CreateParameter();
                cmd.Parameters.Add(emailParam);
                emailParam.ParameterName = "@Email";
                emailParam.Value = email;

                con.Open();
                IDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = (int)reader["Id"];
                    string name = (string)reader["Name"];
                    int phoneNo = (int)reader["PhoneNo"];
                    int customerNo = (int)reader["CustomerNo"];

                    customer = new Customer(name, email, phoneNo, customerNo);
                    customer.Id = id;
                    
                    // TODO: Get patients
                    customer.Patients = patientRepo.GetPatientsByCustomerId(id);
                }
            }

            return customer;
        }
    }
}