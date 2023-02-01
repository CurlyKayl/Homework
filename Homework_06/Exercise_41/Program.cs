// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Вводим через один Enter (разбиваем через Split()).
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

void GetNumbers()
{
	Console.WriteLine("Введите числа: ");
	string nums = Console.ReadLine();
	string[] words = nums.Split("");
	Console.WriteLine(words);
}

GetNumbers();
//Console.WriteLine(numbers);