using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototyping
{
    class Response
    {
        string critera;
        byte rank;
        string feedbackText;

        public Response(byte m_rank, string m_criteria,  string m_feedbackText)
        {
            critera = m_criteria;
            rank = m_rank;
            feedbackText = m_feedbackText;
        }



    }
}
