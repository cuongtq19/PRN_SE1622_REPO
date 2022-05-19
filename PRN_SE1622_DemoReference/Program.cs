static void Main()
{
    int x = 1, y = 2;
    void ShowValue(int a)
    {
        Console.WriteLine($"x = {x}, a = {a}");
        x = 10;
    }
    ShowValue(11);
    Console.WriteLine($"x = {x}");
}