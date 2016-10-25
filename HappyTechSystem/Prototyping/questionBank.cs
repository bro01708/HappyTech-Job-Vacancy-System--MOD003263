using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Prototyping
{
    public class questionBank
    {
        private List<Question> questionList = new List<Question>();
        private int qlCount;
        private QuestionCreatorForm qcf;

        public questionBank()
        {
            
        }

        private static questionBank uniqueInst = null;
        public static questionBank getInst()
        { 
            if (uniqueInst == null)
            {
                uniqueInst = new questionBank();
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
            qlCount = questionList.Count() + 1;
            qcf = new QuestionCreatorForm(qlCount);
            qcf.Show();
        }
    }
}
