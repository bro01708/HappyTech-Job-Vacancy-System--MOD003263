using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappyTechSystem;

namespace HappyTechSystem.Core
{
    public class Email
    {
        private string addresses, content, subject;
        private int sentDate;

        public string getAddress { get { return addresses; } set { addresses = value; } }
        public string getContent { get { return content; } set { content = value; } }

        public string getSubject { get { return subject; } set { subject = value; } }

        public int getSentDate { get { return sentDate; } set { sentDate = value; } }

    }
}
