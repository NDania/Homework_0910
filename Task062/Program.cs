// Напишите программу, которая заполнит спирально массив 4 на 4.

Console.Clear();

void Releasematrix(int[,] matrix)
{
    int count = 1;
    for (int i = 0; i < matrix.GetLength(0)/2; i++)
    {
        for(int j = i; j < matrix.GetLength(1)-i; j++)
        {   
            matrix[i,j] = count++; 
        }     
        for(int k = i + 1; k < matrix.GetLength(0)-i; k++)
        {
            matrix[k, matrix.GetLength(1)-i-1] = count++;
        }
        for (int j = matrix.GetLength(1)-i-2; j >= i; j--)   
        {
            matrix[matrix.GetLength(0)-i-1,j] = count++; 
        }    
        for(int k = matrix.GetLength(0)-i-2; k >= i+1; k--)
        {
            matrix[k, i] = count++; 
        }
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
}

int n = 4;
int m = 4; 
int[,] matrix = new int[n, m];
Releasematrix(matrix);
PrintMatrix(matrix);