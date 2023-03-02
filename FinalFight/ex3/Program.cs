int Mikasa(int m, int n)
{
  if (m==0)
  {
    return n+1;
  }
  if((n==0)&&(m>0)){
    return Mikasa(m-1,1);
  }
  else{
    return Mikasa(m - 1, Mikasa(m, n - 1));
  }
}
System.Console.WriteLine("Введите 1 число");
int m = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите 2 число");
int n = int.Parse(Console.ReadLine());
System.Console.WriteLine(Mikasa(m, n));