// Табл умножения
/*
for (int i = 1; i < 10; i++)
{
    for (int j = 1; j < 10; j++)
    {
        Console.Write($"{i * j} \t");
    }
    Console.WriteLine();
}
*/

// Массив (матрица) 2 ранговый
/*
int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 } };

int rows = numbers.GetUpperBound(0) + 1;    // количество строк
Console.WriteLine(rows);
int columns = numbers.Length / rows;        // количество столбцов
Console.WriteLine(columns);
                                            // или так
                                            // int columns = numbers.GetUpperBound(1) + 1;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{numbers[i, j]} \t");
    }
    Console.WriteLine();
}
*/

// Массив массивов
/*
int[][] numbers1 = new int[3][];
numbers1[0] = new int[] { 1, 2 };
numbers1[1] = new int[] { 1, 2, 3 };
numbers1[2] = new int[] { 1, 2, 3, 4, 5 };
// можно так
foreach (int[] row in numbers1)
{
    foreach (int number in row)
    {
        Console.Write($"{number} \t");
    }
    Console.WriteLine();
}

// или перебор с помощью цикла for
for (int i = 0; i < numbers1.Length; i++)
{
    for (int j = 0; j < numbers1[i].Length; j++)
    {
        Console.Write($"{numbers1[i][j]} \t");
    }
    Console.WriteLine();
}
*/

// переворот массива
/*
int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };

int n = numbers.Length; // длина массива
int k = n / 2;          // середина массива
int temp;               // вспомогательный элемент для обмена значениями
for (int i = 0; i < k; i++)
{
    temp = numbers[i];
    numbers[i] = numbers[n - i - 1];// количество_элементов - первый_элемент - 1(ибо количество числе на 1 больше, чем индексы)
    numbers[n - i - 1] = temp;
}
foreach (int i in numbers)
{
    Console.Write($"{i} \t");
}
*/

// сортировка
/*
int[] nums = { 54, 7, -41, 2, 4, 2, 89, 33, -5, 12 };

int temp;
for (int i = 0; i < nums.Length - 1; i++)
{
    for (int j = i + 1; j < nums.Length; j++)
    {
        if (nums[i] > nums[j])
        {
            temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}

// вывод
Console.WriteLine("Вывод отсортированного массива");
for (int i = 0; i < nums.Length; i++)
{
    Console.WriteLine(nums[i]);
}
*/

// Выходные данные
/*
void Sum(int x, int y, out int result)
{
    result = x + y;
}

int number;

Sum(10, 15, out number);

Console.WriteLine(number);   // 25
*/

// Params 
/*
void Sum(int initialValue, int numb, params int[] numbers)
{
    int result = initialValue + numb;
    foreach (var n in numbers)
    {
        result += n;
    }
    Console.WriteLine(result);
}

int[] nums = { 1, 2, 3, 4, 5 };
Sum(10, 0, nums);  // число 10 - передается параметру initialValue
Sum(1, 2, 3, 4);
Sum(1, 2, 3);
Sum(20, 1);
*/

// Факториал
/*
int Factorial(int n)
{
    if (n == 1) return 1;

    return n * Factorial(n - 1);
}
int t = Factorial(6);
Console.WriteLine(t);
*/

//Фибаначи 
/*
int Fibonachi(int n)
{
    if (n == 0 || n == 1) return n;

    return Fibonachi(n - 1) + Fibonachi(n - 2);
}

int fib4 = Fibonachi(4);
int fib5 = Fibonachi(5);
int fib6 = Fibonachi(6);

Console.WriteLine($"4 число Фибоначчи = {fib4}");
Console.WriteLine($"5 число Фибоначчи = {fib5}");
Console.WriteLine($"6 число Фибоначчи = {fib6}");
*/


// Enum
/*
DayTime now = DayTime.Evening;

PrintMessage(now);                   // Добрый вечер
PrintMessage(DayTime.Afternoon);    // Добрый день
PrintMessage(DayTime.Night);        // Доброй ночи

void PrintMessage(DayTime dayTime)
{
    switch (dayTime)
    {
        case DayTime.Morning:
            Console.WriteLine("Доброе утро");
            break;
        case DayTime.Afternoon:
            Console.WriteLine("Добрый день");
            break;
        case DayTime.Evening:
            Console.WriteLine("Добрый вечер");
            break;
        case DayTime.Night:
            Console.WriteLine("Доброй ночи");
            break;
    }
}
enum DayTime
{
    Morning,
    Afternoon,
    Evening,
    Night
}
*/

Person tom = new();
Person bob = new("Bob");
Person sam = new("Sam", 25);

tom.Print();          // Имя: Неизвестно  Возраст: 18
bob.Print();          // Имя: Bob  Возраст: 18
sam.Print();          // Имя: Sam  Возраст: 25

class Person
{
    public string name;
    public int age;
    public Person(string name = "Неизвестно", int age = 18)
    {
        this.name = name;
        this.age = age;
    }
    public void Print() => Console.WriteLine($"Имя: {name}  Возраст: {age}");
}