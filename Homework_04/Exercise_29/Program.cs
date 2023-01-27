// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();

int numbers = 8;

int[] Array = new int[numbers];

Random NewRand = new Random();

for (int i = 0; i < Array.Length; i++)

{
    Array[i] = NewRand.Next(0,100);
}

Console.WriteLine(string.Join(", ", Array));
