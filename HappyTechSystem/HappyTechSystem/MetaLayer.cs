using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyTechSystem
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
        public List<Question> getQuestions()
        {
            List<Question> Questions = new List<Question>();

            DbConection con = DBFactory.instance();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT QuestionID, QuestionText , QuestionTag FROM Question;");

                //Read the data and store them in the list
                while (dr.Read())
                {
                    Question Question = new Question();
                    Question.GetID = dr.GetInt32(0);
                    Question.GetText = dr.GetString(1);
                    Question.GetTag = dr.GetString(2);

                    // etc.....

                    Questions.Add(Question);
                }

                //close Data Reader
                dr.Close();
                con.CloseConnection();
            }

            return Questions;
        }


    }
}
