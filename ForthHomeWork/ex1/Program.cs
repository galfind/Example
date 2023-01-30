Console.Clear();

int Count(int A, int B){
    int res = 1;
    for(int i = 0; i<B; i++){
        res *= A;
    }
    return res;
}

void main(){
    Console.WriteLine("Введите два числа: ");
    int num1 = int.Parse(Console.ReadLine());
    int num2 = int.Parse(Console.ReadLine());
    System.Console.WriteLine(Count(num1, num2));
}
main();