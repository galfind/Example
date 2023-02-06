int[] GetWrite(){
    System.Console.WriteLine("Введите числа: ");
    int[] arrValues = new int[2], Array.ConvertAll<string,int>(Console.ReadLine().Split(',', ' ', '.'), elem => { return int.Parse(elem);});
    System.Console.WriteLine(string.Join(" ", arrValues));
    return arrValues;
}
int CountPositives(int[] col){
    int counter = 0;
    for(int i = 0; i<col.Length; i++){
        if(col[i]>0){
            counter++;  
        }
    }
    return counter;
}
void main(){
    int[] array = GetWrite();
    System.Console.WriteLine($"{CountPositives(array)} элементов больше нуля");
}
main();