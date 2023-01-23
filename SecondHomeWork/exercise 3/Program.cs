Console.Clear();

Console.WriteLine("Введите цифру, обозначающую день недели: ");
int num = int.Parse(Console.ReadLine());
if (num > 7){
    Console.WriteLine("Нет такого дня недели.");
}
else{
    if (num == 7 || num == 6){
        Console.WriteLine("Да");
    }
    else{
        Console.WriteLine("Нет");
    }
}
