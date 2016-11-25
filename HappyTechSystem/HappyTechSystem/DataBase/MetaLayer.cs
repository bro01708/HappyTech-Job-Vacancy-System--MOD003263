﻿using System;
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
                    Questions.Add(Question);
                }
                //close Data Reader
                dr.Close();
                con.CloseConnection();
            }

            return Questions;
        }

        public List<EmailTemplate> GetEmailTemplates()
        {
            List<EmailTemplate> ETs = new List<EmailTemplate>();

            DbConection con = DBFactory.instance();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT TemplateID, TemplateType , TemplateBody, TemplateSubject FROM EmailTemplate;");

                //Read the data and store them in the list
                while (dr.Read())
                {
                    EmailTemplate ET = new EmailTemplate();
                    ET.ID = dr.GetInt32(0);
                    ET.Type = dr.GetString(1);
                    ET.Body = dr.GetString(2);
                    ET.Subject = dr.GetString(3);

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

            DbConection con = DBFactory.instance();
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

    }
}
