using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    internal class Question
    {
        protected string body;
        protected string header;
        protected int marks;

        public Question()
        {

        }
        public Question(string header, int marks,string body)
        {
            this.header = header;
            this.marks = marks;
            this.body=body;
        }

        public int Marks
        {
            get { return marks; }
            set { marks = value; }
        }
        public string Body
        {
            get { return body; }
            set { body = value; }
        }

        public string Header
        {
            get { return header; }
            set { header = value; }
        }
        
    }
}
