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
if (toDo == "")
    Console.WriteLine("неверное условие");

    Console.WriteLine("Введите значения");
    a = Convert.ToInt32(Console.ReadLine());
    b = Convert.ToInt32(Console.ReadLine());

void sum()
{
    Console.WriteLine($"Ответ: {a + b}");
}
void diff()
{
    Console.WriteLine($"Ответ: {a - b}");
}
void product()
{
    Console.WriteLine($"Ответ: {a * b}");
}
void quotient()
{
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
}
