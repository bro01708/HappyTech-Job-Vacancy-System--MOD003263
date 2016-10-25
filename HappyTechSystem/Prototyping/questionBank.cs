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
        private Question que;

        public questionBank()
        {
            qlCount = questionList.Count() + 1;
        }
        
        public List<Question> Questions
        {
            get { return questionList; }
        }

        public void CreateQuestion()
        {
            qcf = new QuestionCreatorForm(qlCount);
            qcf.Show();
        }
    }
}
