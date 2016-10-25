using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototyping
{
    public class Question
    {       
        private int ID;
        private string tag;
        private string text;
        List<Response> responses = new List<Response>();

        public Question(int m_ID, string m_tag, string m_text)
        {
            ID = m_ID;
            tag = m_tag;
            text = m_text;
            for (int i = 0; i < 4; i++)
            {
                //Response R = new Response();
            }
        }

        public int getID()
        {
            return ID;
        }
        public string getTag()
        {
            return tag;
        }

        public string getText()
        {
            return text;
        }
    }
}
