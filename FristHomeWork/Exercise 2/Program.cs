Console.WriteLine("Введите три числа");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());
if (num1 > num2 && num1 > num3 ){
    Console.WriteLine("Max = " + num1);
}
else if (num2 > num1 && num2 > num3 ){
    Console.WriteLine("Max = " + num2);
}
else{
    Console.WriteLine("Max = " + num3);
}
