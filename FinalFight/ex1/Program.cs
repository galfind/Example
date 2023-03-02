void RecSum(int n)
{
    if (n > 1)
    {
        System.Console.Write($"{n}, ");
        n = n - 1;
        RecSum(n);
    }
    else{
        System.Console.WriteLine("1");
    }
    
}
System.Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
RecSum(n);