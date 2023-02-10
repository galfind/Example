double[,] MakeMeMatrix(int tables, int rows){
    double[,] matrix = new double [tables, rows];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = Math.Round((double)(new Random().Next(-10, 10))+(new Random().NextDouble()), 3);
        }   
    }
    return matrix;
}
void PrintMatr(double[,] matr){
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]} ");
        }   
        System.Console.WriteLine(" ");
    }
}
System.Console.WriteLine("Введите количество столбцов");
int table = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите количество строк");
int row = int.Parse(Console.ReadLine());
double[,] matrx = MakeMeMatrix(4,4);
PrintMatr(matrx);