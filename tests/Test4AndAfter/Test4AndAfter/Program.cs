// Скрытие
/*
class Person
{
    public string Name { get; set; }
    public Person(string name)
    {
        Name = name;
    }
    public void Print()
    {
        Console.WriteLine($"Name: {Name}");
    }
}
class Employee : Person
{
    public string Company { get; set; }
    public Employee(string name, string company)
                : base(name)
    {
        Company = company;
    }
    public new void Print() // !!! Слово new скрывает то, что делал родительский класс 
    {
        Console.WriteLine($"Name: {Name}   Company: {Company}");
    }
}
 */

// Абстрактные методы и классы 
/* 
 abstract class Transport
{
    public abstract void Move();
}
// класс корабля
class Ship : Transport 
{
    // мы должны реализовать все абстрактные методы и свойства базового класса
    public override void Move()
    {
        Console.WriteLine("Корабль плывет");
    }
}
// класс самолета
class Aircraft : Transport
{
    public override void Move()
    {
        Console.WriteLine("Самолет летит");
    }
}
// класс машины
class Car : Transport
{
    public override void Move()
    {
        Console.WriteLine("Машина едет");
    }
}

Transport car = new Car();
Transport ship = new Ship();
Transport aircraft = new Aircraft();
 
car.Move();         // машина едет
ship.Move();        // корабль плывет
aircraft.Move();    // самолет летит
 */

// абстракт класс 
/* 
 // абстрактный класс фигуры
abstract class Shape
{
    // абстрактный метод для получения периметра
    public abstract double GetPerimeter();
    // абстрактный метод для получения площади
    public abstract double GetArea();
}
// производный класс прямоугольника
class Rectangle : Shape
{
    public float Width { get; set; }
    public float Height { get; set; }
 
    // переопределение получения периметра
    public override double GetPerimeter() => Width * 2 + Height * 2;
    // переопрелеление получения площади
    public override double GetArea() => Width * Height;
}
// производный класс окружности
class Circle : Shape
{
    public double Radius { get; set; }
 
    // переопределение получения периметра
    public override double GetPerimeter() => Radius * 2 * 3.14;
    // переопрелеление получения площади
    public override double GetArea() => Radius * Radius * 3.14;
}

var rectanle = new Rectangle { Width = 20, Height = 20 };
var circle = new Circle { Radius = 200 };
PrintShape(rectanle); // Perimeter: 80   Area: 400
PrintShape(circle); // Perimeter: 1256  Area: 125600
 
void PrintShape(Shape shape)
{
    Console.WriteLine($"Perimeter: {shape.GetPerimeter()}  Area: {shape.GetArea()}");
}   
 */

/*
Clock clock = new Clock { Hours = 15, Minutes = 34, Seconds = 53 };
Console.WriteLine(clock.ToString()); // выведет 15:34:53

class Clock
{
    public int Hours { get; set; }
    public int Minutes { get; set; }
    public int Seconds { get; set; }
    public override string ToString()
    {
        return $"{Hours}:{Minutes}:{Seconds}";
    }
}
*/

// обобщенный класс
/* 
 class Person<T>
{
    public T Id { get; set; }
    public string Name { get; set; }
    public Person(T id, string name)
    {
        Id = id; 
        Name = name;
    }
}
Person<int> tom = new Person<int>(546, "Tom");  // упаковка не нужна
Person<string> bob = new Person<string>("abc123", "Bob");
 
int tomId = tom.Id;      // распаковка не нужна
string bobId = bob.Id;  // преобразование типов не нужно
 
Console.WriteLine(tomId);   // 546
Console.WriteLine(bobId);   // abc123

///

// класс компании
class Company<P>
{
    public P CEO { get; set; }  // президент компании
    public Company(P ceo)
    {
        CEO = ceo;
    }
}
class Person<T>
{
    public T Id { get;}
    public string Name { get;}
    public Person(T id, string name)
    {
        Id = id; 
        Name = name;
    }
}

Person<int> tom = new Person<int>(546, "Tom");
Company<Person<int>> microsoft =  new Company<Person<int>>(tom);
 
Console.WriteLine(microsoft.CEO.Id);  // 546
Console.WriteLine(microsoft.CEO.Name);  // Tom

// Обобщенные методы
int x = 7;
int y = 25;
Swap<int>(ref x, ref y); // или так Swap(ref x, ref y);
Console.WriteLine($"x={x}    y={y}");   // x=25   y=7
 
string s1 = "hello";
string s2 = "bye";
Swap<string>(ref s1, ref s2); // или так Swap(ref s1, ref s2);
Console.WriteLine($"s1={s1}    s2={s2}"); // s1=bye   s2=hello
 
void Swap<T>(ref T x, ref T y)
{
    T temp = x;
    x = y;
    y = temp;
}
 */

