Console.Clear();

int [] x = new int[2];
int [] y = new int[2];
int [] z = new int[2];
for (int i = 0; i<2; i++){
    System.Console.WriteLine("Введите координату x" + i);
    x[i] = int.Parse(Console.ReadLine());
    System.Console.WriteLine("Введите координату y" + i);
    y[i] = int.Parse(Console.ReadLine());
    System.Console.WriteLine("Введите координату z" + i);
    z[i] = int.Parse(Console.ReadLine());
}
double result = Math.Sqrt(Math.Pow((x[0]-x[1]), 2) + Math.Pow((y[0]-y[1]), 2) + Math.Pow((z[0]-z[1]), 2));
System.Console.WriteLine(result);