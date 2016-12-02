using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyTechSystem.Core
{
    class QuestionCreator
    {
        public QuestionCreator()
        {

        }
        private static QuestionCreator uniqueInst = null;
        public static QuestionCreator getInst()
        {
            if (uniqueInst == null)
            {
                uniqueInst = new QuestionCreator();
            }
            return uniqueInst;
        }


        /// <summary>
        /// Created By Peter
        /// Triggered By interface event handler for button labelled"Create Question"
        /// Recieves form data. Creates Question and passes through to bank to store.
        /// </summary>
        /// <param name="m_ID"></param>
        /// <param name="m_Tag"></param>
        /// <param name="m_Text"></param>
        public void CreateQuestion(int m_ID, string m_Tag, string m_Text, string[] m_responses, string[] m_feedback)
        {
            Question Q = new Question();
            Q.GetID = m_ID;
            Q.GetTag = m_Tag; 
            Q.GetText= m_Text;
            Q.Feedback = m_feedback;
            Q.Responses = m_responses;
            QuestionBank QB = QuestionBank.getInst();
            QB.addToList(Q);
        }

        public void ModifyQuestion(int m_ID, string m_Tag, string m_Text, string[] m_responses, string[] m_feedback)
        {
            Question Q = new Question();
            Q.GetID = m_ID;
            Q.GetTag = m_Tag;
            Q.GetText = m_Text;
            Q.Feedback = m_feedback;
            Q.Responses = m_responses;
            QuestionBank QB = QuestionBank.getInst();
            QB.updateList(Q);
        }

    }
}
