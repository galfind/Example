Console.Clear();

void FillArr(int[] collection){
    for(int i = 0; i <= 7; i++){
    Console.WriteLine($"Введите {i+1} число: ");
    collection[i] = int.Parse(Console.ReadLine());
    }
}

void PrintArr(int[] col){
    System.Console.Write($"[{col[0]}");
    for(int i = 1; i <= 7; i++){
    Console.Write($",{col[i]}");
    }
    System.Console.WriteLine("]");
}

void main(){
    int[] arr = new int[8];
    FillArr(arr);
    PrintArr(arr);
}
main();