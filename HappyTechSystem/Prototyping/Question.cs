using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototyping
{
    public class Question
    {       
        private int ID;
        private string tag;
        private string text;
        List<Response> responses = new List<Response>();

        public Question(int m_ID, string m_tag, string m_text, TextBox[] m_textboxes)
        {
            ID = m_ID;
            tag = m_tag;
            text = m_text;
            for (int i = 0; i < 9; i+=2)
            {
                Response R = new Response(Convert.ToByte(i), m_textboxes[i].Text, m_textboxes[i + 1].Text);
                responses.Add(R);
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
         public override string ToString()
        {
            return ID.ToString();
        }

    }
}
