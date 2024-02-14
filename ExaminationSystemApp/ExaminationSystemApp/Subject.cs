using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemApp
{
    internal class Subject
    {
        private int id { get; set; }
        private string name { get; set; }
        public int Type;
        Exam exam;
        public Subject(int _id, string _name) 
        {
            id = _id;
            name = _name;
        }
        public void CreateExam()
        {
            do
            {
                Console.WriteLine("What's the type of your exam 1 for final or 2 for practical ?");
            } while(!int.TryParse(Console.ReadLine(), out Type) && (Type == 1 || Type == 2));

            if(Type == 1)
            {
                exam = new FinalExam(); // dynamic bindding
                exam.CreateExam();

                Console.WriteLine("Do you want to begin the exam ? press (Y | N)");
                char begin = char.Parse(Console.ReadLine());
                while ((begin != 'Y' && begin != 'y') && (begin != 'N' && begin != 'n'))
                {
                    Console.WriteLine("please enter a valid choice !");
                    begin = char.Parse(Console.ReadLine());
                }
                if(begin == 'Y' ||  begin == 'y')
                 exam.ShowExam();
            }
            else if(Type == 2) 
            {
                exam = new PracticalExam(); // dynamic bindding
                exam.CreateExam();
                Console.WriteLine("Do you want to begin the exam ? press (Y | N)");
                char begin = char.Parse(Console.ReadLine());
                while ((begin != 'Y' && begin != 'y') && (begin != 'N' && begin != 'n'))
                {
                    Console.WriteLine("please enter a valid choice !");
                    begin = char.Parse(Console.ReadLine());
                }
                if (begin == 'Y' || begin == 'y')
                    exam.ShowExam();
            }
        }
    }
}
