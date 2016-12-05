using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyTechSystem.Core
{
    /// <summary>
    /// Created by Dan. 
    /// Class to state the type "email template". This class also features gets and its own ToString() override.
    /// </summary>
    public class EmailTemplate
    {
        /// Created by Susan
        /// 25/11/2016
        /// Returns email template values

        private string type, name, body, subject;
        private int id;

        public int getID
        {
            get { return id; }
            set { id = value; }
        }

        public String getBody
        {
            get { return body; }
            set { body = value; }
        }

        public String getSubject
        {
            get { return subject; }
            set { subject = value; }
        }

        public String getName
        {
            get { return name; }
            set { name = value; }
        }

        public string getType
        {
            get { return type; }
            set { type = value; }
        }

        public override string ToString()
        {
            return "(" + id.ToString() + ") - " + name;
        }
    }
}
