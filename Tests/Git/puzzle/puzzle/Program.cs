Console.WriteLine("Введите строку");
string? str = Console.ReadLine();

if (str == null) Console.WriteLine("Введите строку");
else
{
    doubleWord(str);
}

static bool doubleWord (string str)
{
    int temp = 0;
    for (int index1 = 0; index1 < str.Length - 1; index1++)
    {
            if (str[index1] == str[index1 + 1]) temp++;
    }
    if (temp > 0)
    {
        Console.WriteLine("Yes");
        return true; 
    }
    else return false;
}
