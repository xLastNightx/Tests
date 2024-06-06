<<<<<<< HEAD
﻿Console.WriteLine("Введите предложение");
string? str = Console.ReadLine();

if (str != null) Console.WriteLine(reverseWordsInString(str));
else Console.WriteLine("Неверное значение");

static string reverseWordsInString(string stringFromConsole)
{
    string[] massivWithWords = stringFromConsole.Split(' ');
    string readyString = "";

    for (int i = 0; i < massivWithWords.Length; i++)
    {
        char[] charArray = massivWithWords[i].ToCharArray();
        Array.Reverse(charArray);

        readyString += new string(charArray);
        readyString += " ";
    }
    readyString = readyString.Trim();

    return readyString;
}

=======
﻿Console.WriteLine("Введите предложение");
string? str = Console.ReadLine();

if (str != null) Console.WriteLine(reverseWordsInString(str));
else Console.WriteLine("Неверное значение");

static string reverseWordsInString(string stringFromConsole)
{
    string[] massivWithWords = stringFromConsole.Split(' ');
    string readyString = "";

    for (int i = 0; i < massivWithWords.Length; i++)
    {
        char[] charArray = massivWithWords[i].ToCharArray();
        Array.Reverse(charArray);

        readyString += new string(charArray);
        readyString += " ";
    }
    readyString = readyString.Trim();

    return readyString;
}

>>>>>>> a788ec5cb90086892f69ac625c79092f011c81ff
