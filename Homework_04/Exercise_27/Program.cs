// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

public static int Power(int a, int b) 
{ 
    int result = 1; 
    for (int i = 0; i < b; i++) 
    { 
        result *= a; 
    } 
    return result; 
}