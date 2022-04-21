using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab.rab._2;

public class MedicalCenter
{
    public List<Institute> institutes = new();
    public event AlarmHandler? Alarm;
    public delegate void AlarmHandler(object sendler, AlarmEventArgs args);

    public MedicalCenter()
    {
        institutes.Add(new ISIT());
        institutes.Add(new MEI());
        institutes.Add(new HI());

        foreach (Institute institute in institutes)
        {
            Alarm += institute.MedicalCenter_Alarm;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(institute.Name);
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("{0,-7} {1,-10} {2,-30}", "Name", "|Group", "|IsStudyDistance");
            Console.ResetColor();
            foreach (Student student in institute.students)
            {
                Console.WriteLine("{0,-8} {1,-10} {2,-6}", student.Name, student.GroupName, student.IsStudyDistance);
                //форматирование длины выводимой строки
            }
        }
    }

    public void OnAlarm(Student student, Institute institute)
    {
        Alarm?.Invoke(this, new AlarmEventArgs(student, institute));
    }
}

