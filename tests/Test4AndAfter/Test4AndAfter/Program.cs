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

///

    Operation operation = Add;      // делегат указывает на метод Add
    int result = operation(4, 5);   // фактически Add(4, 5)
    Console.WriteLine(result);      // 9
     
    operation = Multiply;           // теперь делегат указывает на метод Multiply
    result = operation(4, 5);       // фактически Multiply(4, 5)
    Console.WriteLine(result);      // 20
 
    int Add(int x, int y) => x + y;
 
    int Multiply(int x, int y) => x * y;
 
    delegate int Operation(int x, int y); 

// Добавление делегата
    Message message = Hello;
    message += HowAreYou;  // теперь message указывает на два метода
    message();              // вызываются оба метода - Hello и HowAreYou
    message -= HowAreYou;   // удаляем метод HowAreYou
    if (message != null) message(); // вызывается метод Hello
 
    void Hello() => Console.WriteLine("Hello");
    void HowAreYou() => Console.WriteLine("How are you?");
 
    delegate void Message();

// объединение деегатов

    Message mes1 = Hello;
    Message mes2 = HowAreYou;
    Message mes3 = mes1 + mes2; // объединяем делегаты
    mes3(); // вызываются все методы из mes1 и mes2

    void Hello() => Console.WriteLine("Hello");
    void HowAreYou() => Console.WriteLine("How are you?");

    delegate void Message();

// обобщение делегатов 
// Здесь делегат Operation типизируется двумя параметрами типов. Параметр T представляет тип возвращаемого значения.
// А параметр K представляет тип передаваемого в делегат параметра. Таким образом, этому делегату соответствует метод, 
// который принимает параметр любого типа и возвращает значение любого типа.
    Operation<decimal, int> squareOperation = Square;
    decimal result1 = squareOperation(5);
    Console.WriteLine(result1);  // 25
 
    Operation<int, int> doubleOperation = Double;
    int result2 = doubleOperation(5);
    Console.WriteLine(result2);  // 10
 
    decimal Square(int n) => n * n;
    int Double(int n) => n + n;
 
    delegate T Operation<T, K>(K val);

// делегаты - параметры методов 
    DoOperation(5, 4, Add);         // 9
    DoOperation(5, 4, Subtract);    // 1
    DoOperation(5, 4, Multiply);    // 20
 
    void DoOperation(int a, int b, Operation op)
    {
        Console.WriteLine(op(a,b));
    }
    int Add(int x, int y) => x + y;
    int Subtract(int x, int y) => x - y;
    int Multiply(int x, int y) => x * y;
 
    delegate int Operation(int x, int y);

// Возвращение делегатов из метода
    Operation operation = SelectOperation(OperationType.Add);
    Console.WriteLine(operation(10, 4));    // 14
 
    operation = SelectOperation(OperationType.Subtract);
    Console.WriteLine(operation(10, 4));    // 6
 
    operation = SelectOperation(OperationType.Multiply);
    Console.WriteLine(operation(10, 4));    // 40
 
    Operation SelectOperation(OperationType opType)
    {
        switch (opType)
        {
            case OperationType.Add: return Add;
            case OperationType.Subtract: return Subtract;
            default: return Multiply;
        }
    }
 
    int Add(int x, int y) => x + y;
    int Subtract(int x, int y) => x - y;
    int Multiply(int x, int y) => x * y;
 
    enum OperationType
    {
        Add, Subtract, Multiply
    }
    delegate int Operation(int x, int y);
*/

// Лямбды =>
/*
    Operation sum = (x, y) => Console.WriteLine($"{x} + {y} = {x + y}");
    sum(1, 2);       // 1 + 2 = 3
    sum(22, 14);    // 22 + 14 = 36
 
    delegate void Operation(int x, int y);

/// с параметром
    PrintHandler print = message => Console.WriteLine(message);
    print("Hello");         // Hello
    print("Welcome");       // Welcome
 
    delegate void PrintHandler(string message);

/// знач по-умолч
    var welcome = (string message = "hello")=> Console.WriteLine(message);
 
    welcome("hello world"); // hello world
    welcome();              // hello

/// выражения 
    int[] integers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
 
// найдем сумму чисел больше 5
    int result1 = Sum(integers, x => x > 5);
    Console.WriteLine(result1); // 30
 
// найдем сумму четных чисел
    int result2 = Sum(integers, x => x % 2 == 0);
    Console.WriteLine(result2);  //20
 
    int Sum(int[] numbers, IsEqual func)
    {
        int result = 0;
        foreach (int i in numbers)
        {
            if (func(i))
                result += i;
        }
        return result;
    }
 
    delegate bool IsEqual(int x);

/// возвращение лямбда-выражения
    Operation operation = SelectOperation(OperationType.Add);
    Console.WriteLine(operation(10, 4));    // 14
 
    operation = SelectOperation(OperationType.Subtract);
    Console.WriteLine(operation(10, 4));    // 6
 
    operation = SelectOperation(OperationType.Multiply);
    Console.WriteLine(operation(10, 4));    // 40
 
    Operation SelectOperation(OperationType opType)
    {
        switch (opType)
        {
            case OperationType.Add: return (x, y) => x + y;
            case OperationType.Subtract: return (x, y) => x - y;
            default: return (x, y) => x * y;
        }
    }
    enum OperationType
    {
        Add, Subtract, Multiply
    }
    delegate int Operation(int x, int y);
/// В данном случае метод SelectOperation() в качестве параметра принимает перечисление типа OperationType. 
/// Это перечисление хранит три константы, каждая из которых соответствует определенной арифметической операции. 
/// И в самом методе в зависимости от значения параметра возвращаем определенное лямбда-выражение.
 */

