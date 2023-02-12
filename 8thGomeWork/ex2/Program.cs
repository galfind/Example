// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] MakeMeMatrix(int tables, int rows)
{
    int[,] matrix = new int[tables, rows];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}
void PrintMatr(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]} ");
        }
        System.Console.WriteLine(" ");
    }
}
void Min(int[,] arr)
{
    int[] res = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            res[i] += arr[i, j]; //48
        }
    }
    int min = 0;
    for (int i = 0; i < res.Length; i++)
    {
        if (res[i] < res[min])
        {
            min = i;
        }
    }
    System.Console.WriteLine($"Наименьшее значение {res[min]} в {min+1} строке");

}

System.Console.WriteLine("Введите количество столбцов");
int table = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите количество строк");
int row = int.Parse(Console.ReadLine());
int[,] matrx = MakeMeMatrix(row, table);
PrintMatr(matrx);
System.Console.WriteLine();
Min(matrx);