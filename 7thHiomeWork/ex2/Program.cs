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
int[] GetWrite(){
    System.Console.WriteLine("Введите индкс искомого числа: ");
    int[] arrValues = Array.ConvertAll<string,int>(Console.ReadLine().Split(',', ' ', '.'), elem => { return int.Parse(elem);});
    // System.Console.WriteLine(string.Join(" ", arrValues));
    return arrValues;
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
void SearchInMatrx(int[,] arr, int[] flag){
    if (flag[0] > arr.GetLength(0) || flag[1] > arr.GetLength(1)){
        System.Console.WriteLine("Не входит в массив");
    }
    else{
        System.Console.WriteLine(arr[flag[0],flag[1]]);
    }
}
System.Console.WriteLine("Введите количество столбцов");
int table = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите количество строк");
int row = int.Parse(Console.ReadLine());
int[] index = GetWrite();
int[,] matrx = MakeMeMatrix(row,table);
PrintMatr(matrx);
System.Console.WriteLine();
SearchInMatrx(matrx, index);