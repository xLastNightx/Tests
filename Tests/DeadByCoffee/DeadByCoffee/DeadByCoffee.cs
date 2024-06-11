global using DeadByCoffee;

Console.WriteLine("Введите дату рождения");
string? str = Console.ReadLine();

if (str == null) Console.WriteLine("Введите дату рождения (YYYY:MM:DD)");
else
{
    int intVersionOfNumberForConvertation = int.Parse(str);

    HowManyCoffee startApplication = new HowManyCoffee();
    startApplication.CheckForCAFE(intVersionOfNumberForConvertation);
    startApplication.CheckForDECAF(intVersionOfNumberForConvertation);
}

namespace DeadByCoffee
{
    public class HowManyCoffee
    {
        int scaleOfNotation = 16;
        readonly Dictionary<int, string> ListOfSymbols = new()
        {
            {0, "0"}, {1, "1"}, {2, "2"}, {3, "3"},
            {4, "4"}, {5, "5"}, {6, "6"}, {7, "7"},
            {8, "8"}, {9, "9"}, {10, "A"}, {11, "B"},
            {12, "C"}, {13, "D"}, {14, "E"}, {15, "F"},
            {16, "G"}, {17, "H"}, {18, "I"}, {19, "J"}
        };

        public string CheckForCAFE(int DeadNumber)
        {
            int CAFE = 51966;
            int index = 0;

            while (index != 5000 && !(Convertation(DeadNumber).Contains("DEAD")))
            {
                Convertation(DeadNumber);
                DeadNumber = DeadNumber + CAFE;
                index++;
            }

            if (index == 5000)
            {
                Console.WriteLine("CAFE forever");
                return "CAFE forever";
            }
            else 
            {
                Console.WriteLine($"CAFE dead number {index}");
                return $"CAFE dead number {index}";
            }
        }
        public string CheckForDECAF(int DeadNumber)
        {
            int DECAF = 912559;
            int index = 0;

            while (index != 5000 && !(Convertation(DeadNumber).Contains("DEAD")))
            {
                Convertation(DeadNumber);
                DeadNumber = DeadNumber + DECAF;
                index++;
            }
            if (index == 5000)
            {
                Console.WriteLine("DECAF forever");
                return "DECAF forever";
            }
            else
            {
                Console.WriteLine($"DECAF dead number {index}");
                return $"DECAF dead number {index}";
            }
        }

        public string Convertation(int numberForConvert)
        {
            string answer = "";

            /*          if (numberForConvert < 0) throw new Exception("out of range");*/
            if (numberForConvert == 0) answer = "0";
            else
            {
                while (numberForConvert > 0)
                {
                    answer = answer.Insert(0, ListOfSymbols[numberForConvert % scaleOfNotation]);
                    numberForConvert = numberForConvert / scaleOfNotation;
                }
            }

            return answer;
        }
    }
}