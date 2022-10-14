// Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.

Console.Clear();

void InputMatrix(int[,] matrixFirst, int[,] matrixSec)
{
    Console.WriteLine("Введите элементы первой матрицы: ");
    for (int i = 0; i < matrixFirst.GetLength(0); i++)
    {
        for(int j = 0; j < matrixFirst.GetLength(1); j++)
            matrixFirst[i,j] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Первая матрица");
    for (int i = 0; i < matrixFirst.GetLength(0); i++)
    {
        for(int j = 0; j < matrixFirst.GetLength(1); j++)
            Console.Write(matrixFirst[i, j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine("Введите элементы второй матрицы: ");
    for (int i = 0; i < matrixSec.GetLength(0); i++)
    {
        for(int j = 0; j < matrixSec.GetLength(1); j++)
            matrixSec[i,j] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Вторая матрица");
    for (int i = 0; i < matrixSec.GetLength(0); i++)
    {
        for(int j = 0; j < matrixSec.GetLength(1); j++)
            Console.Write(matrixSec[i, j] + "\t");
        Console.WriteLine();
    }
}

void ReleaseMatrix(int[,] matrixFirst, int[,] matrixSec)
{
    int [,] matrixRes = new int[matrixFirst.GetLength(0), matrixSec.GetLength(1)];
    Console.WriteLine();
    Console.WriteLine("Результирующая матрица");
    for(int i = 0; i < matrixRes.GetLength(0); i++)
    {
        for (int j = 0; j < matrixRes.GetLength(1); j++)
        {
            matrixRes[i,j] = 0;
            for(int x = 0; x < matrixRes.GetLength(0); x++)
                matrixRes[i,j] = matrixFirst[i,x] * matrixSec[x,j] + matrixRes[i,j];
            Console.Write(matrixRes[i, j] + "\t");
        }
        Console.WriteLine();
    }
}    

Console.Write("Введите кол-во строк первой матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов первой матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrixFirst = new int[n, m];
Console.Write("Введите кол-во строк второй матрицы: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов второй матрицы: ");
int l = Convert.ToInt32(Console.ReadLine());
int[,] matrixSec = new int[k, l];

if ( m != k)
    Console.WriteLine("Такие матрицы нельзя перемножить");
else    
    {
        InputMatrix(matrixFirst, matrixSec);
    ReleaseMatrix(matrixFirst, matrixSec);
    }

