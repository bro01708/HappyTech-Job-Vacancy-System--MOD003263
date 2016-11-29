using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappyTechSystem.Core;

namespace HappyTechSystem.DB
{
    public class MetaLayer
    {
        static private MetaLayer m_instance = null;

        private MetaLayer() { }

        static public MetaLayer instance()
        {
            if (null == m_instance)
            {
                m_instance = new MetaLayer();
            }
            return m_instance;
        }

        // Could just have a set of static helper methods rather than a singleton!
        public List<Question> GetQuestions()
        {
            List<Question> Questions = new List<Question>();

            DbConnection con = DBFactory.instance();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT QuestionID, QuestionTag, QuestionText FROM Question;");

                //Read the data and store them in the list
                while (dr.Read())
                {
                    Question Question = new Question();
                    Question.GetID = dr.GetInt32(0);
                    Question.GetTag = dr.GetString(1);
                    Question.GetText = dr.GetString(2);
                    Questions.Add(Question);
                }
                //close Data Reader
                dr.Close();
                con.CloseConnection();
            }

            return Questions;
        }

        //public Question

        public List<EmailTemplate> GetEmailTemplates()
        {
            List<EmailTemplate> ETs = new List<EmailTemplate>();

            DbConnection con = DBFactory.instance();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT TemplateID, TemplateName, TemplateSubject, TemplateBody FROM EmailTemplate;");

                //Read the data and store them in the list
                while (dr.Read())
                {
                    EmailTemplate ET = new EmailTemplate();
                    ET.getID = dr.GetInt32(0);
                    ET.getName = dr.GetString(1);
                    ET.getSubject = dr.GetString(2);
                    ET.getBody = dr.GetString(3);

                    // etc.....

                    ETs.Add(ET);
                }

                //close Data Reader
                dr.Close();
                con.CloseConnection();
            }

            return ETs;
        }

        public List<Vacancy> GetVacancies()
        {
            List<Vacancy> Vs = new List<Vacancy>();

            DbConnection con = DBFactory.instance();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT VacancyID, VacancyName , Role, PositionsAvailable, MinimumScore FROM Vacancy;");

                //Read the data and store them in the list
                while (dr.Read())
                {
                    Vacancy V = new Vacancy();
                    V.Vacancyid = dr.GetInt32(0);
                    V.VacancyName = dr.GetString(1);
                    V.Role = dr.GetString(2);
                    V.PositionsAvailable = dr.GetInt32(3);
                    V.MinumumScore = dr.GetInt32(4);

                    Vs.Add(V);
                }

                //close Data Reader
                dr.Close();
                con.CloseConnection();
            }

            return Vs;
        }

        public int CheckCategories(string m_categoryName)
        {
            List<Question> Questions = new List<Question>();

            DbConnection con = DBFactory.instance();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT QuestionID, QuestionText, QuestionTag FROM Question WHERE QuestionTag = '" + m_categoryName + "' ;");

                //Read the data and store them in the list
                while (dr.Read())
                {
                    Question Question = new Question();
                    Question.GetID = dr.GetInt32(0);
                    Question.GetText = dr.GetString(1);
                    Question.GetTag = dr.GetString(2);
                    Questions.Add(Question);
                }
                //close Data Reader
                dr.Close();
                con.CloseConnection();
            }

            return Questions.Count;
        }

        public List<string> GetCategories()
        {
            List<string> categories = new List<string>();

            DbConnection con = DBFactory.instance();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT DISTINCT QuestionTag FROM Question;");

                //Read the data and store them in the list
                while (dr.Read())
                {
                    string tag = dr.GetString(0);
                    categories.Add(tag);
                }
                //close Data Reader
                dr.Close();
                con.CloseConnection();
            }
            
            return categories;
        }
        /// <summary>
        /// Created by Peter
        /// Recieves a question, splits it down into its attributes, and plugs those into an SQL query that is run by the "RunSQL" method
        /// </summary>
        /// <param name="m_question"></param>
        public void SaveQuestionToDB(Question m_question)
        {
            DbConnection con = DBFactory.instance();
            con.OpenConnection();

            int questionID = m_question.GetID;
            string questionTag = m_question.GetTag;
            string questionText = m_question.GetText;

            String myQuery = "INSERT INTO Question(QuestionID, QuestionTag, QuestionText) VALUES ('" + questionID +
                             "','" + questionTag + "','" + questionText + "')";
            con.RunSQL(myQuery);
            //Following sections loop through ranks 1-5 and writes the assosiated response and feeback at that rank for the question being loaded.
            for (int i = 0; i < 5; i++)
            {
                int rank = i + 1;
                string rankstring = rank.ToString();
                con.RunSQL("INSERT INTO Criteria(Rank, CriteriaText, QuestionID) VALUES ('" + rankstring + "','" + m_question.Responses[i]+"','" + questionID +"')");
                con.RunSQL("INSERT INTO Feedback(Rank, FeedbackText, QuestionID) VALUES ('" + rankstring + "','" + m_question.Feedback[i] + "','" + questionID + "')");
            }

            con.CloseConnection();
        }

        /// <summary>
        /// Created By Peter
        /// Recieves an integer of questionID , converts it to string and uses it as an 
        /// identifier in a delete query which makes use of the Cascade Delete function of the access db.
        /// </summary>
        /// <param name="m_questionID"></param>
        public void RemoveQuestionFromDB(int m_questionID)
        {
            DbConnection con = DBFactory.instance();
            string id = m_questionID.ToString();
            con.OpenConnection();
            con.RunSQL("DELETE FROM Question WHERE QuestionID = " + id + ";");
            con.CloseConnection();
        }

        public string[] GetResponses(int m_questionID)
        {
            List<string> tempResponses = new List<string>();

            DbConnection con = DBFactory.instance();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT CriteriaText FROM Criteria WHERE QuestionID = " + m_questionID + " ORDER BY Rank;");

                //Read the data and store them in the list
                while (dr.Read())
                {
                    string tempText = dr.GetString(0);


                    tempResponses.Add(tempText);
                }

                //close Data Reader
                dr.Close();
                con.CloseConnection();
            }

            return tempResponses.ToArray();
        }
        public string[] GetFeedback(int m_questionID)
        {
            List<string> tempFeedback= new List<string>();

            DbConnection con = DBFactory.instance();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT FeedbackText FROM Feedback WHERE QuestionID = " + m_questionID + " ORDER BY Rank;");

                //Read the data and store them in the list
                while (dr.Read())
                {
                    string tempText = dr.GetString(0);


                    tempFeedback.Add(tempText);
                }

                //close Data Reader
                dr.Close();
                con.CloseConnection();
            }

            return tempFeedback.ToArray();
        }
    }
}
