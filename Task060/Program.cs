// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.

Console.Clear();

void InputMatrix(int[,,] matrix)
{
    Console.WriteLine("Введите неповторяющиеся двузначные элементы трехмерного массива: ");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int z = 0; z < matrix.GetLength(2); z++)
                matrix[i,j,z] = Convert.ToInt32(Console.ReadLine());
        }        
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int z = 0; z < matrix.GetLength(2); z++)
                Console.Write(matrix[i, j, z] + $"({i},{j},{z})" + "  ");
            Console.WriteLine();
        }
    }
}

int n = 2;
int m = 2;
int k = 2;
int[,,] matrix = new int[n, m, k];
InputMatrix(matrix);
