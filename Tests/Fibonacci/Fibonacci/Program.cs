using System.Linq;

Console.WriteLine("Введите число для вычисления фибоначчи");
string? str = Console.ReadLine();

if (str == null) Console.WriteLine("Введите число для вычисления фибоначчи");
else
{
    int intVersion = int.Parse(str);

    Fibonacci mainClass = new Fibonacci();
    mainClass.Fib(intVersion);
}

public class Fibonacci()
{
    internal int Fib(int n)
    {
        int[] mass = { 0, 1 };

        for (int index = 1; index < n; index++)
        {
            int fibNumb = mass[index] + mass[index - 1];

            // запушивает число в массив
            mass = mass.Concat(new int[] { fibNumb }).ToArray(); 
            /*Console.WriteLine($"answer: {fibNumb}");*/
        }
        Console.WriteLine($"body answer {mass.Last()}");

        return mass.Last();
    }
}
