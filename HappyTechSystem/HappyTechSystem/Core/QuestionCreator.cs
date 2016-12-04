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
        /// 
        /// -- Edit by Dan
        /// Allows both creation and modification of a question, using a flag to determine what operation to perform.
        /// </summary>
        /// <param name="m_ID"></param>
        /// <param name="m_Tag"></param>
        /// <param name="m_Text"></param>
        public void CreateModifyQuestion(int m_ID, string m_Tag, string m_Text, string[] m_responses, string[] m_feedback, int flag)
        {
            Question Q = new Question();
            Q.GetID = m_ID;
            Q.GetTag = m_Tag; 
            Q.GetText= m_Text;
            Q.Feedback = m_feedback;
            Q.Responses = m_responses;
            QuestionBank QB = QuestionBank.getInst();

            if (flag == 0)
            {
                QB.addToList(Q);
            }
            else
            {
                QB.updateList(Q);
            }

        }
    }
}
