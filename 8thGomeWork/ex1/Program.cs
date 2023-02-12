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
int[,] Bubble(int[,] arr){
    int temp = 0;
    int[] res = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j<arr.GetLength(1); j++){
            for (int k = 0; k < arr.GetLength(1)-j-1; k++)
            {
                if(arr[i,k]<arr[i,k+1]){
                temp = arr[i,k];
                arr[i,k] = arr[i,k+1];
                arr[i,k+1] = temp;
            }
            }
        }
    }
    return arr;
}
System.Console.WriteLine("Введите количество столбцов");
int table = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите количество строк");
int row = int.Parse(Console.ReadLine());
int[,] matrx = MakeMeMatrix(row,table);
PrintMatr(matrx);
System.Console.WriteLine();
PrintMatr(Bubble(matrx));