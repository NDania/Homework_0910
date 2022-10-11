// Задайте двумерный массив. Напишите программу, которая упоря-
// дочит по убыванию элементы каждой строки двумерного массива.

Console.Clear();

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0,11);
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Releasematrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int count = 1;
        int temp = 0;
        while(count < matrix.GetLength(1) - 1)
        {
            for(int j = 0; j < matrix.GetLength(1)-count; j++)
            {
                if(matrix[i, matrix.GetLength(1)-count] > matrix[i,j])
                {
                    temp = matrix[i, matrix.GetLength(1)-count];
                    matrix[i, matrix.GetLength(1)-count] = matrix [i,j];
                    matrix [i,j] = temp;
                }
            }        
            count++;  
        }  
    }
}    

Console.Write("Задайте количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputMatrix(matrix);
Console.WriteLine ("Исходная матрица: ");
PrintMatrix(matrix);
Releasematrix(matrix);
Console.WriteLine ("Отсортированная матрица: ");
PrintMatrix(matrix);