// Ограничения
/* 
 SendMessage(new Message("Hello World"));
SendMessage(new EmailMessage("Bye World"));
 
void SendMessage<T>(T message) where T: Message
{
    Console.WriteLine($"Отправляется сообщение: {message.Text}");
}
class Message
{
    public string Text { get; } // текст сообщения
    public Message(string text)
    {
        Text = text;
    }
}
class EmailMessage : Message
{
    public EmailMessage(string text) : base(text) { }
}

///

class Messenger<T, P> 
    where T : Message
    where P: Person
{
    public void SendMessage(P sender, P receiver, T message)
    {
        Console.WriteLine($"Отправитель: {sender.Name}");
        Console.WriteLine($"Получатель: {receiver.Name}");
        Console.WriteLine($"Сообщение: {message.Text}");
    }
}
class Person
{
    public string Name { get;}
    public Person(string name) => Name = name;
}
 
class Message
{
    public string Text { get; } // текст сообщения
    public Message(string text) =>  Text = text;
}

Messenger<Message, Person> telegram = new Messenger<Message, Person>();
Person tom = new Person("Tom");
Person bob = new Person("Bob");
Message hello = new Message("Hello, Bob!");
telegram.SendMessage(tom, bob, hello);
*/

// try..catch..finally (исключения)
/* 
try
{
    int x = 5;
    int y = x / 0;
    Console.WriteLine($"Результат: {y}");
}
catch
{
    Console.WriteLine("Возникло исключение!");
}
finally
{
    Console.WriteLine("Блок finally");
}

///

try
{
    object obj = "you";
    int num = (int)obj;     // System.InvalidCastException
    Console.WriteLine($"Результат: {num}");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Возникло исключение DivideByZeroException");
}
catch (IndexOutOfRangeException)
{
    Console.WriteLine("Возникло исключение IndexOutOfRangeException");
}
catch (Exception ex)
{
    Console.WriteLine($"Исключение: {ex.Message}");
}

// Создание своего исключения
try
{
    Console.Write("Введите имя: ");
    string? name = Console.ReadLine();
    if (name== null || name.Length < 2)
    {
        throw new Exception("Длина имени меньше 2 символов"); // throw!!!
    }
    else
    {
        Console.WriteLine($"Ваше имя: {name}");
    }
}
catch (Exception e)
{
    Console.WriteLine($"Ошибка: {e.Message}");
}

/// 
class PersonException : ArgumentException
{
    public int Value { get;}
    public PersonException(string message, int val)
        : base(message)
    {
        Value = val;
    }
}
try
{
    Person person = new Person { Name = "Tom", Age = 17 };
}
catch (PersonException ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
    Console.WriteLine($"Некорректное значение: {ex.Value}");
}
 
class Person
{
    private int age;
    public string Name { get; set; } = "";
    public int Age
    {
        get => age;
        set
        {
            if (value < 18)
                throw new PersonException("Лицам до 18 регистрация запрещена", value);
            else
                age = value;
        }
    }
}
 */

// Делегаты
/* 
Message mes;            // 2. Создаем переменную делегата
mes = Hello;            // 3. Присваиваем этой переменной адрес метода
mes();                  // 4. Вызываем метод
 
void Hello() => Console.WriteLine("Hello METANIT.COM");
 
delegate void Message(); // 1. Объявляем делегат 
 */