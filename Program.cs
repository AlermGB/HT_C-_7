// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void TaskNumberWrite(int taskNumber)
{
    Console.WriteLine($"Задача {taskNumber}.");
    Console.WriteLine();
}

int[,] FillMatrixInt(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(0, 11);
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    return matrix;
}

Console.WriteLine();
Console.WriteLine("Приветствую вас, Алексей! Введите номер задачи из домашнего задания для проверки(47,50 или 52)");

int taskNumber = Convert.ToInt16(Console.ReadLine());
Console.WriteLine();

//Первая задача (47)
if (taskNumber == 47)
{
    TaskNumberWrite(taskNumber);

    Console.WriteLine("Введите размерность двумерного массива m x n");
    Console.Write("Введите m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int maxBorder = 10;
    int minBorder = -10;


    double[,] matrix = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = Math.Round(minBorder + new Random().NextDouble() * (maxBorder - minBorder), 2);
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

//Вторая задача (50)
else if (taskNumber == 50)
{
    TaskNumberWrite(taskNumber);

    Console.WriteLine("Введите размерность двумерного массива m x n");
    Console.Write("Введите m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int[,] mainMatrix = FillMatrixInt(m, n);

    Console.Write("Введите положение элемента в строке: ");
    int stringPosition = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите положение элемента в столбце: ");
    int columnPosition = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    if (stringPosition >= m || columnPosition >= n)
    {
        Console.WriteLine("Такого элемента не существует");
    }
    else
    {
        Console.WriteLine($"Значение элемента ({stringPosition}, {columnPosition}): {mainMatrix[stringPosition, columnPosition]}");

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == stringPosition && j == columnPosition)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write(mainMatrix[i, j] + " ");
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.Write(mainMatrix[i, j] + " ");
                }
            }
            Console.WriteLine();
        }
    }

}
//Третья задача (52)
else if (taskNumber == 52)
{
    TaskNumberWrite(taskNumber);

    Console.WriteLine("Введите размерность двумерного массива m x n");
    Console.Write("Введите m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int[,] mainMatrix = FillMatrixInt(m, n);

    int[] arrayOfColumnSum = new int[n];
    double[] arrayOfAverage = new double[n];

    for (int i = 0; i < n; i++){
        for (int j = 0; j < m; j++){
        arrayOfColumnSum[i]+= mainMatrix[j,i];
        }
    }
    for (int i = 0; i < n; i++){
        arrayOfAverage[i] = Math.Round(Convert.ToDouble(arrayOfColumnSum[i])/m,2);
        Console.WriteLine($"Среднее арифметическое для столбца №{i+1}: { arrayOfAverage[i]} ");
    }
}

else
{
    Console.WriteLine("Увы, в этом блоке представлено только три задачи: 47, 50 и 52");
}

Console.WriteLine();
Console.WriteLine("Всего доброго.");
Console.WriteLine();