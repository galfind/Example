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
int[] GetBubble(int[] collection){
    int max = collection[0];
    int temp = 0;
    int index = 0;
    for (int i = 0; i<collection.Length; i++){
        for (int j = 0; j<collection.Length; j++){
            if(collection[i]>collection[j]){
                temp = collection[i];
                collection[i] = collection[j];
                collection[j] = temp;
            }
        }

    }
    return collection;
}
    
void main(){
    int[] arr = GetArr(5, -10, 20);
    PrintArr(arr);
    PrintArr(GetBubble(arr)); 
}
main();