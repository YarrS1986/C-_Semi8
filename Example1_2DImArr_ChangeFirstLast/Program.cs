// Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

Console.Clear();

int n = Promt("Введи количество n строк = ");
int m = Promt("Введи количество m столбцов = ");

int[,] dimArray = FillArray(n, m);
PrintArray(dimArray);
ChangeFirstLast(dimArray);
Console.WriteLine();
PrintArray(dimArray);

//--------------------------
void ChangeFirstLast(int[,] changeTo)
{
    for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < changeTo.GetLength(1); j++)
        {
            int temp = changeTo[i, j];
            changeTo[i, j] = changeTo[changeTo.GetLength(0) - i - 1, j];
            changeTo[changeTo.GetLength(0) - i - 1, j] = temp;
        }
    }
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