// события
/* 
     delegate void AccountHandler(string message);
// объявление события
    event AccountHandler Notify; 

// вызов (проверка на null)
    Notify("Произошло действие"); // или if(Notify !=null) Notify("Произошло действие"); или Notify?.Invoke("Произошло действие");

// Пример: (вызов и определение)
    account account = new Account(100);
    account.Notify += DisplayMessage;   // Добавляем обработчик для события Notify
    account.Put(20);    // добавляем на счет 20
    Console.WriteLine($"Сумма на счете: {account.Sum}");
    account.Take(70);   // пытаемся снять со счета 70
    Console.WriteLine($"Сумма на счете: {account.Sum}");
    account.Take(180);  // пытаемся снять со счета 180
    Console.WriteLine($"Сумма на счете: {account.Sum}");
 
    void DisplayMessage(string message) => Console.WriteLine(message);
    
    class Account
    {
        public delegate void AccountHandler(string message);
        public event AccountHandler? Notify;              // 1.Определение события
        public Account(int sum) => Sum = sum;
        public int Sum { get; private set; }
        public void Put(int sum)
        {
            Sum += sum;
            Notify?.Invoke($"На счет поступило: {sum}");   // 2.Вызов события 
        }
        public void Take(int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
                Notify?.Invoke($"Со счета снято: {sum}");   // 2.Вызов события
            }
            else
            {
                Notify?.Invoke($"Недостаточно денег на счете. Текущий баланс: {Sum}"); ;
            }
        }
    }

// управление обработчиками
    Account acc = new Account(100);
    acc.Notify += DisplayMessage;       // добавляем обработчик DisplayMessage
    acc.Put(20);    // добавляем на счет 20
    acc.Notify -= DisplayMessage;     // удаляем обработчик DisplayMessage
    acc.Put(20);    // добавляем на счет 20
 
    void DisplayMessage(string message) => Console.WriteLine(message);
    
    class Account
    {
        public delegate void AccountHandler(string message);
        AccountHandler? notify;
        public event AccountHandler Notify
        {
            add
            {
                notify += value;
                Console.WriteLine($"{value.Method.Name} добавлен");
            }
            remove
            {
                notify -= value;
                Console.WriteLine($"{value.Method.Name} удален");
            }
        }
        public Account(int sum) => Sum = sum;
        public int Sum { get; private set; }
        public void Put(int sum)
        {
            Sum += sum;
            notify?.Invoke($"На счет поступило: {sum}");   // 2.Вызов события 
        }
        public void Take(int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
                notify?.Invoke($"Со счета снято: {sum}");   // 2.Вызов события
            }
            else
            {
                notify?.Invoke($"Недостаточно денег на счете. Текущий баланс: {Sum}"); ;
            }
        }
    }
 
// Еще пример (обработчики)
    Account acc = new Account(100);
    acc.Notify += DisplayMessage;
    acc.Put(20);
    acc.Take(70);
    acc.Take(150);

    void DisplayMessage(Account sender, AccountEventArgs e)
    {
        Console.WriteLine($"Сумма транзакции: {e.Sum}");
        Console.WriteLine(e.Message);
        Console.WriteLine($"Текущая сумма на счете: {sender.Sum}");
    }

    class AccountEventArgs
    {
        // Сообщение
        public string Message { get; }
        // Сумма, на которую изменился счет
        public int Sum { get; }
        public AccountEventArgs(string message, int sum)
        {
            Message = message;
            Sum = sum;
        }
    }
    class Account
    {
        public delegate void AccountHandler(Account sender, AccountEventArgs e);
        public event AccountHandler? Notify;

        public int Sum { get; private set; }

        public Account(int sum) => Sum = sum;

        public void Put(int sum)
        {
            Sum += sum;
            Notify?.Invoke(this, new AccountEventArgs($"На счет поступило {sum}", sum));
        }
        public void Take(int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
                Notify?.Invoke(this, new AccountEventArgs($"Сумма {sum} снята со счета", sum));
            }
            else
            {
                Notify?.Invoke(this, new AccountEventArgs("Недостаточно денег на счете", sum));
            }
        }
    }
*/

