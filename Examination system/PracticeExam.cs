using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    internal class PracticeExam : Exam
    {
      
        public PracticeExam(int noOfquestion, int time, QuestionList questionList, AnswersList answerList,Subject subject) : base(noOfquestion, time, questionList, answerList,  subject) {}
       
    }
}
