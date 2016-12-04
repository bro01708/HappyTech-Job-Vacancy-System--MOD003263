using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyTechSystem.Core
{
    class TemplateCreator
    {
        private static TemplateCreator uniqueInst = null;

        public static TemplateCreator getInst()
        {
            if (uniqueInst == null)
            {
                uniqueInst = new TemplateCreator();
            }
            return uniqueInst;
        }

        /// <summary>
        /// Created by Susan on 25/11/2016
        /// Constructor which creates new email template
        /// </summary>
        /// <param name="m_ID"></param>
        /// <param name="m_name"></param>
        /// <param name="m_subject"></param>
        /// <param name="m_body"></param>
        public void CreateModifyTemplate(int m_ID, string m_type, string m_name, string m_subject, string m_body, int flag)
        {
            EmailTemplate E = new EmailTemplate();
            E.getID = m_ID;
            E.getType = m_type;
            E.getName = m_name;
            E.getSubject = m_subject;
            E.getBody = m_body;

            EmailBank EB = EmailBank.getInst();
            if (flag == 0)
            {
                EB.addTemplateToList(E);
            }
            else
            {
                EB.UpdateTemplateList(E);
            }
            
        }
    }
}
