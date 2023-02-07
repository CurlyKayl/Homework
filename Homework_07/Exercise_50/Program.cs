// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// пользователь вводит индексы 10, 10 - такого элемента нет.
// пользователь вводит индексы 0, 2 - выводим элеменет 7

Console.Clear();

int GetNumber(string message)
{
	int result = 0;
	while (true)
	{
		Console.Write(message);
		if (int.TryParse(Console.ReadLine(), out result))
		{
			break;
		}
		else
		{
			Console.WriteLine("Ошибка. Не верный ввод. Повторите ввод.");
		}
	}

	return result;
}


int[,] InitMatrix(int rows, int columns)
{
	int[,] matrix = new int[rows, columns];
	Random rnd = new Random();
	for (int i = 0; i < rows; i++)
	{
		for (int j = 0; j < columns; j++)
		{
			matrix[i,j] = rnd.Next(1, 10);
		}
	}
	return matrix;
}

void PrintMatrix(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			Console.Write($"{matrix[i,j]} ");
		}
		Console.WriteLine();
	}
}

Random ran = new Random();
//int ran1 = ran.Next(1, 10);




//int countOfRows = GetNumber("Введите количество строк в матрице: ");
//int countOfColumns = GetNumber("Введите количество столбцов в матрице: ");
int countOfRows = ran.Next(1, 10);
int countOfColumns = ran.Next(1, 10);

Console.WriteLine();
int[,] matrix = InitMatrix(countOfRows, countOfColumns);
//int[,] matrix = InitMatrix(ran1, ran1);

PrintMatrix(matrix);

int rowsOfPosicion = GetNumber("Введите номер строки в матрице: ");
int columnsOfPosicion = GetNumber("Введите номер столбца в матрице: ");

if (rowsOfPosicion > countOfRows || columnsOfPosicion > countOfColumns && countOfColumns == 0)
{
	Console.WriteLine("Такого элемента в матрице нет.");
}
else
{
	Console.WriteLine($"Эмелент матрицы с индексами: {rowsOfPosicion}, {columnsOfPosicion} равен {matrix[rowsOfPosicion, columnsOfPosicion]}");
}


