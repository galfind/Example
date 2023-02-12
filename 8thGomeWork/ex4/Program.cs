int[,,] MakeMeMatrix(int tables, int rows, int ThirdMetric)
{
    int[,,] matrix = new int[tables, rows, ThirdMetric];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int x = 0; x < matrix.GetLength(2); x++)
            {
                matrix[i, j, x] = new Random().Next(1, 10);
            }
            
        }
    }
    return matrix;
}
void PrintMatr(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int x = 0; x < matr.GetLength(2); x++)
            {
                System.Console.Write($"{matr[i, j, x]} ({i},{j},{x})\t");
            }
            System.Console.WriteLine(" "); 
        }
        
    }
}
int[,,] matrx = MakeMeMatrix(2,2,2);
PrintMatr(matrx);