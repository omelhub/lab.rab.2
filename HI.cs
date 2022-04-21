using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab.rab._2;

internal class HI : Institute
{
    public override string Name => "HI";
    public HI()
    {
        students.Add(new Student() { Name = "Nina", GroupName = "HI11-11B" });
        students.Add(new Student() { Name = "Varya", GroupName = "HI11-11B" });
        students.Add(new Student() { Name = "Lena", GroupName = "HI11-11B" });
        students.Add(new Student() { Name = "Vika", GroupName = "HI11-11B" });
        students.Add(new Student() { Name = "Irina", GroupName = "HI11-11B" });
        students.Add(new Student() { Name = "Nastya", GroupName = "HI10-01B" });
        students.Add(new Student() { Name = "Liza", GroupName = "HI10-01B" });
        students.Add(new Student() { Name = "Olena", GroupName = "HI10-01B" });
        students.Add(new Student() { Name = "Olecya", GroupName = "HI10-01B" });
        students.Add(new Student() { Name = "Masha", GroupName = "HI10-01B" });
    }
    public override void MedicalCenter_Alarm(object sender, AlarmEventArgs args)
    {
        if (args.InstituteName == this.Name) //args.InstituteName.Equals(this.Name)
        {
            foreach (Student student in students)
            {
                student.IsStudyDistance = true;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{this.Name} переведён на дистант.\n");
            Console.ResetColor();
        }
    }
}
