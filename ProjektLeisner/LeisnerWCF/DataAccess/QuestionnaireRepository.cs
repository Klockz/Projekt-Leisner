using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;
using LeisnerWCF.Model;
using LeisnerWCF.Enums;

namespace LeisnerWCF.DataAccess
{
    public class QuestionnaireRepository
    {
        public List<Questionnaire> GetQuestionnairesByPatientId(int patientId)
        {
            List<Questionnaire> questionnaires = new List<Questionnaire>();

            DbProviderFactory fac = DbProviderFactories.GetFactory(DbHelper.ProviderName);
            using (IDbConnection con = fac.CreateConnection())
            using (IDbCommand cmd = con.CreateCommand())
            {
                con.ConnectionString = DbHelper.ConnectionString;

                cmd.CommandText = "SELECT * FROM Questionnaire WHERE Patient = @PatientId";
                IDataParameter patientParam = cmd.CreateParameter();
                cmd.Parameters.Add(patientParam);
                patientParam.ParameterName = "@PatientId";
                patientParam.Value = patientId;

                con.Open();
                IDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = (int) reader["Id"];
                    string comment = (string) reader["Comment"];
                    int motivation = (int) reader["Motivation"];
                    bool pleaseContact = (bool) reader["PleaseContact"];
                    DateTime date = (DateTime) reader["Date"];

                    Questionnaire questionnaire = new Questionnaire(date, motivation, comment, pleaseContact);
                    questionnaire.Id = id;

                    questionnaire.ToiletVisits = GetToiletVisitsById(id);
                    questionnaire.WetBeds = GetWetbedsByQuestionnaireId(id);
                    questionnaires.Add(questionnaire);
                }
            }
            return questionnaires;
        }

        private List<WetBed> GetWetbedsByQuestionnaireId(int questionnaireId)
        {
            List<WetBed> wetBeds = new List<WetBed>();

            DbProviderFactory fac = DbProviderFactories.GetFactory(DbHelper.ProviderName);

            using(IDbConnection con = fac.CreateConnection())
            using (IDbCommand cmd = con.CreateCommand())
            {
                con.ConnectionString = DbHelper.ConnectionString;

                cmd.CommandText = "SELECT * FROM WetBed WHERE Questionnaire = @QuestionnaireId";

                IDataParameter idParam = cmd.CreateParameter();
                cmd.Parameters.Add(idParam);
                idParam.ParameterName = "@QuestionnaireId";
                idParam.Value = questionnaireId;

                con.Open();
                IDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = (int)reader["Id"];
                    string size = (string)reader["Size"];
                    DateTime time = (DateTime)reader["Time"];
                    SpotSize spotSize = (SpotSize)Enum.Parse(typeof(SpotSize), size);
                    WetBed wetBed = new WetBed(spotSize , time);
                    wetBed.Id = id;
                    wetBeds.Add(wetBed);
                }
            }
            return wetBeds;
        }

        private List<ToiletVisit> GetToiletVisitsById(int questionnaireId)
        {
            List<ToiletVisit> toiletVisits = new List<ToiletVisit>();

            DbProviderFactory fac = DbProviderFactories.GetFactory(DbHelper.ProviderName);

            using(IDbConnection con = fac.CreateConnection())
            using (IDbCommand cmd = con.CreateCommand())
            {
                con.ConnectionString = DbHelper.ConnectionString;

                cmd.CommandText = "SELECT * FROM ToiletVisit WHERE Questionnaire = @QuestionnaireId";
                
                IDataParameter idParam = cmd.CreateParameter();
                cmd.Parameters.Add(idParam);
                idParam.ParameterName = "@QuestionnaireId";
                idParam.Value = questionnaireId;

                con.Open();
                IDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = (int)reader["Id"];
                    DateTime time = (DateTime)reader["Time"];
                    ToiletVisit visit = new ToiletVisit(time);
                    visit.Id = id;
                    toiletVisits.Add(visit);
                }
            }

            return toiletVisits;
        }
    }
}