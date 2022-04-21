using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab.rab._2;

internal class MEI : Institute
{
    public override string Name => "MEI";
    public MEI()
    {
        students.Add(new Student() { Name = "Ivan", GroupName = "MEI11-11B" });
        students.Add(new Student() { Name = "Alexey", GroupName = "MEI11-11B" });
        students.Add(new Student() { Name = "Igor", GroupName = "MEI11-11B" });
        students.Add(new Student() { Name = "Anton", GroupName = "MEI11-11B" });
        students.Add(new Student() { Name = "Viktor", GroupName = "MEI11-11B" });
        students.Add(new Student() { Name = "Lev", GroupName = "MEI10-10B" });
        students.Add(new Student() { Name = "Nikolay", GroupName = "MEI10-10B" });
        students.Add(new Student() { Name = "Dmitriy", GroupName = "MEI10-10B" });
        students.Add(new Student() { Name = "Vasiliy", GroupName = "MEI10-10B" });
        students.Add(new Student() { Name = "Maksim", GroupName = "MEI10-10B" });
    }
    public override void MedicalCenter_Alarm(object sender, AlarmEventArgs args)
    {
        if (args.InstituteName == this.Name) //args.InstituteName.Equals(this.Nam)
        {
            foreach (Student student in students)
            {
                if (student.Name == args.StudentName) //student.Name.Equals(args.StudentName)
                {
                    student.IsStudyDistance = true;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{student.Name} ({student.GroupName}) переведён на дистант.\n");
                    Console.ResetColor();
                    break;
                }
            }
        }
    }
}
