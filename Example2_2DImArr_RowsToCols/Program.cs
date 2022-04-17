// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.

Console.Clear();

int n = Promt("Введи количество n строк = ");
int m = Promt("Введи количество m столбцов = ");

int[,] dimArray = FillArray(n, m);
PrintArray(dimArray);

Console.WriteLine();

int[,] newArray = RowToColls(dimArray);
PrintArray(newArray);

//--------------------------
int[,] RowToColls(int[,] Array)
{
    int[,] changedArray = new int[Array.GetLength(1), Array.GetLength(0)];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            changedArray[j, i] = Array[i, j];
        }
    }
    return changedArray;
}

int[,] FillArray(int rows, int collums)
{
    int[,] array = new int[rows, collums];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

int Promt(string message)
{
    Console.Write(message);
    int answer = int.Parse(Console.ReadLine());
    return answer;
}