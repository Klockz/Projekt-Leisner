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
                    
                    customer.Patients = patientRepo.GetPatientsByCustomerId(id);
                }
            }

            return customer;
        }

        internal List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();

            DbProviderFactory fac = DbProviderFactories.GetFactory(DbHelper.ProviderName);
            using (IDbConnection con = fac.CreateConnection())
            using (IDbCommand cmd = con.CreateCommand())
            {
                con.ConnectionString = DbHelper.ConnectionString;

                cmd.CommandText = "SELECT * FROM Customer";

                con.Open();
                IDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = (int)reader["Id"];
                    string name = (string)reader["Name"];
                    string email = (string)reader["Email"];
                    int phoneNo = (int)reader["PhoneNo"];
                    int customerNo = (int)reader["CustomerNo"];

                    Customer customer = new Customer(name, email, phoneNo, customerNo);
                    customer.Id = id;
                    
                    customer.Patients = patientRepo.GetPatientsByCustomerId(id);

                    customers.Add(customer);
                }
            }

            return customers;
        }

        public bool InsertCustomer(string name, string email, int phoneNo, int customerNo)
        {
            DbProviderFactory fac = DbProviderFactories.GetFactory(DbHelper.ProviderName);
            using (IDbConnection con = fac.CreateConnection())
            using (IDbCommand cmd = con.CreateCommand())
            {
                con.ConnectionString = DbHelper.ConnectionString;

                cmd.CommandText = @"
                    INSERT INTO Customer(Name, Email, PhoneNo, CustomerNo)
                    VALUES (@Name, @Email, @PhoneNo, @CustomerNo)";

                IDataParameter nameParam = cmd.CreateParameter();
                cmd.Parameters.Add(nameParam);
                nameParam.ParameterName = "@Name";
                nameParam.Value = name;

                IDataParameter emailParam = cmd.CreateParameter();
                cmd.Parameters.Add(emailParam);
                emailParam.ParameterName = "@Email";
                emailParam.Value = email;

                IDataParameter phoneNoParam = cmd.CreateParameter();
                cmd.Parameters.Add(phoneNoParam);
                phoneNoParam.ParameterName = "@PhoneNo";
                phoneNoParam.Value = phoneNo;

                IDataParameter customerNoParam = cmd.CreateParameter();
                cmd.Parameters.Add(customerNoParam);
                customerNoParam.ParameterName = "@CustomerNo";
                customerNoParam.Value = customerNo;

                con.Open();
                IDataReader reader = cmd.ExecuteReader();
                reader.Read();
            }

            return true;
        }
    }
}