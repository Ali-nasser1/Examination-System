using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemApp
{
    internal abstract class Question
    {
       public string header { get; set; }
       public string body { get; set; } 
       public int mark { get; set; }
       public string[] Choices { get; set; }
       public Answer answer { get; set; }
    }
}
