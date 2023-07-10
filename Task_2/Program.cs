// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
double number2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
double number3 = Convert.ToDouble(Console.ReadLine());
double max = 0;
if(number1>number2){
    if(number1>number3){
        max=number1;
        Console.WriteLine("max = " + max);
    }
    else{
        max=number3;
        Console.WriteLine("max = " + max);
    }
}
else{
    if(number2>number3){
        max=number2;
        Console.WriteLine("max = " + max);
    }
    else{
        max=number3;
        Console.WriteLine("max = " + max);}
    }
