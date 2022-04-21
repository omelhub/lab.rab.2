using lab.rab._2;
using System.Threading;

MedicalCenter mc = new();
Console.WriteLine("\nКто заболел? (на английском)");
Console.Write("Имя:\t");
string? s = Console.ReadLine();
Console.Write("Институт(аббревиатура):\t");
string? i = Console.ReadLine();

while (!mc.institutes.Exists(x => x.Name == i))
{
    Console.Write("Институт не найден. Повторите ввод: ");
    i = Console.ReadLine();
}

foreach(Institute institute in mc.institutes)
{
    if (institute.Name == i)
    {
        while(!institute.students.Exists(x => x.Name == s))
        {
            Console.Write("В данном институте нет такого студента. Повторите ввод имени: ");
            s = Console.ReadLine();
        }
        foreach (Student student in institute.students)
        {
            if (student.Name == s)
                mc.OnAlarm(student, institute);
        }
    }
}


foreach (Institute institute in mc.institutes)
{
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
Thread.Sleep(30_000);