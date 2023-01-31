Console.Clear();

int[] GetArr(int size, int minValue, int maxValue){
    int[] res = new int[size];
    for(int i = 0; i < size; i++){
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
int GetDiv(int[] collection){
    int counter = 0;
    for (int i = 0; i<collection.Length; i++){
        if(collection[i]%2 == 0){
            counter++;
        }
    }
    return counter;
}
void PrintArr(int[] col){
    System.Console.Write($"[{col[0]}");
    for(int i = 1; i < col.Length; i++){
    Console.Write($",{col[i]}");
    }
    System.Console.WriteLine("]");
}
void main(){
    int[] arr = GetArr(5, 100, 999);
    PrintArr(arr);
    System.Console.WriteLine(GetDiv(arr)); 
}
main();