string str = "hello wold";
int count = 0;
int tmp;
Console.WriteLine(str.Length);
for (int i = 0; i < str.Length; i++)
{
    tmp = 0;
    for (int j = 0; j < str.Length; j++)
    {
        if (str[i] == str[j])
        {
            tmp++;
        }
    }
    if (tmp == 1)
    {
        Console.WriteLine($"Уникальный символ {str[i]}");
        count++;
    }
}
Console.WriteLine($"Всего {count} уникальных символов");
