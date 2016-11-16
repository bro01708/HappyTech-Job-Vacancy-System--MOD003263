using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyTechSystem
{
    public class Question
    {
        private string Text;
        private int ID;
        private string Tag;

        public String GetText {  get { return Text; } set { Text = value; }  }

        public String GetTag { get { return Tag; } set { Tag = value; } }
        public int GetID { get { return ID; } set { ID = value; } }

        public override string ToString()
        {
            return Text;
        }
    }
}
