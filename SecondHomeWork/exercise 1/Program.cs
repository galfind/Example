Console.Clear();

Console.WriteLine("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());
int temp = num / 10;
num = temp % 10;
Console.WriteLine(num);