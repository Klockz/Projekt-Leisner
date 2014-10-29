using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;
using LeisnerWCF.Model;

namespace LeisnerWCF.DataAccess
{
    public class QuestionnaireRepository
    {
        public List<Questionnaire> GetQuestionnaireById(int id)
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
    }
}