// Ковариантность и контрвариантость    (Ковариантность делегата предполагает, что возвращаемым типом может быть производный
//                                      тип. Контрвариантность делегата предполагает, что типом параметра может быть более универсальный тип.
//                                      ковариантность - это от более производного к более общему типу (EmailMessage -> Message),
//                                      а контрвариантность - от более общего к более производному типу (Message -> EmailMessage).)
/* 
    class Message
    {
        public string Text { get; }
        public Message(string text) => Text = text;
        public virtual void Print() => Console.WriteLine($"Message: {Text}");
    }
    class EmailMessage: Message
    {
        public EmailMessage(string text): base(text) { }
        public override void Print() => Console.WriteLine($"Email: {Text}");
    }
    class SmsMessage : Message
    {
        public SmsMessage(string text) : base(text) { }
        public override void Print() => Console.WriteLine($"Sms: {Text}");
    }

// co
    // делегату с базовым типом передаем метод с производным типом
    MessageBuilder messageBuilder = WriteEmailMessage; // ковариантность
    Message message = messageBuilder("Hello");
    message.Print();    // Email: Hello
 
    EmailMessage WriteEmailMessage(string text) => new EmailMessage(text);
 
    delegate Message MessageBuilder(string text);

// contr
    // делегату с производным типом передаем метод с базовым типом
    EmailReceiver emailBox = ReceiveMessage; // контравариантность
    emailBox(new EmailMessage("Welcome"));  // Email: Welcome
 
    void ReceiveMessage(Message message) => message.Print();
 
    delegate void EmailReceiver(EmailMessage message);

// совмещение ко и контрвариантности с обобщенными делегатами
    MessageConverter<Message, EmailMessage> toEmailConverter = (Message message) => new EmailMessage(message.Text);
 
    MessageConverter<SmsMessage, Message> converter = toEmailConverter;
    Message message = converter(new SmsMessage("Hello work"));
    message.Print();    // Email: Hello work
 
    delegate E MessageConverter<in M, out E>(M message);
 */

// Action    (Делегат Action представляет некоторое действие, которое ничего не возвращает)
/* 
    public delegate void Action()
    public delegate void Action<in T>(T obj)

    DoOperation(10, 6, Add);        // 10 + 6 = 16
    DoOperation(10, 6, Multiply);   // 10 * 6 = 60
 
    void DoOperation(int a, int b, Action<int, int> op) => op(a, b);
 
    void Add(int x, int y) => Console.WriteLine($"{x} + {y} = {x + y}");
    void Multiply(int x, int y) => Console.WriteLine($"{x} * {y} = {x * y}");
 */

// Predicate    (используется для сравнения, сопоставления некоторого объекта T определенному условию)
/* 
     delegate bool Predicate<in T>(T obj);

    Predicate<int> isPositive = (int x) => x > 0;
 
    Console.WriteLine(isPositive(20));
    Console.WriteLine(isPositive(-20));
 */

// Func     (возвращает результат действия и может принимать параметры)
/* 
    TResult Func<out TResult>()
    TResult Func<in T, out TResult>(T arg) 

// Пример:
    int result1 = DoOperation(6, DoubleNumber); // 12
    Console.WriteLine(result1);
 
    int result2 = DoOperation(6, SquareNumber); // 36
    Console.WriteLine(result2);
 
// Func<int, int> принимает int и возвращает int
    int DoOperation(int n, Func<int, int> operation) => operation(n); 
    int DoubleNumber(int n) => 2 * n;
    int SquareNumber(int n) => n * n;

// Еще пример func & лямбда-выражения:
    Func<int, int, string> createString = (a, b) => $"{a}{b}";
    Console.WriteLine(createString(1, 5));  // 15
    Console.WriteLine(createString(3, 5));  // 35

// Здесь переменная createString представляет лямбда-выражение, 
// которое принимает два числа int и возвращает строку, то есть представляет делегат Func<int, int, string>.
 */

// Замыкание 
/* 
    var fn = Outer();   // fn = Inner, так как метод Outer возвращает функцию Inner
    // вызываем внутреннюю функцию Inner
    fn();   // 6
    fn();   // 7
    fn();   // 8
 
    Action Outer()  // метод или внешняя функция
    {
        int x = 5;  // лексическое окружение - локальная переменная
        void Inner()    // локальная функция
        {
            x++;        // операции с лексическим окружением
            Console.WriteLine(x);
        }
        return Inner;   // возвращаем локальную функцию
    }

// тоже самое, но с лямбдой
    var outerFn = () =>
    {
        int x = 10;
        var innerFn = () => Console.WriteLine(++x);
        return innerFn;
    };
 
    var fn = outerFn();   // fn = innerFn, так как outerFn возвращает innerFn
    // вызываем innerFn
    fn();   // 11
    fn();   // 12
    fn();   // 13

// Применение внешних параметров в замыкании
    var fn = Multiply(5);  
 
    Console.WriteLine(fn(5));   // 25
    Console.WriteLine(fn(6));   // 30
 
    Operation Multiply(int n)
    {
        int Inner(int m)
        {
            return n * m;
        }
        return Inner;
    }
    delegate int Operation(int n);

// с лямбдами
    var multiply = (int n) => (int m) => n * m; 
 
    var fn = multiply(5);  
 
    Console.WriteLine(fn(5));   // 25
    Console.WriteLine(fn(6));   // 30
 */

/*
    static string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
*/
