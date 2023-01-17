Console.WriteLine("Введите число");
int num1 = int.Parse(Console.ReadLine());
for (int i = 0; i < num1; i++)
{
    if (i % 2 == 0){
        Console.Write(i + " ");
    }
}