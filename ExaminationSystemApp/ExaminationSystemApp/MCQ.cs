using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemApp
{
    internal class MCQ : Question
    {
        // msq has three answers , inherted from Question to take the header , body and mark
        public MCQ()
        {
            Choices = new string[3];
            answer = new Answer();
            header = "multible choice question : ";
            Console.WriteLine("what is your question ?");
            body = Console.ReadLine();
            int _mark;
            do
            {
                Console.WriteLine("what's the mark of this question ?");
            } while (!int.TryParse(Console.ReadLine(), out _mark));
            mark = _mark;
            // output something
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"what is the choice ({i + 1}) ?");
                Choices[i] = Console.ReadLine();
            }
            // read the right chioce
            Console.WriteLine("what is the right choice 1, 2 or 3");
            int idNumber = int.Parse(Console.ReadLine()); // exception handler
            answer.id = idNumber;
            answer.rightChoice = Choices[idNumber - 1]; // handler errors 

        }
    }
}
