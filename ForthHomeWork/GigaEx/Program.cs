
Console.Clear();
void tree(int A){
    int counter = 1;
    for (int i = 1; i<=A; i++){
        string Dot = new string ('*', counter);
        Console.SetCursorPosition((Console.WindowWidth - Dot.Length) / 2, Console.CursorTop);
        Console.WriteLine(Dot);
        counter += 2;
    }
}
void main(){
    Console.WriteLine($"Введите высоту: ");
    int Height = int.Parse(Console.ReadLine());
    tree(Height);
}
main();