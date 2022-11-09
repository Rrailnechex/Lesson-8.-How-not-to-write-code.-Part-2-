

/* 
Задайте двумерный массив. 
Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
 */


int[,] Fill2DArrayWithRandomNumbers(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            inputArray[i, j] = new Random().Next(10, 99);
        }
    }
    return inputArray;
}

void Print2DArray(int[,] inputArray)
{
    for (int rows = 0; rows < inputArray.GetLength(0); rows++)
    {
        for (int collums = 0; collums < inputArray.GetLength(1); collums++)
        {
            Console.Write($"{inputArray[rows, collums]} ");
        }
        Console.WriteLine();
    }
}

void Print1DArray(int[] inputArray)
{
    for (int rows = 0; rows < inputArray.GetLength(0); rows++)
    {
        Console.Write($"{inputArray[rows]}, ");
    }
}

int[] Slice2DArrayCollum(int[,] inputArray, int arrayCollumToSlise)
{
    int[] slicedCollum = new int[inputArray.GetLength(0)];

    for (int collumIndex = 0; collumIndex < inputArray.GetLength(0); collumIndex++)
    {
        slicedCollum[collumIndex] = inputArray[collumIndex, arrayCollumToSlise];
    }
    return slicedCollum;
}

int[] Slice2DArrayRow(int[,] inputArray, int arrayRowToSlise)
{
    int[] slicedRow = new int[inputArray.GetLength(1)];

    for (int rowI = 0; rowI < inputArray.GetLength(1); rowI++)
    {
        slicedRow[rowI] = inputArray[arrayRowToSlise, rowI];
    }
    return slicedRow;
}

int[,] Incert2DArrayCollum(int[,] input2DArray, int[] input1DArray, int arrayCollumToIncert)
{
    for (int collumI = 0; collumI < input2DArray.GetLength(0); collumI++)
    {
        input2DArray[collumI, arrayCollumToIncert] = input1DArray[collumI];
    }
    return input2DArray;
}

int[,] Incert2DArrayRow(int[,] input2DArray, int[] input1DArray, int arrayRowToIncert)
{
    for (int rowI = 0; rowI < input2DArray.GetLength(1); rowI++)
    {
        input2DArray[arrayRowToIncert, rowI] = input1DArray[rowI];
    }
    return input2DArray;
}

int[,] SolveTask54(int[,] input2DArray)
{
    int[] temp1DArray = new int[input2DArray.GetLength(0)];

    for (int currentRow = 0; currentRow < input2DArray.GetLength(0); currentRow++)
    {
        // вынуть отсортировать перевернуть положить

        temp1DArray = Slice2DArrayRow(input2DArray, currentRow);
        Array.Sort(temp1DArray);
        Array.Reverse(temp1DArray);
        input2DArray = Incert2DArrayRow(input2DArray, temp1DArray, currentRow);
    }
    return input2DArray;
}






int[,] theArray = new int[5, 11];
theArray = Fill2DArrayWithRandomNumbers(theArray);
Print2DArray(theArray);

Console.WriteLine();
Console.WriteLine(" ^^^ - create array - fill --------------------- A");
Console.WriteLine();

Print2DArray(SolveTask54(theArray));

Console.WriteLine();
Console.WriteLine(" ^^^ -Print2DArray(SolveTask54(theArray));--------------------- B");
Console.WriteLine();
