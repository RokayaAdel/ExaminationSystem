using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    internal class AnswersList : List<Answers>
    {
        QuestionList Q;
        IDictionary<int, Answers> modelanswer;

        public AnswersList(QuestionList Q, IDictionary<int, Answers> modelanswer)
        {
            this.Q = Q;
            this.modelanswer = modelanswer;
        }
        public void Add(Answers A)
        {
            base.Add(A);
        }
       
        public override string ToString()
        {
            string answers = "";
            foreach (Answers A in this)
            {
                Console.WriteLine(A.Answer);
            }
               // answers+= ans?.useranswer;
            return answers;
        }
        public void ShowModelAnswer()
        {
            if (modelanswer != null && this != null && modelanswer.Count > 0)
            {
                foreach (KeyValuePair<int, Answers> Key in modelanswer)
                {
                    Console.WriteLine(Key.Value.useranswer);

                }
            }
        }
        public int CalcMark()
        {
            int mark = 0;
            if (modelanswer != null && this != null && modelanswer.Count > 0)
            {
                foreach (KeyValuePair<int, Answers> Key in modelanswer)
                {
                    
                    if (this[Key.Key - 1].useranswer==(Key.Value.useranswer))
                    {
                       
                        mark += Q[Key.Key - 1].Marks;


                    }
                }
                
            }
            return mark;
        }
       /* public void AdduserAnswers(bool validation, Answers A, int list_size)
        {
            for (int i = 0; i < list_size; i++)
            {
                do
                {
                    Console.WriteLine($"please enter your answer for q{i + 1}");

                    Answer = Console.ReadLine();
                } while (!validation);
            }
        }*/
        
        /*public override bool Equals(object? ans)
        {
            Dictionary<int, Answers> a = ans as Dictionary<int, Answers>;
           
            if (a != null && this != null&&a.Count>0)
            {
                foreach (KeyValuePair<int, Answers> Key in a)
                {
                    Console.WriteLine(Key.Key - 1+ Key.Value.useranswer);
                    if (!this[Key.Key-1].useranswer.Equals(Key.Value.useranswer))
                    {
                        Console.WriteLine(this[Key.Key - 1].useranswer);
                        return false;
                    }
                }
                return true;
            }
            return false;
        }*/


        public override int GetHashCode()
        {
            return HashCode.Combine(ToString());
        }
    }
}
