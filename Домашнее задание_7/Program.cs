Console.Clear();

// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.


//Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    }
}

int ReadInt(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()!);
}

int[,] CreateMatrix(int row, int column)
{
    // row = ReadInt("Введите начало промежутка, в котором будут задаваться числа в массиве: ");
    // column = ReadInt("Введите конец промежутка, в котором будут задаваться числа в массиве: ");
    Random rnd = new Random();
    int[,] matr = new int[row, column];

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(-10, 10);

        }

    }
    return matr;
}

int[,] matrix = CreateMatrix(ReadInt("Введите количество строк в массиве: "),
ReadInt("Введите количество столбцов в массиве: "));
PrintMatrix(matrix);




//В прямоугольной матрице найти строку с наименьшей суммой элементов.

