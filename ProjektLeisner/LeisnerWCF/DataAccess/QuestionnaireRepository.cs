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
        public List<Questionnaire> GetQuestionnairesById(int id)
        {
            List<Questionnaire> questionnaires = new List<Questionnaire>();
            DbProviderFactory fac = DbProviderFactories.GetFactory("System.Data.SqlClient");
            using (IDbConnection con = fac.CreateConnection())
            using (IDbCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Questionnaire WHERE Id = @Id";

                IDataParameter patientParam = cmd.CreateParameter();
                cmd.Parameters.Add(patientParam);
                patientParam.ParameterName = "@Id";
                patientParam.Value = id;

                con.Open();
                IDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    //int id = (int) reader["Id"];
                    string comment = (string) reader["Comment"];
                    int motivation = (int) reader["Motivation"];
                    bool pleaseContact = (bool) reader["PleaseContact"];
                    DateTime date = (DateTime) reader["Date"];

                    Questionnaire questionnaire = new Questionnaire(date, motivation, comment, pleaseContact);
                    questionnaire.Id = id;

                    questionnaire.ToiletVisits = new List<ToiletVisit>();
                    questionnaire.WetBeds = new List<WetBed>();
                    questionnaires.Add(questionnaire);

                }
            }
            return questionnaires;
        }

        private List<WetBed> GetWetbedsById(int Id)
        {
            List<WetBed> wetBeds = new List<WetBed>();

            DbProviderFactory fac = DbProviderFactories.GetFactory("System.Data.SqlClient");

            using(IDbConnection con = fac.CreateConnection())
            using (IDbCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = "SELECT' FROM WetBed WHERE Id = @Id";

                IDataParameter idParam = cmd.CreateParameter();
                cmd.Parameters.Add(idParam);
                idParam.ParameterName = "@Id";
                idParam.Value = Id;

                con.Open();
                IDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string size = (string)reader["Size"];
                    DateTime time = (DateTime)reader["Time"];

                    SpotSize spotSize = (SpotSize)Enum.Parse(typeof(SpotSize), size);

                    WetBed wetBed = new WetBed(spotSize , time);

                    wetBed.Id = Id;

                    wetBeds.Add(wetBed);
                }
            }
            return wetBeds;
        }

        private List<ToiletVisit> GetToiletVisitsById (int id)
        {
            List<ToiletVisit> toiletVisits = new List<ToiletVisit>();

            DbProviderFactory fac = DbProviderFactories.GetFactory("System.Data.SqlClient");

            using(IDbConnection con = fac.CreateConnection())
            using (IDbCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM ToiletVisit WHERE Id = @Id";

                                IDataParameter idParam = cmd.CreateParameter();
                cmd.Parameters.Add(idParam);
                idParam.ParameterName = "@Id";
                idParam.Value = id;

                con.Open();
                IDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
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