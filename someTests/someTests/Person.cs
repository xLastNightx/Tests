using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace someTests
{
    internal class Person
    {
            public string name = "Undefined";
            public int age;

            public void Print()
            {
                Console.WriteLine($"Имя: {name}  Возраст: {age}");
            }
    }
}
