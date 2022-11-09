

/* 
Задайте прямоугольный двумерный массив. 
Напишите программу, которая 
будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов
: 1 строка
 */


int[,] Fill2DArrayWithRandomNumbers(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            inputArray[i, j] = new Random().Next(0, 9);
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

/* void Print1DArray(int[] inputArray)
{
    for (int rows = 0; rows < inputArray.GetLength(0); rows++)
    {
        Console.Write($"{inputArray[rows]}, ");
    }
} */

/* int[] Slice2DArrayCollum(int[,] inputArray, int arrayCollumToSlise)
{
    int[] slicedCollum = new int[inputArray.GetLength(0)];

    for (int collumIndex = 0; collumIndex < inputArray.GetLength(0); collumIndex++)
    {
        slicedCollum[collumIndex] = inputArray[collumIndex, arrayCollumToSlise];
    }
    return slicedCollum;
} */

int[] Slice2DArrayRow(int[,] inputArray, int arrayRowToSlise)
{
    int[] slicedRow = new int[inputArray.GetLength(1)];

    for (int rowI = 0; rowI < inputArray.GetLength(1); rowI++)
    {
        slicedRow[rowI] = inputArray[arrayRowToSlise, rowI];
    }
    return slicedRow;
}

int Get1DArraySumm(int[] inArr)
{
    int summ = 0;

    for (int i = 0; i < inArr.GetLength(0); i++)
    {
        summ += inArr[i];
    }

    return summ;
}

int SolveTask56(int[,] input2DArray)
{
    int[] temp1DArray = new int[input2DArray.GetLength(0)];
    int[] SummLibrary = new int[input2DArray.GetLength(0)];

    for (int currentRow = 0; currentRow < input2DArray.GetLength(0); currentRow++)
    {
        // вынуть посчитать записатьВМассив 
        SummLibrary[currentRow] = Get1DArraySumm(Slice2DArrayRow(input2DArray, currentRow));
    }

    int answer = Array.IndexOf(SummLibrary, SummLibrary.Min());
    answer++;

    return answer;
}






int[,] theArray = new int[9, 4];
theArray = Fill2DArrayWithRandomNumbers(theArray);
Print2DArray(theArray);

Console.WriteLine();
Console.WriteLine($"номер строки с наименьшей суммой элементов = {SolveTask56(theArray)}ая сторока");