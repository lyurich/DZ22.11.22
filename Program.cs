// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

/*
Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Число {A} в степени {B} равно {Stepen(A, B)}");

int Stepen(int A, int B)
{
    int rez = 1;
    for (int i = 1; i<= B; i++){
        rez = rez * A;
    }
    return rez;
}
*/



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

/*
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр в заданном числе равна {GetSum(number)} ");

int GetSum(int limit){
    int sum = 0;
    for (int i = number; i > 0; i = i/10){
        sum = sum + i%10;
    }
    return sum;
}
*/


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)

int[] array = new int[8];
Console.WriteLine("Введите начальный диапазон массива: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите конечный диапазон массива: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Массив [{String.Join(", ", Mass(array))}]");

int[] Mass (int[] array)
{
    for (int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(a, b + 1);
    }
    return array;
}
