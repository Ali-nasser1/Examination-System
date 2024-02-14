using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemApp
{
    internal class PracticalExam : Exam
    {
        public int studentChoice;
        public int numberOfQuestions;
        public string[] studentAnswer;
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
                examQuestion[i] = new MCQ();
            }
        }

        public override void ShowExam()
        {
            // print each question and choose
            for (int i = 0; i < numberOfQuestions; i++)
            {
                Console.Clear();
                Console.WriteLine($"{examQuestion[i].header} the mark of this question is {examQuestion[i].mark}");
                Console.WriteLine($"Q({i + 1}) : {examQuestion[i].body} ?"); // wrong here
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{j + 1}. {examQuestion[i].Choices[j]} ");
                }
                Console.WriteLine();
                do
                {
                    Console.WriteLine("choose the right answer ");
                } while (!int.TryParse(Console.ReadLine(), out studentChoice));
                studentAnswer[i] = examQuestion[i].Choices[studentChoice - 1];
            }

            Console.Clear();
            // answers review
            Console.WriteLine("Review your answer : ");
            for (int i = 0; i < numberOfQuestions; i++)
            {
               // Console.WriteLine($"Your answer is : {studentAnswer[i]} and the exam answer is {examQuestion[i].answer.rightChoice}");
                Console.WriteLine($"in Q({i + 1}) {examQuestion[i].body} ?\n");
                Console.WriteLine($"Your answer is : [{studentAnswer[i]}] and the exam answer is [{examQuestion[i].answer.rightChoice}]\n");
                Console.WriteLine("Press enter to Show next");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
