using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab.rab._2;

public class Student
{
    public string? Name { get; set; }
    public string? GroupName { get; set; }
    public bool IsStudyDistance { get; set; } = false;
    //1 только у одногруппников заболевшего
    //2 у всех студентов института
    //3 ни у кого
}
