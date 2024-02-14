using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemApp
{
    internal class TFQuestion : Question
    {
        public TFQuestion()
        {
            Choices = new string[2] {"True", "False"};
            answer = new Answer();
            header = "select the correct Answer (True | Flase)"; 
            Console.WriteLine("what is your question ?");
            body = Console.ReadLine();
            int _mark;
            do
            {
                Console.WriteLine("what's the mark of this question ?");
            } while (!int.TryParse(Console.ReadLine(), out _mark));
            mark = _mark;
            
            Console.WriteLine("what is the right choice 1 => True , 2 => False ");
            int idNumber = int.Parse(Console.ReadLine()); // exception handle
            answer.id = idNumber;
            answer.rightChoice = Choices[idNumber - 1]; // handle errors
        }

    }
}
