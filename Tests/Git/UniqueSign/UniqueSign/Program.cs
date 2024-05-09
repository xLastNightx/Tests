Console.WriteLine("Введите строку");
string? str = Console.ReadLine();
int count = 0;

if (str == null) Console.WriteLine("Введите строку");
else
{
    // убрать, если нужно считать пробелы 
    str = str.Replace(" ", string.Empty);

    Console.WriteLine($"Длинна {str.Length}");

    numbersInString(str);
}

void numbersInString(string str)
{
    for (int index1 = 0; index1 < str.Length; index1++)
    {
        numb(0, index1);
    }
    Console.WriteLine($"Всего {count} уникальных символов");
}

int numb(int temp, int index1)
{
    for (int index2 = 0; index2 < str.Length; index2++)
    {
        if (str[index1] == str[index2]) temp++;
    }
    if (temp == 1)
    {
        Console.WriteLine($"Уникальный символ {str[index1]}");
        count++;
    }
    return count;
}
