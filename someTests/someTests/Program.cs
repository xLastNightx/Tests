// Табл умножения
/*
for (int i = 1; i < 10; i++)
{
    for (int j = 1; j < 10; j++)
    {
        Console.Write($"{i * j} \t");
    }
    Console.WriteLine();
}
*/

// Массив (матрица) 2 ранговый
/*
int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 } };

int rows = numbers.GetUpperBound(0) + 1;    // количество строк
Console.WriteLine(rows);
int columns = numbers.Length / rows;        // количество столбцов
Console.WriteLine(columns);
                                            // или так
                                            // int columns = numbers.GetUpperBound(1) + 1;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{numbers[i, j]} \t");
    }
    Console.WriteLine();
}
*/

// Массив массивов
/*
int[][] numbers1 = new int[3][];
numbers1[0] = new int[] { 1, 2 };
numbers1[1] = new int[] { 1, 2, 3 };
numbers1[2] = new int[] { 1, 2, 3, 4, 5 };
// можно так
foreach (int[] row in numbers1)
{
    foreach (int number in row)
    {
        Console.Write($"{number} \t");
    }
    Console.WriteLine();
}

// или перебор с помощью цикла for
for (int i = 0; i < numbers1.Length; i++)
{
    for (int j = 0; j < numbers1[i].Length; j++)
    {
        Console.Write($"{numbers1[i][j]} \t");
    }
    Console.WriteLine();
}
*/

// переворот массива
/*
int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };

int n = numbers.Length; // длина массива
int k = n / 2;          // середина массива
int temp;               // вспомогательный элемент для обмена значениями
for (int i = 0; i < k; i++)
{
    temp = numbers[i];
    numbers[i] = numbers[n - i - 1];// количество_элементов - первый_элемент - 1(ибо количество числе на 1 больше, чем индексы)
    numbers[n - i - 1] = temp;
}
foreach (int i in numbers)
{
    Console.Write($"{i} \t");
}
*/

// сортировка
/*
int[] nums = { 54, 7, -41, 2, 4, 2, 89, 33, -5, 12 };

int temp;
for (int i = 0; i < nums.Length - 1; i++)
{
    for (int j = i + 1; j < nums.Length; j++)
    {
        if (nums[i] > nums[j])
        {
            temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}

// вывод
Console.WriteLine("Вывод отсортированного массива");
for (int i = 0; i < nums.Length; i++)
{
    Console.WriteLine(nums[i]);
}
*/

void SayHelloRu()
{
    Console.WriteLine("Привет");
}
void SayHelloEn()
{
    Console.WriteLine("Hello");
}
void SayHelloFr()
{
    Console.WriteLine("Salut");
}


string language = "fr";

switch (language)
{
    case "en":
        SayHelloEn();
        break;
    case "ru":
        SayHelloRu();
        break;
    case "fr":
        SayHelloFr();
        break;
}