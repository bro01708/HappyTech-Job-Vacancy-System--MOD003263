using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyTechSystem.Core
{
    class TemplateCreator
    {
        /// <summary>
        /// Created by Susan on 25/11/2016
        /// Constructor which creates new email template
        /// </summary>
        /// <param name="m_ID"></param>
        /// <param name="m_name"></param>
        /// <param name="m_subject"></param>
        /// <param name="m_body"></param>
        public void CreateTemplate(int m_ID, string m_name, string m_subject, string m_body)
        {
            EmailTemplate E = new EmailTemplate();
            E.getID = m_ID;
            E.getName = m_name;
            E.getSubject = m_subject;
            E.getBody = m_body;

            EmailBank EB = new EmailBank();

        }
    }
}
