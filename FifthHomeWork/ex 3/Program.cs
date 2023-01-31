Console.Clear();

double[] GetArr(int size, int minValue, int maxValue){
    double[] res = new double[size];
    for(int i = 0; i < size; i++){
        double all =(double)(new Random().Next(minValue, maxValue))+(new Random().NextDouble());
        res[i] = all;
    }
    return res;
}
void PrintArr(double[] col){
    System.Console.Write($"[{col[0]}");
    for(int i = 1; i < col.Length; i++){
    Console.Write($",{col[i]}");
    }
    System.Console.WriteLine("]");
}
double MinMax(double[] collection){
    double unSum = 0;
    double max = collection[0];
    double min = collection[0];
    for (int i = 0; i<collection.Length; i++){
        if(max < collection[i]){
            max = collection[i]; 
        }
    }
    for (int i = 0; i<collection.Length; i++){
        if(min > collection[i]){
            min = collection[i]; 
        }
    }
    unSum = max - min;
    return unSum;
}
void main(){
    double[] arr = GetArr(5, 1, 20);
    PrintArr(arr);
    System.Console.WriteLine(MinMax(arr)); 
}
main();