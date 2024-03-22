/*Console.Write("Введите имя: ");
string? name = Console.ReadLine(); // ? означает, что может быть значение NULL

Console.Write("Введите возраст: ");
int age = Convert.ToInt32(Console.ReadLine()); // переводит из string в int

Console.Write("Введите рост: ");
double height = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите размер зарплаты: ");
decimal salary = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine($"Имя: {name}  Возраст: {age}  Рост: {height}м  Зарплата: {salary}$"); */

int a, b, c;

Console.WriteLine("Выберите \n sum, diff, product, quotient");
string? toDo = Console.ReadLine();
if (toDo == "")
{
    Console.WriteLine("неверное условие");
} 
else
{
    Console.WriteLine("Введите значения");
    a = Convert.ToInt32(Console.ReadLine());
    b = Convert.ToInt32(Console.ReadLine());
    if (toDo == "sum")
    {
        c = a + b;
        Console.WriteLine($"Ответ: {c}");
    }
    if (toDo == "diff")
    {
        c = a - b;
        Console.WriteLine($"Ответ: {c}");
    }
    if (toDo == "product")
    {
        c = a * b;
        Console.WriteLine($"Ответ: {c}");
    }
    if (toDo == "quotient")
    {
        c = a / b;
        Console.WriteLine($"Ответ: {c}");
    }
}
