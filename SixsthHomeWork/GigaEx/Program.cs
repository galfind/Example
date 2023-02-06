// //Напишите программу, которая реализует обход введенного двумерного массива, начиная с крайнего нижнего левого элемента против часовой стрелки.

// // 1 2 3
// // 4 5 6 -> 7 8 9 6 3 2 1 4 5
// // 7 8 9




I lost this battle
But not the War






// int[,] MakeMeMatrix(int tables, int rows){
//     int[,] matrix = new int [tables, rows];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = new Random().Next(1,10);
//         }   
//     }
//     return matrix;
// }
// void PrintMatr(int[,] matr){
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             System.Console.Write($"{matr[i, j]} ");
//         }   
//         System.Console.WriteLine(" ");
//     }
// }
// void Spiral(int[,] m)
//     {
//         int n = m.GetUpperBound(0);
//         for (int i = 0; i < n / 2; ++i)
//          {
//             for (int j = i; j <= n - i; ++j)
//                 Console.Write(m[i, j] + " ");
//             for (int j = i + 1; j <= n - i; ++j)
//                 Console.Write(m[j, n - i] + " ");
//              for (int j = i + 1; j <= n - i; ++j)
//                 Console.Write(m[n - i, n - j] + " ");
//              for (int j = i + 1; j < n - i; ++j)
//                 Console.Write(m[n - j, i] + " ");
//          }
//  //       Console.Write(m[n / 2, n / 2]+" ");
//      //   if (n % 2 == 1)
//         // {
//         //     Console.Write(m[n / 2, n / 2+1] + " ");
//         //     Console.Write(m[n / 2+1, n / 2+1] + " ");
//         //     Console.Write(m[n / 2+1, n / 2] + " ");
//         // }
//     }
// // System.Console.WriteLine("Введите количество столбцов");
// // int table = int.Parse(Console.ReadLine());
// // System.Console.WriteLine("Введите количество строк");
// // int row = int.Parse(Console.ReadLine());
// int[,] matrx = MakeMeMatrix(4,4);
// PrintMatr(matrx);
// System.Console.WriteLine(" ");
// Spiral(matrx);

// ///Rotate(int xPos,int yPos){

// //         int endInd = 0;
// //         int temp = 0;
// //         for (temp = temp; temp < xPos; temp++)
// //         {
// //             System.Console.Write($"{matrx[xPos-1, temp]} ");
// //             endInd = temp;
// //         }
// //         temp = endInd;
// //         for (temp = temp; temp > 0; temp--)
// //         {
// //             System.Console.Write($"{matrx[temp-1, xPos-1]} ");
// //             endInd = temp;
// //         }
// //         temp = endInd;
// //         for (temp = 2; temp <= xPos; temp++)
// //         {
// //             System.Console.Write($"{matrx[0, xPos-temp]} ");
// //             endInd = temp;
// //         }
// //         temp = endInd;
// //         for (temp = temp; temp > 0; temp--)
// //         {
// //             System.Console.Write($"{matrx[temp-1, xPos-1]} ");
// //             endInd = temp;
// //         }
// //         temp = endInd;
// //         for (temp = temp; temp < yPos-1; temp++)
// //         {
// //             System.Console.Write($"{matrx[temp, 0]} ");
// //             endInd = temp;
// //         }
// // }   