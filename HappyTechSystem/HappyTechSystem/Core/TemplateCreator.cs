using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyTechSystem.Core
{
    class TemplateCreator
    {
        /// </summary>
        /// Created by Susan
        /// 25/11/2016
        /// <Constructor which creates new email template

        public void CreateTemplate(int m_ID, string m_name, string m_subject, string m_body)
        {
            EmailTemplate E = new EmailTemplate();
            E.ID = m_ID;
            E.Name = m_name;
            E.Subject = m_subject;
            E.Body = m_body;

            EmailBank EB = new EmailBank();

        }
    }
}
