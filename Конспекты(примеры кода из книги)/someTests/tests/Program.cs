/*Console.Write("Введите имя: ");
string? name = Console.ReadLine(); // ? означает, что может быть значение NULL

Console.Write("Введите возраст: ");
int age = Convert.ToInt32(Console.ReadLine()); // переводит из string в int

Console.Write("Введите рост: ");
double height = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите размер зарплаты: ");
decimal salary = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine($"Имя: {name}  Возраст: {age}  Рост: {height}м  Зарплата: {salary}$"); */

int a, b;

Console.WriteLine("Выберите \n sum, diff, product, quotient");
string? toDo = Console.ReadLine();

void sum()
{
    Console.WriteLine("Введите значения");
    a = Convert.ToInt32(Console.ReadLine());
    b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Ответ: {a + b}");
}
void diff()
{
    Console.WriteLine("Введите значения");
    a = Convert.ToInt32(Console.ReadLine());
    b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Ответ: {a - b}");
}
void product()
{
    Console.WriteLine("Введите значения");
    a = Convert.ToInt32(Console.ReadLine());
    b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Ответ: {a * b}");
}
void quotient()
{
    Console.WriteLine("Введите значения");
    a = Convert.ToInt32(Console.ReadLine());
    b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Ответ: {a / b}");
}

switch (toDo)
{
    case "sum":
        sum();
        break;
    case "diff":
        diff();
        break;
    case "product":
        product();
        break;
    case "quotient":
        quotient();
        break;
    default: Console.WriteLine("Неверное условие");
        break;
}

/*
int DoOperation(int op, int a, int b)
{
    int result = op switch
    {
        1 => a + b,
        2 => a - b,
        3 => a * b,
        _ => 0
    };
    return result;
}
*/