Console.Clear();


Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int num1 = number;
int reminder, reverse = 0;
while (number > 0)
{
    reminder = number % 10;
    reverse = (reverse * 10) + reminder;
    number = number / 10;
}  
if (reverse == num1){
    System.Console.WriteLine("Это палиндром");
}
else{
    System.Console.WriteLine("Это не палиндром");
}