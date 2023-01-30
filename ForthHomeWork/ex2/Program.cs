Console.Clear();

int count(int A){
    if(A<0){
     A = A * -1;
    }
    int div, res = 0;
    while (A>0){
        div = A%10;
        res += div;
        A = A/10;
    }
    return res;
}

void main(){
    Console.WriteLine("Введите числo: ");
    int num1 = int.Parse(Console.ReadLine());
    System.Console.WriteLine(count(num1));
}
main();