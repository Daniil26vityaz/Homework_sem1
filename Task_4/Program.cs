// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число N: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int count = 1;
Console.Write("Все четные числа от 0 до N: ");
if(number1 > 0){
    while(count < number1){
        if(count % 2 == 0){
            Console.Write(count + " ");
        }
    count++;
    }
}
else{
    while(count > number1){
        if(count % 2 == 0){
            Console.Write(count + " ");
        }
    count--;}
}
