using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab.rab._2;

public abstract class Institute
{
    public abstract string Name { get; }
    public List<Student> students { get; set; } = new();
    //список студентов

    public abstract void MedicalCenter_Alarm(object sender, AlarmEventArgs args);
    //предопределенный метод-обработчик
}
