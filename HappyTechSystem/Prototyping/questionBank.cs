using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Prototyping
{
    class questionBank
    {
        private List<Question> questionList = new List<Question>();
        

        public List<Question> Questions
        {
            get { return questionList; }
        }

        public void CreateQuestion()
        {
            int QLCount = questionList.Count() + 1;
            Application.Run(new QuestionCreatorForm(QLCount));
            QuestionCreatorForm
            Question Q = new Question();
        }

    }
}
