using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyTechSystem
{
    public class EmailTemplate
    {
        private string  body, subject, type;
        private int id;

        public int GetID { get { return id; } set { id = value; } }

        public String GetBody { get { return body; } set { body = value; } }

        public String GetSubject { get { return subject; } set { subject = value; } }

        public String GetTemplateType { get { return type; } set { type = value; } }
    }
}
