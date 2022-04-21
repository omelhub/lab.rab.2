using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab.rab._2;

internal class ISIT : Institute
{
    public override string Name => "ISIT";
    public ISIT()
    {
        students.Add(new Student() { Name = "Ivan", GroupName = "SI11-11B" });
        students.Add(new Student() { Name = "Alexey", GroupName = "SI11-11B" });
        students.Add(new Student() { Name = "Igor", GroupName = "SI11-11B" });
        students.Add(new Student() { Name = "Anton", GroupName = "SI11-11B" });
        students.Add(new Student() { Name = "Viktor", GroupName = "SI11-11B" });
        students.Add(new Student() { Name = "Lev", GroupName = "SI10-10B" });
        students.Add(new Student() { Name = "Nikolay", GroupName = "SI10-10B" });
        students.Add(new Student() { Name = "Dmitriy", GroupName = "SI10-10B" });
        students.Add(new Student() { Name = "Vasiliy", GroupName = "SI10-10B" });
        students.Add(new Student() { Name = "Maksim", GroupName = "SI10-10B" });
    }
    public override void MedicalCenter_Alarm(object sender, AlarmEventArgs args)
    {
        if (args.InstituteName == this.Name) //args.InstituteName.Equals(this.Name)
        {
            foreach (Student student in students)
            {
                if (student.GroupName == args.GroupName) //args.GroupName.Equals(student.GroupName)
                {
                    student.IsStudyDistance = true;
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{args.GroupName} переведёна на дистант.\n");
            Console.ResetColor();
        }
    }
}
