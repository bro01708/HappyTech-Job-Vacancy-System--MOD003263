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

        public String GetText {  get { return text; } set { text = value; }  }

        public String GetTag { get { return tag; } set { tag = value; } }
        public int GetID { get { return id; } set { id = value; } }

        public override string ToString()
        {
            return text;
        }
    }
}
