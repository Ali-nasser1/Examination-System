using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemApp
{
    internal class FinalExam : Exam
    {
        public int Type;
        public int _examMark = 0;
        public int _studentMark = 0;
        //public Question question;
        public string[] studentAnswer;
        public int studentChoice;
        public int numberOfQuestions; // exception handler
        public override void CreateExam()
        {


            // read number of question
            do
            {
                Console.WriteLine("What's the the number of question ?");
            } while (!int.TryParse(Console.ReadLine(), out numberOfQuestions));
            studentAnswer = new string[numberOfQuestions];
            examQuestion = new Question[numberOfQuestions];
            for (int i = 0; i < numberOfQuestions; i++)
            {
                Console.Clear();
                // choose type of exam
                do
                {
                    Console.WriteLine("What's the type of your questions 1 for mcq and 2 for true or false ?");
                } while (!int.TryParse(Console.ReadLine(), out Type) && (Type == 1 || Type == 2)); // handle this issue

                if (Type == 1)
                {
                    examQuestion[i] = new MCQ();
                    _examMark += examQuestion[i].mark;
                }
                else
                {
                    examQuestion[i] = new TFQuestion();
                    _examMark += examQuestion[i].mark;
                }
            }
        }

        public override void ShowExam()
        {
            // print each question and choose
            for (int i = 0; i < numberOfQuestions; i++)
            {
                Console.Clear();
                Console.WriteLine($"{examQuestion[i].header} the mark of this question is {examQuestion[i].mark}");
                Console.WriteLine($"Q({i + 1}) : {examQuestion[i].body} ?");
                for (int j = 0; j < examQuestion[i].Choices.Length; j++)
                {
                    Console.Write($"{j + 1}. {examQuestion[i].Choices[j]} ");
                }
                Console.WriteLine();
                do
                {
                    Console.WriteLine("choose the right answer ");
                } while (!int.TryParse(Console.ReadLine(), out studentChoice));
                studentAnswer[i] = examQuestion[i].Choices[studentChoice - 1];
                // calc correct answers
                if (studentAnswer[i] == examQuestion[i].answer.rightChoice)
                    _studentMark += examQuestion[i].mark;
            }

            Console.Clear();
            // answers review
            Console.WriteLine($"You have commit mark {_studentMark} out of {_examMark}");
            Console.WriteLine("Review your answer : ");
            for (int i = 0; i < numberOfQuestions; i++)
            {
                // handle error here
                Console.WriteLine($"in Q({i + 1}) {examQuestion[i].body} ?\n");
                Console.WriteLine($"Your answer is : [{studentAnswer[i]}] and the exam answer is [{examQuestion[i].answer.rightChoice}]\n");
                Console.WriteLine("Press enter to Show next");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
