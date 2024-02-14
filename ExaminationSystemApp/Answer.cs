using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemApp
{
    internal class Answer
    {
       public int id { get; set; } // 1, 2, or 3
       public string rightChoice { get; set; } // Choice[id - 1]  
    }
}
