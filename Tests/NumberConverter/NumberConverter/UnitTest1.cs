Console.WriteLine("¬ведите систему исчислени€ (от 2 до 20)");
string? firstStr = Console.ReadLine();

if (firstStr == null) Console.WriteLine("¬ведите число");
else
{
    int intVersionOfScaleOfNotation = int.Parse(firstStr);
    Console.WriteLine("¬ведите число дл€ конвертации (от 0)");
    string? secondStr = Console.ReadLine();

    if (secondStr == null) Console.WriteLine("¬ведите число");
    else
    {
        int intVersionOfNumberForConvertation = int.Parse(secondStr);

        Converter startApplication = new Converter();
        startApplication.Convertation(intVersionOfNumberForConvertation, intVersionOfScaleOfNotation);
    }
}

namespace ConverterOfNumbers
{
    public class Converter
    {
        readonly Dictionary<int, string> ListOfSymbols = new()
        {
            {0, "0"}, {1, "1"}, {2, "2"}, {3, "3"},
            {4, "4"}, {5, "5"}, {6, "6"}, {7, "7"},
            {8, "8"}, {9, "9"}, {10, "A"}, {11, "B"},
            {12, "C"}, {13, "D"}, {14, "E"}, {15, "F"},
            {16, "G"}, {17, "H"}, {18, "I"}, {19, "J"}
        };

        public string Convertation(int numberForConvert, int scaleOfNotation)
        {
            string answer = "";

            if (numberForConvert < 0) throw new Exception("out of range");
            if (scaleOfNotation < 1 || scaleOfNotation > 20) throw new Exception("Out of range");
            else
            {
                while (numberForConvert > 0)
                {
                    answer = answer.Insert(0, ListOfSymbols[numberForConvert % scaleOfNotation]);
                    numberForConvert = numberForConvert / scaleOfNotation;
                }
            }
            Console.WriteLine($"ответ {answer}");

            return answer;
        }
    }
}