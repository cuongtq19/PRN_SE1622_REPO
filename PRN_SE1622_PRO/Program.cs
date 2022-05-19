namespace fptedu.se1622; //.NET 6

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"Hello, World....");

        //declare more variables
        Console.WriteLine($"Input x and y: ");
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        var salary = 100.5;//System.Double (CTS) double
        dynamic age = 20;//int32
        age = true;//boolean

        Console.WriteLine(salary.GetType().Name);
        Console.WriteLine($"Total of a = {x} and b = {y} is: {Sum(x,y)}");
        //Console.WriteLine(args[0]); /run cmd with param into args

        Console.ReadLine();
    }

    public static int Sum(int a, int b)
    {
        return a + b;
    }
}