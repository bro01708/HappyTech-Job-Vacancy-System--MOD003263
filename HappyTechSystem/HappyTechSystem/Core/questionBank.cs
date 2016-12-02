using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HappyTechSystem.DB;


namespace HappyTechSystem.Core
{
    public class QuestionBank
    {
        //Holds the list of available quesiton objects for access by any other class
        private MetaLayer ml = MetaLayer.instance();
        private List<Question> questionList;
        private List<string> categoriesList;
        

        //Flag to confirm DB load Correctly
        private bool dbLoaded;

        public QuestionBank()
        {
            categoriesList = new List<string>();
            RefreshDBConnection();
        }

        public bool getDBLoaded
        {
            get { return dbLoaded; }
        }

        private static QuestionBank uniqueInst = null;
        public static QuestionBank getInst()
        { 
            if (uniqueInst == null)
            {
                uniqueInst = new QuestionBank();
            }
            return uniqueInst;
        }

        public List<Question> getQuestionList
        {
            get { return questionList; }
        }

        public List<String> getCategoryList
        {
            get { return categoriesList; }
        }

        public void addToList(Question m_q)
        {
            questionList.Add(m_q);
            ml.SaveQuestionToDB(m_q);
        }
        
        /// <summary>
        /// Created By Peter
        /// Provide this method the ID of a question and it will find and remove it from the QuestionBank in ram
        /// Yet to implement - remove from DB also.
        /// </summary>
        /// <param name="m_question_ID"></param>
        public void removeFromList(int m_question_ID)
        {
            foreach (Question q in questionList)
            {
                if (q.GetID == m_question_ID)
                {
                    questionList.Remove(q);
                    ml.RemoveQuestionFromDB(m_question_ID);
                    break;
                }
            }
        }
        /// <summary>
        /// Created by Dan.
        /// When a particular question is edited, this will update the database record accordingly.
        /// </summary>
        /// <param name="m_questionID"></param>
        public void updateList(Question m_questionID)
        {
            foreach (Question q in questionList)
            {
                if (q.GetID == m_questionID.GetID)
                {
                    var update = questionList.FirstOrDefault(que => q.GetID == m_questionID.GetID);
                    update = q;
                    ml.UpdateQuestionInDB(m_questionID);
                    break;
                }
            }
        }

        /// <summary>
        /// Created By Peter.
        /// Returns the question ID of the last Question stored in the list.
        /// This allows for the new questions to have QuestionID's that are never duplicates.
        /// </summary>
        /// <returns></returns>
        public int getHighestQuestionID()
        {
            try
            {
                int questionCount = questionList.Count();

                if (questionCount == 0)
                {
                    return questionCount;
                }
                return questionList[questionCount - 1].GetID;

                
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        /// <summary>
        /// Created by Peter
        /// Used on initialization to obtain question object data from DB. Also use to refresh DB
        /// after removing an entry in order to resync to avoid mismatches.
        /// </summary>
        public void RefreshDBConnection()
        {
            try
            {
                MetaLayer ml = MetaLayer.instance();
                questionList = ml.GetQuestions();
                categoriesList = ml.GetCategories();
                if (categoriesList.Contains("General"))
                {

                }
                else
                {
                    categoriesList.Add("General");
                }
                dbLoaded = true;
                foreach (Question q in questionList)
                {
                    q.Feedback = ml.GetFeedback(q.GetID);
                    q.Responses = ml.GetResponses(q.GetID);
                }
            }
            catch (Exception e)
            {
                dbLoaded = false;
                throw e;
            }
        }
    }
}
