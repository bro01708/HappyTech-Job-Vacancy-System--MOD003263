using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyTechSystem.Core
{
    public class Question
    {
        private string text;
        private int id;
        private string tag;
        private string[] responses;
        private string[] feedback;

        public String GetText
        {
            get { return text; }
            set { text = value; }
        }

        public String GetTag
        {
            get { return tag; }
            set { tag = value; }
        }

        public int GetID
        {
            get { return id; }
            set { id = value; }
        }

        public string[] Responses
        {
            get { return responses; }
            set { responses = value; }
        }

        public string[] Feedback
        {
            get { return feedback; }
            set { feedback = value; }
        }

        public override string ToString()
        {
            return "(" + id.ToString() + ") - [" + tag + "] - " + text;
        }
    }
}
