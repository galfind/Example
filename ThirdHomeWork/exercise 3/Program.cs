Console.Clear();


Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int i = 1;
System.Console.Write($"{i}");
for(i = 2;i<=number; i++){
    System.Console.Write($", {Math.Pow(i, 3)}");

}   
