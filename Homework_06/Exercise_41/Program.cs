// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Вводим через один Enter (разбиваем через Split()).
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

Console.WriteLine("Введите числа через пробел: ");
string[] arr = Console.ReadLine()!.Split(" ");
int count = 0;
foreach (var nums in arr)
	if (int.Parse(nums) > 0) count++; 
Console.WriteLine($"Чисел больше нуля в массиве: {count}");