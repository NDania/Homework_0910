//  Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

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
    int[] array = new int [matrix.GetLength(0)];
    int i_min = 0;    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < matrix.GetLength(1); j++)
           sum = sum + matrix [i,j];
        array [i] = sum;    
    }  
    Console.WriteLine($"Суммы по строкам [{string.Join(", ", array)}]");
    int min = array[array.Length-1];
    for(int i = 0; i < array.Length; i++)
    {
        if(min > array[i])
        {
            min = array[i];
            i_min = i+1;
        }   
    }
    Console.WriteLine ($"{i_min} строка");
}
  
Console.Write("Задайте количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputMatrix(matrix);
PrintMatrix(matrix);
Releasematrix(matrix);
