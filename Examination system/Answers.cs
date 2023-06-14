using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    internal class Answers
    {
        internal string useranswer;
        public Answers( string useranswer) {
            this.useranswer = useranswer;
        }
        public Answers() { }
        public string Answer
        {
            get { return useranswer; }
            set { useranswer = value; }
        }

    }
}
