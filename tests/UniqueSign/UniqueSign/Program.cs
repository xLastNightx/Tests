Console.WriteLine("Введите строку");
string? str = Console.ReadLine();

if (str == null) Console.WriteLine("Введите строку");
else
{
    str = str.Replace(" ", string.Empty);

    Console.WriteLine($"Длинна {str.Length}");


    void numbersInString (string str, int count)
    {
        for (int index1 = 0; index1 < str.Length; index1++)
        {
        int temp = 0;
            for (int index2 = 0; index2 < str.Length; index2++)
            {
                if (str[index1] == str[index2])
                {
                    temp++;
                }
            }
            if (temp == 1)
            {
                Console.WriteLine($"Уникальный символ {str[index1]}");
                count++;
            }
        }
        Console.WriteLine($"Всего {count} уникальных символов");
    }

    numbersInString(str, 0);
}
