void Zadacha54()
{
    // Задача 54: Задайте двумерный массив. Напишите программу, 
    // которая упорядочит по убыванию элементы каждой строки двумерного массива.
    // Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // В итоге получается вот такой массив:
    // 7 4 2 1
    // 9 5 3 2
    // 8 4 4 2

    Console.WriteLine("______________________________________");
    Console.WriteLine("Задача 54.");
    Console.WriteLine("Сколько строк будет в массиве?");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Сколько столбцов будет в массиве?");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine($"Массив размера {rows}*{columns}:");
    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);
    SortDescending(numbers);
    Console.WriteLine();
    Console.WriteLine("Вывод отсортированного массива, у которого элементы строки расположены по убыванию: ");
    PrintArray(numbers);

    void SortDescending(int[,] numbers)
    {

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                for (int m = j + 1; m < columns; m++)
                {
                    if (numbers[i, j] < numbers[i, m])
                    {
                        int temp = numbers[i, j];
                        numbers[i, j] = numbers[i, m];
                        numbers[i, m] = temp;
                    }
                }
            }
        }
    }
}
Zadacha54();

void Zadacha56()
{
    // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
    // Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // 5 2 6 7
    // Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
    Console.WriteLine("______________________________________");
    Console.WriteLine("Задача 56.");
    Console.WriteLine("Необходимо задать прямоугольный массив:");
    Console.WriteLine("Сколько строк будет в массиве?");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Сколько столбцов будет в массиве?");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine($"Массив размера {rows}*{columns}:");
    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);

    int sum = 0;
    Console.WriteLine();
    for (int i = 0; i < rows; i++)
    {
        sum = 0;
        for (int j = 0; j < columns; j++)
        {
            sum = sum + numbers[i, j];

        }

        Console.WriteLine($"В {i + 1} строке сумма элементов равна {sum}");
    }

    int minSum = int.MaxValue;
    int index = 0;
    for (int i = 0; i < rows; i++)
    {
        int temp = 0;
        for (int j = 0; j < columns; j++)
        {
            temp = temp + numbers[i, j];
        }
        if (temp < minSum)
        {
            minSum = temp;
            index = i;
        }
    }
    Console.WriteLine($"Минимальная сумма элементов {minSum} находится в {index + 1} строкe.");
    Console.WriteLine();

}
Zadacha56();

void Zadacha58()
{
    // Задача 58: Напишите программу, которая заполнит спирально массив 4 на 4. 
    // Например, на выходе получается вот такой массив:
    // 01 02 03 04
    // 12 13 14 05
    // 11 16 15 06
    // 10 09 08 07
    Console.WriteLine("______________________________________");
    Console.WriteLine("Задача 58.");
    Console.WriteLine("Массив 4*4, заполненный спирально");
    int n = 4;
    int[,] numbers = new int[n, n];
    int value = 01;
    for (int i = 0; i < n / 2; i++)
    {
        for (int j = i; j < n - i; j++)
        {
            numbers[i, j] = value++;
        }
        for (int k = i + 1; k < n - i; k++)
        {
            numbers[k, n - 1 - i] = value++;
        }
        for (int j = n - i - 2; j >= i; j--)
        {
            numbers[n - 1 - i, j] = value++;
        }
        for (int k = n - 2 - i; k > i; k--)
        {
            numbers[k, i] = value++;
        }
    }
    PrintArray(numbers);
    Console.WriteLine();
}
Zadacha58();


void FillArray(int[,] numbers,
                  int minValue = 1,
                  int maxValue = 9)
{
    maxValue++;
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.Next(minValue, maxValue);
        }
    }
}
void PrintArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(numbers[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
