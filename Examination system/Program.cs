namespace Examination_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            QuestionList TRQ = new QuestionList {
                new TrueFalse("TR", 5, "q1.1: Encapsulation makes code modification easier but reduces code reuse"),
                new TrueFalse("TR", 5, "q1.2 :objects in OO systems posses state, behavior, and quantity"),
                new TrueFalse("TR", 5, "q1.3 :More than one constructor function may be defined for a class")
        };


            QuestionList COQ = new QuestionList
            {
                 new ChooseOne("CO", 5, "q3.1:  Which feature of OOP indicates code reusability?\na) Encapsulation\nb) Inheritance\nc) Abstraction\nd) Polymorphism \n"),
                 new ChooseOne("CO", 5, "q3.2: If a function can perform more than 1 type of tasks, where the function name remains same, which feature of OOP is used here?\na) Encapsulation\nb) Inheritance\nc) Polymorphism\nd) Abstraction \n"),
                 new ChooseOne("CO", 5, "q3.3: If different properties and functions of a real world entity is grouped or embedded into a single element, what is it called in OOP language?\na) Inheritance\nb) Polymorphism\nc) Abstraction\nd) Encapsulation")
        };


            QuestionList CAQ = new QuestionList
            {
                new ChooseOne("CO", 5, "q3.1:  Which feature of OOP indicates code reusability?\na) Encapsulation\nb) Inheritance\nc) Abstraction\nd) Polymorphism \n"),
                new ChooseOne("CO", 5, "q3.2: If a function can perform more than 1 type of tasks, where the function name remains same, which feature of OOP is used here?\na) Encapsulation\nb) Inheritance\nc) Polymorphism\nd) Abstraction \n"),
                new ChooseOne("CO", 5, "q3.3: If different properties and functions of a real world entity is grouped or embedded into a single element, what is it called in OOP language?\na) Inheritance\nb) Polymorphism\nc) Abstraction\nd) Encapsulation")
        };

           
           
            IDictionary<int, Answers> TRanswers = new Dictionary<int, Answers>() { { 1, new Answers("f") }, { 2, new Answers("f") }, { 3, new Answers("t") } };
            IDictionary<int, Answers> CAanswers = new Dictionary<int, Answers>() { { 1, new Answers("a-b") }, { 2, new Answers("c-d") }, { 3, new Answers("a") } };
            IDictionary<int, Answers> COanswers = new Dictionary<int, Answers>() { { 1, new Answers("b") }, { 2, new Answers("c") }, { 3, new Answers("d") } };

            AnswersList TRanswerlist = new AnswersList(TRQ, TRanswers);
            AnswersList CAanswerlist = new AnswersList(CAQ, CAanswers);
            AnswersList COanswerlist = new AnswersList(COQ, COanswers);
        

            int mark = 0;
            
            Subject subject = new Subject();
            subject.SubjectName = "cs";
            Exam exam = new Exam(3, 2, null, null, subject);
            Console.WriteLine("This was a Final Exam Or Practic?");
            string ExamType = Console.ReadLine();

            StartExam(ExamType, TRQ, COQ, CAQ, TRanswerlist, CAanswerlist, COanswerlist, TRanswers, CAanswers, COanswers, exam);

            switch (ExamType)
            {
                case "Practice":  //Exam Only Shows The Question and right Answers
                   
                    Console.WriteLine("\n");
                    Console.WriteLine("True False Model Answers");

                    PracticeExam p = new PracticeExam(3, 2, TRQ, TRanswerlist, subject);
                    p.ShowModelAnswers();
                    Console.WriteLine("Your answers");
                    p.ShowUserAnswers();
                  


                    Console.WriteLine("*************************************************************");
                    Console.WriteLine("Choose ALL Model Answers");
                    p = new PracticeExam(3, 2, CAQ, CAanswerlist, subject);
                    p.ShowModelAnswers();
                    Console.WriteLine("Your answers");
                    p.ShowUserAnswers();
                    

                    Console.WriteLine("*************************************************************");
                    Console.WriteLine("Choose One Model Answers");
                    p = new PracticeExam(3, 2, COQ, COanswerlist, subject);
                    p.ShowModelAnswers();
                    Console.WriteLine("Your answers");
                    p.ShowUserAnswers();
                   



                    break;

                case "Final": //Exam Only Shows The Question and Answers
                    Console.WriteLine("\n");
                    Console.WriteLine("True False user Answers");

                    FinalExam F = new FinalExam(3, 2, TRQ, TRanswerlist, subject);
                    F.ShowUserAnswers();
                    mark = TRanswerlist.CalcMark();


                    Console.WriteLine("*************************************************************");
                    Console.WriteLine("Choose ALL Model Answers");
                    F = new FinalExam(3, 2, CAQ, CAanswerlist, subject);
                    F.ShowUserAnswers();
                    mark += CAanswerlist.CalcMark();

                    Console.WriteLine("*************************************************************");
                    Console.WriteLine("Choose One Model Answers");
                    F = new FinalExam(3, 2, COQ, COanswerlist, subject);
                    F.ShowUserAnswers();
                    mark += COanswerlist.CalcMark();
                    Console.WriteLine("Your mark:" + mark);
                    Console.WriteLine("*************************************************************");

                    break;
            }

            Console.WriteLine("*************");

        } 
        public static void StartExam(string ExamType, QuestionList TRQ, QuestionList COQ, QuestionList CAQ, AnswersList TRanswerlist, AnswersList CAanswerlist, AnswersList COanswerlist,
            IDictionary<int, Answers> TRanswers, IDictionary<int, Answers> CAanswers, IDictionary<int, Answers> COanswers, Exam exam)
        {

            Console.WriteLine("\n                                            " + ExamType + " Exam                                   \n");
            Console.WriteLine("Subject is :" + exam.SubjectName + "                      " + "Number of question" + exam.NoOfquestion + "                      " + " Time :" + exam.Time + "h");
            Console.WriteLine("Question One True false - Answer as : t or f                                marks:15 \n");
            Answers answers;
            string userAnswer;
            TRQ.show();
            for (int i = 0; i < TRanswers.Count; i++)
            {
                do
                {
                    Console.WriteLine($"please enter your answer for q{i + 1}");
                    userAnswer = Console.ReadLine();
                } while (!((userAnswer != null) && (userAnswer == "t" || userAnswer == "T") || (userAnswer == "f" || userAnswer == "F")));
                //(a.Answer != null) && (a.Answer == "t" || a.Answer == "T") && (a.Answer == "f" || a.Answer == "F"))
                answers = new Answers(userAnswer);
                TRanswerlist.Add(answers);

            }
            answers = new Answers();
            Console.WriteLine("Question Two choose ALL - Answer as : Choose all right Answers              marks:15 \n");
            CAQ.show();
            Console.WriteLine("\n");
            for (int i = 0; i < CAanswers.Count; i++)
            {
                do
                {
                    Console.WriteLine($"please enter your answer for q{i + 1}");
                    userAnswer = Console.ReadLine();
                } while (!((userAnswer != null) && (userAnswer.Contains("a") || userAnswer.Contains("A")) || (userAnswer.Contains("B") || userAnswer.Contains("b")) || (userAnswer.Contains("c") || userAnswer.Contains("C")) || (userAnswer.Contains("d") || userAnswer.Contains("D"))));
                //(a.Answer != null) && (a.Answer == "t" || a.Answer == "T") && (a.Answer == "f" || a.Answer == "F"))
                answers = new Answers(userAnswer);
                CAanswerlist.Add(answers);

            }

            Console.WriteLine("Question Three choose one - Answer as : Choose The right Answer             marks:15 \n");
            COQ.show();
            answers = new Answers();
            for (int i = 0; i < COanswers.Count; i++)
            {
                do
                {
                    Console.WriteLine($"please enter your answer for q{i + 1}");
                    userAnswer = Console.ReadLine();
                } while (!((userAnswer != null) && (userAnswer == "a" || userAnswer == "A") || (userAnswer == "B" || userAnswer == "b") || (userAnswer == "c" || userAnswer == "C") || (userAnswer == "d" || userAnswer == "D")));
                //(a.Answer != null) && (a.Answer == "t" || a.Answer == "T") && (a.Answer == "f" || a.Answer == "F"))
                answers = new Answers(userAnswer);
                COanswerlist.Add(answers);

            }
            Console.WriteLine("\n");
        }
    }
       
    
}