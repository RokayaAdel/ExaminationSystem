using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    internal class QuestionList:List<Question>
    {
       public void Add(Question q)
        {
            base.Add(q);
            string filePath = @"F:\iti\Examination system\Examination system\data.txt";
            using (StreamWriter w = File.AppendText(filePath))
            {
                w.WriteLine($"{q.Body}");
                //Console.WriteLine("Write Successful");
            }
        }
        public void show()
        {
            foreach (Question q in this)
            {
                Console.WriteLine(q.Body);
            }
        }
    }
}
