Console.Clear();

int[,] matrix = new int[5, 5];
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
int[] frequency = new int[matrix.GetLength(0) * matrix.GetLength(1) + 1];
PrintArray(FrequencyOfElements(matrix));

int[] FrequencyOfElements(int[,] matr)
{
    for (int k = 0; k < frequency.Length; k++)
    {
        int counter = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                if (matr[i, j] == k)
                {
                    counter++;
                }
                frequency[k] = counter;
            }
        }
    }
    return frequency;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] != 0)
            Console.WriteLine($"{i} встречается {array[i]} раз");
    }
}

void FillMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
