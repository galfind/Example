Console.Clear();

int[] GetArr(int size, int minValue, int maxValue){
    int[] res = new int[size];
    for(int i = 0; i < size; i++){
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
void PrintArr(int[] col){
    System.Console.Write($"[{col[0]}");
    for(int i = 1; i < col.Length; i++){
    Console.Write($",{col[i]}");
    }
    System.Console.WriteLine("]");
}
int GetSum(int[] collection){
    int counter = 0;
    for (int i = 0; i<collection.Length; i++){
        if(i%2 != 0){
            counter += collection[i]; 
        }
    }
    return counter;
}
void main(){
    int[] arr = GetArr(5, 1, 20);
    PrintArr(arr);
    System.Console.WriteLine(GetSum(arr)); 
}
main();