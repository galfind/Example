Console.Clear();



Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
if (num / 100 == 0){
    Console.WriteLine("Число двузначное");
}
else{
    int counter = 0;
    int i = 1;
    int temp = 10;
    do
    {
        i = num / temp;
        temp = temp * 10;
        counter = counter + 1;
    } while (i != 0);
    for (int a = counter-3; a > 0; a--)
    {
        temp = num/10;
        num = temp;
    }
    int res = num % 10;
    Console.WriteLine(res);
}


