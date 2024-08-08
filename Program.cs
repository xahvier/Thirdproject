class Program
{
    static void Main()
    {
        Console.WriteLine("inpute number: ");
        int number = int.Parse(Console.ReadLine());
        PrintMultiplicationTable(number);
    }
    static void PrintMultiplicationTable(int number)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number} x {i} = {number * i}");
        }
    }
}
