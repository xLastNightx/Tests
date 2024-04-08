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

// Класс
/*
Person tom = new();
Person bob = new("Bob");
Person sam = new("Sam", 25);

tom.Print();          // Имя: Неизвестно  Возраст: 18
bob.Print();          // Имя: Bob  Возраст: 18
sam.Print();          // Имя: Sam  Возраст: 25
*/

/*
class State
{
    // все равно, что private string defaultVar;
    string defaultVar = "default";
    // поле доступно только из текущего класса
    private string privateVar = "private";
    // доступно из текущего класса и производных классов, которые определены в этом же проекте
    protected private string protectedPrivateVar = "protected private";
    // доступно из текущего класса и производных классов
    protected string protectedVar = "protected";
    // доступно в любом месте текущего проекта
    internal string internalVar = "internal";
    // доступно в любом месте текущего проекта и из классов-наследников в других проектах
    protected internal string protectedInternalVar = "protected internal";
    // доступно в любом месте программы, а также для других программ и сборок
    public string publicVar = "public";

    // по умолчанию имеет модификатор private
    void Print() => Console.WriteLine(defaultVar);

    // метод доступен только из текущего класса
    private void PrintPrivate() => Console.WriteLine(privateVar);

    // доступен из текущего класса и производных классов, которые определены в этом же проекте
    protected private void PrintProtectedPrivate() => Console.WriteLine(protectedPrivateVar);

    // доступен из текущего класса и производных классов
    protected void PrintProtected() => Console.WriteLine(protectedVar);

    // доступен в любом месте текущего проекта
    internal void PrintInternal() => Console.WriteLine(internalVar);

    // доступен в любом месте текущего проекта и из классов-наследников в других проектах
    protected internal void PrintProtectedInternal() => Console.WriteLine(protectedInternalVar);

    // доступен в любом месте программы, а также для других программ и сборок
    public void PrintPublic() => Console.WriteLine(publicVar);
}
*/

/* Аксессионные модификаторы
 
Person person = new Person();
 
// Устанавливаем свойство - срабатывает блок Set
// значение "Tom" и есть передаваемое в свойство value
person.Name = "Tom";
 
// Получаем значение свойства и присваиваем его переменной - срабатывает блок Get
string personName = person.Name;
Console.WriteLine(personName);  // Tom
 
class Person
{
    private string name = "Undefined";
 
    public string Name
    {
        get
        {
            return name;    // возвращаем значение свойства
        }
        set
        {
            name = value;   // устанавливаем новое значение свойства
        }
    }
}

// 2

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
         
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

//3

Person tom = new();
 
Console.WriteLine(tom.Name);    // Tom
Console.WriteLine(tom.Age);    // 37
 
class Person
{
    public string Name { get; set; } = "Tom";
    public int Age { get; set; } = 37;
}

//4
class Person
{
    string name;
    public string Name 
    { 
        get => name;
        set => name = value; 
    }
}

//5 
class Person
{
    string name;
     
    // эквивалентно public string Name { get { return name; } }
    public string Name => name;
}
*/

// Static
// Следует учитывать, что статические методы могут обращаться только к статическим членам класса.
// Обращаться к нестатическим методам, полям, свойствам внутри статического метода мы не можем.
/*
Person bob = new(68);
Person.CheckRetirementStatus(bob);
 
class Person
{
    public int Age { get; set; }
    static int retirementAge = 65;
    public Person(int age) => Age = age;
    public static void CheckRetirementStatus(Person person)
    {
        if (person.Age >= retirementAge)
            Console.WriteLine("Уже на пенсии");
        else
            Console.WriteLine($"Сколько лет осталось до пенсии: {retirementAge - person.Age}") ;
    }
}
*/

// Преобразования
/*
Employee employee1 = new Employee("Tom", "Microsoft");
Person person = employee1;   // преобразование от Employee к Person
 
//Employee employee2 = person;    // так нельзя, нужно явное преобразование
Employee employee2 = (Employee)person;  // преобразование от Person к Employee
*/