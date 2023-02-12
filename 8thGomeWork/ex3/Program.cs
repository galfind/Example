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
int[,] Product(int[,] mtx1, int[,] mtx2)
{
    int[,] result = new int[mtx1.GetLength(0), mtx2.GetLength(1)];
    for (int i = 0; i < mtx1.GetLength(0); i++)
    {
        for (int j = 0; j < mtx2.GetLength(1); j++)
        {
            for (int k = 0; k < mtx2.GetLength(1); k++)
            {
                result[i, j] += (mtx1[i, k] * mtx2[k, j]);
            }
        }
    }
    return result;
}
void main()
{
    int[,] matrx = {
                {2,4},
                {3,2}
};
    PrintMatr(matrx);
    System.Console.WriteLine();
    int[,] matrx1 = new int[,] {
                            {3,4},
                            {3,3}
};
    PrintMatr(matrx1);
    System.Console.WriteLine();
    if (matrx.GetLength(0) == matrx1.GetLength(1))
    {
        int[,] res = Product(matrx, matrx1);
        PrintMatr(res);
    }
    else
    {
        System.Console.WriteLine("Умножение матрицы невозможно");
    }
}
main();