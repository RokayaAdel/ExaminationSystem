using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    internal class Exam
    {
        int noOfquestion;
        int time;
        QuestionList questionList;
        AnswersList answerList;
        Subject subject;

        public Exam(int noOfquestion, int time, QuestionList questionList, AnswersList answerList, Subject subject )
        {
            this.noOfquestion = noOfquestion;
            this.time = time;
            this.questionList = questionList;
            this.answerList = answerList;
            this.subject = subject;
        }
        public int NoOfquestion
        {
            get { return noOfquestion; }
            set { noOfquestion = value; }
        }
        public int Time
        {
            get { return time; }
            set { time = value; }
        }
        public string SubjectName
        {
            get { return subject.SubjectName; }
            set { subject.SubjectName = value; }
        }
        public void ShowQuestion()
        {
            questionList.show();
        }
        public void ShowUserAnswers()
        {
            answerList.ToString();

        }
        public void ShowModelAnswers()
        {
            answerList.ShowModelAnswer();
        }
        
    }
}
