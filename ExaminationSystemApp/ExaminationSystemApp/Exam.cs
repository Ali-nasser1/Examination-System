using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemApp
{
    internal abstract class Exam
    {
       protected int time { get; set; }
       protected int numberOfQuestions { get; set; }
       public Question[] examQuestion;
       public abstract void ShowExam();
       public abstract void CreateExam();
    }
}
