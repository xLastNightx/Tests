Console.WriteLine("Введите год");
string? str = Console.ReadLine();

if (str != null)
{
    int year = int.Parse(str);
    Console.WriteLine($"{IsLeapYear(year)}");
}
else Console.WriteLine("не верное значение");

static bool IsLeapYear(int year)
{ 
    return DateTime.IsLeapYear(year);
}