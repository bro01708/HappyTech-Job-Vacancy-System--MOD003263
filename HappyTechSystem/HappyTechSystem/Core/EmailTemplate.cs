using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyTechSystem.Core
{
    public class EmailTemplate
    {
        /// Created by Susan
        /// 25/11/2016
        /// Returns email template values

        private string  body, subject, name;
        private int id;

        public int ID { get { return id; } set { id = value; } }

        public String Body { get { return body; } set { body = value; } }

        public String Subject { get { return subject; } set { subject = value; } }

        public String Name { get { return name; } set { name = value; } }
    }
}
