// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// пользователь вводит индексы 10, 10 - такого элемента нет.
// пользователь вводит индексы 0, 2 - выводим элеменет 7

Console.Clear();

int[,] InitRandomMatrix()
{
	Random ran = new Random();
	int rows = ran.Next(1, 10);
	int columns = ran.Next(1, 10);

	int[,] matrix = new int[rows, columns];
	for (int i = 0; i < rows; i++)
	{
		for (int j = 0; j < columns; j++)
		{
			matrix[i,j] = ran.Next(1, 10);
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

void MatrixElement(int[,] matrix)
{
	int rows = 0;
	int columns = 0;
	while (true)
	{
		Console.Write("Введите строку эмелента матрицы: ");
		if (int.TryParse(Console.ReadLine(), out rows)) 
		{
			break;
		}
		else
		{
			Console.WriteLine("Ошибка. Не верный ввод. Повторите ввод.");
		}
	}
	while (true)
	{
		Console.Write("Введите столбец эмелента матрицы: ");
		if (int.TryParse(Console.ReadLine(), out columns))
		{
			break;
		}
		else
		{
			Console.WriteLine("Ошибка. Не верный ввод. Повторите ввод.");
		}

	}
	if (rows <= matrix.GetLength(0) && columns <= matrix.GetLength(1))
	{
		Console.WriteLine($"Элемент с индексами {rows} и {columns} равен: {matrix[rows, columns]}");
	}
	else
	{
		Console.WriteLine("Такого элемента в матрице нет.");
	}
}

int[,] matrix = InitRandomMatrix();
PrintMatrix(matrix);
Console.WriteLine();
MatrixElement(matrix);

