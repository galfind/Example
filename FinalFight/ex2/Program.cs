int RecSum(int n, int m)
{
    if (n < m)
    {
        return n + RecSum(n+1,m);
    }
    else{
        return m;
    }
    
}
System.Console.WriteLine("Введите начало диапазона");
int n = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите конец диапазона");
int m = int.Parse(Console.ReadLine());
System.Console.WriteLine(RecSum(n, m));