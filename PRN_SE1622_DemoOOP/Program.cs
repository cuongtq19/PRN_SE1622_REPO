namespace Prn.Se1622;
using static System.Console;
public class Program
{
    public static void Main()
    {
        /*
        Student student = new Student { Id = 1};
        //student.Id = 1;
        student.Name = "Nguyen Van A";
        student.Address = "Ha Noi";
        student.Mark = 8.5d;
        //student.Dob = new DateOnly();

        //Student a = new Student(2, "Ma Van Meo", new DateTime(), "Quan 10", 4.5d);
        Student b = new Student() { Id = 10};
        b.Name = "Cuong";
        b.Address = "Thu Duc";
        b.Mark = 10d;
        WriteLine(b);
        WriteLine("Hello");
        */

        Employee e = new Employee(1, "Cuong", new Address(1, "Hiep Binh Phuoc", "QL13", "Thu Duc")
            , new DateTime(), 150.66d, "Fresher");
        WriteLine(e);
        ReadLine();

    }
}