int[,] MakeMeSnail(int size0, int size1)
{
    int[,] matrix = new int[size0, size1];
    int size = size0;
    int last_num = 1;
    int x = 0, y = 0;
    while (size > 0)
    {
        
        for (int i = y; i <= y + size - 1; i++)//верняя грань вправо меняем только столбец (0.Х)
        {
            matrix[x, i] = last_num++;
        }
        for (int j = x + 1; j <= x + size - 1; j++)//правая грань вниз меняем только строку (Х.0)
        {
            matrix[j, y + size - 1] = last_num++;
        }
        for (int i = y + size - 2; i >= y; i--)//Нижняя грань влево менгяем только столбец (0.Х) го в обратную сторону
        {
            matrix[x + size - 1, i] = last_num++;
        }
        for (int i = x + size - 2; i >= x + 1; i--)
        {
            matrix[i, y] = last_num++;
        }
        
        x = x + 1;
        y = y + 1;
        size = size - 2;
    }

    return matrix;
}
void PrintMatr(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]} \t");
        }
     System.Console.WriteLine(" ");
    }
}
int[,] matrx = MakeMeSnail(4,4);
PrintMatr(matrx);