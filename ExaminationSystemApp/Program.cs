using System.Diagnostics;
using System.Security.Cryptography;

namespace ExaminationSystemApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Do you want to Create a new exam ? press (Y | N)");
            char begin = char.Parse(Console.ReadLine());
            while (begin != 'Y' && begin != 'y' && begin != 'N' && begin != 'n')
            {
                Console.WriteLine("please enter a valid choice !");
                begin = char.Parse(Console.ReadLine());
            }
            if (begin == 'Y' || begin == 'y')
            {
                Console.WriteLine("what's the id of the subject ?");
                int id;
                while(!int.TryParse(Console.ReadLine(), out id))
                {
                    Console.WriteLine("please enter a valid id");
                }
                Console.WriteLine("what's the name of the subject ?");
                string name = Console.ReadLine();
                Subject sub = new Subject(id, name);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                sub.CreateExam();
                sw.Stop();
                Console.WriteLine($"You have end with time {sw.Elapsed}");
            }
            else
            {
                Console.WriteLine("Have a good day");
                
            }
        }
    }
}