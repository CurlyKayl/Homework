// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

int GetNumber(string message)
{
	int result = 0;
	while (true)
	{
		Console.Write(message);

		if (int.TryParse(Console.ReadLine(), out result) && result > 0)
		{
			break;
		}
		else
		{
			Console.WriteLine("Ошибка. Не корректный ввод. Повторите ввод.");
		}
	}	
	return result;
}

int[,] InitMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = random.Next(10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
	Console.WriteLine();
    int sumOfElements;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sumOfElements = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumOfElements += matrix[i, j];
            Console.Write($"{matrix[i, j]}  ");
        }
        Console.Write($"=> {sumOfElements}");
        Console.WriteLine();
    }
	Console.WriteLine();
}

int GetMinSum(int[,] matrix)
{
    int sumOfElements = 0;
    int minSumOfElements = 0;
    int minSumElementsRow = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sumOfElements = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumOfElements += matrix[i, j];
        }
        if (i == 0)
        {
            minSumOfElements = sumOfElements;
            minSumElementsRow = i;
        }
        else if (sumOfElements < minSumOfElements)
        {
            minSumElementsRow = i;
            minSumOfElements = sumOfElements;
        }
    }
    return minSumElementsRow;
}

int rows = GetNumber("Введите количество строк в матрице: ");
int columns = GetNumber("Введите количество столбцов в матрице: ");
int[,] matrix = InitMatrix(rows, columns);
PrintMatrix(matrix);
Console.WriteLine($"Строка с наименьшей суммой элементов: {GetMinSum(matrix) + 1}");