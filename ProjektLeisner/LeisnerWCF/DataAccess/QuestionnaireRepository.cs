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

        public bool InsertQuestionnaire(Questionnaire questionnaire, Patient patient)
        {
            DbProviderFactory fac = DbProviderFactories.GetFactory(DbHelper.ProviderName);
            using (IDbConnection con = fac.CreateConnection())
            using (IDbCommand cmd = con.CreateCommand())
            {
                con.ConnectionString = DbHelper.ConnectionString;

                cmd.CommandText = "INSERT INTO Questionnaire(Motivation, Date, Comment, PleaseContact, Patient) VALUES (@Motivation, @Date, @Comment, @PleaseContact, @Patient)";

                IDataParameter motivationParam = cmd.CreateParameter();
                cmd.Parameters.Add(motivationParam);
                motivationParam.ParameterName = "@Motivation";
                motivationParam.Value = questionnaire.Motivation;

                IDataParameter CommentParam = cmd.CreateParameter();
                cmd.Parameters.Add(CommentParam);
                CommentParam.ParameterName = "@Comment";
                CommentParam.Value = questionnaire.Comment;

                IDataParameter PleaseContactParam = cmd.CreateParameter();
                cmd.Parameters.Add(PleaseContactParam);
                PleaseContactParam.ParameterName = "@PleaseContact";
                PleaseContactParam.Value = questionnaire.PleaseContact;

                IDataParameter DateParam = cmd.CreateParameter();
                cmd.Parameters.Add(DateParam);
                DateParam.ParameterName = "@Date";
                DateParam.Value = questionnaire.Date;

                IDataParameter PatientParam = cmd.CreateParameter();
                cmd.Parameters.Add(PatientParam);
                PatientParam.ParameterName = "@Patient";
                PatientParam.Value = patient.Id;

                con.Open();
                cmd.ExecuteNonQuery();

                insertWetBed(questionnaire);
                insertToiletVisit(questionnaire);
            }

            return true;
        }

        private bool insertToiletVisit(Questionnaire questionnaire)
        {
            DbProviderFactory fac = DbProviderFactories.GetFactory(DbHelper.ProviderName);
            using (IDbConnection con = fac.CreateConnection())
            using (IDbCommand cmd = con.CreateCommand())
            {
                con.ConnectionString = DbHelper.ConnectionString;

                foreach (ToiletVisit toiletVisit in questionnaire.ToiletVisits)
                {
                    cmd.CommandText = "INSERT INTO ToiletVisit(Time) VALUES (@Time)";

                    IDataParameter timeParam = cmd.CreateParameter();
                    cmd.Parameters.Add(timeParam);
                    timeParam.ParameterName = "@Time";
                    timeParam.Value = toiletVisit.Time;

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                return true;
            }
        }

        private bool insertWetBed(Questionnaire questionnaire)
        {
            DbProviderFactory fac = DbProviderFactories.GetFactory(DbHelper.ProviderName);
            using (IDbConnection con = fac.CreateConnection())
            using (IDbCommand cmd = con.CreateCommand())
            {
                con.ConnectionString = DbHelper.ConnectionString;

                foreach (WetBed wetBed in questionnaire.WetBeds)
                {
                    cmd.CommandText = "INSERT INTO WetBed(Size, Time) VALUES (@Size, @Time)";

                    IDataParameter sizeParam = cmd.CreateParameter();
                    cmd.Parameters.Add(sizeParam);
                    sizeParam.ParameterName = "@Size";
                    sizeParam.Value = wetBed.Size;

                    IDataParameter timeParam = cmd.CreateParameter();
                    cmd.Parameters.Add(timeParam);
                    timeParam.ParameterName = "@Time";
                    timeParam.Value = wetBed.Time;

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                return true;
            }
        }
    }
}