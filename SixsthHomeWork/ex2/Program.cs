// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double[] Interceprion(double[] col){
    if(col[1] == col[3]){
        System.Console.WriteLine("Прямые параллельны, точки пересечения нет");
        return null;
    }
    else{
        double x = (col[2]-col[0])/(col[1]-col[3]);
        double y = (col[1]*x) + col[0];
        double[] arr = {x, y};
         return arr;
    }
}

void main(){
    System.Console.WriteLine("Введите b1, k1, b2, k2");
    double[] arrValues = Array.ConvertAll<string,double>(Console.ReadLine().Split(',', ' ', '.'), elem => { return int.Parse(elem);});
    System.Console.WriteLine(string.Join(" ", Interceprion(arrValues))); 
}
main();