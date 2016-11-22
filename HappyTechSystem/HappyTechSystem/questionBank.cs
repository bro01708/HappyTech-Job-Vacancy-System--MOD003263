using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HappyTechSystem
{
    public class QuestionBank
    {
        private List<Question> questionList = new List<Question>();
        private int qlCount;
        //private QuestionCreatorForm qcf;

        public QuestionBank()
        {
            
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

        public List<Question> getQ
        {
            get { return questionList; }
        }

        public void addToList(Question m_q)
        {
            questionList.Add(m_q);
        }

        public void LoadForm()
        {
            qlCount = questionList.Count;
            qlCount = qlCount + 1;
            //qcf = new QuestionCreatorForm(qlCount);
            //qcf.Show();
        }
    }
}
