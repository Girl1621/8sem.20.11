//Задача 53: Задайте двумерный массив. Напишите программу, 
//которая поменяет местами первую и последнюю строку массива.

Console.WriteLine("Введите m - ");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Введите n - ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

int[,] array = CreateRandom2DArray(m, n);

PrintArray(array);

SwapArrayRows(array);

Console.WriteLine();

int[,] result = SwapArrayRows(array);

PrintArray(result);

int[,] CreateRandom2DArray(int m, int n)
{
    int[,] array = new int[m, n];

    Random random = new Random();

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }

    return array;
}

int[,] SwapArrayRows(int[,] array)
{
    for (var j = 0; j < array.GetLength(1); j++)
    {
        int help = array[0, j];
        array[0, j] = array[array.GetLength(0) -1 , j];
        array[array.GetLength(0) -1, j] = help;
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


//Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.   
