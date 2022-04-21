using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab.rab._2;

public class AlarmEventArgs : EventArgs
{
    public string InstituteName { set; get; }
    public string GroupName { get; set; }
    public string StudentName { get; }

    public AlarmEventArgs(Student student, Institute institute)
    {
        InstituteName = institute.Name;
        GroupName = student.GroupName;
        StudentName = student.Name;
    }
}
