int[,] MakeMeMatrix(int tables, int rows){
    int[,] matrix = new int [tables, rows];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1,10);
        }   
    }
    return matrix;
}
void PrintMatr(int[,] matr){
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]} ");
        }   
        System.Console.WriteLine(" ");
    }
}
void Average(int[,] arr){
    double sum = 0;
    double[] res = new double[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i,j];
        }
        res[i] = sum/arr.GetLength(1);
    }
    for (int i = 0; i < res.Length; i++)
    {
        System.Console.Write($"{res[i]} ");
    }
}
System.Console.WriteLine("Введите количество столбцов");
int table = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите количество строк");
int row = int.Parse(Console.ReadLine());
int[,] matrx = MakeMeMatrix(row,table);
PrintMatr(matrx);
System.Console.WriteLine();
Average(matrx);