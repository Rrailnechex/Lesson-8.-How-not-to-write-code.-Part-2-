


/* Задайте две матрицы. 

Напишите программу, которая 
будет находить произведение двух матриц.

(посмотрите как реализуется произведение матриц, 
там не просто перемножение элемент на элемент)

Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3

Результирующая матрица будет:
18 20
15 18 
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

void IntPrint2DArray(int[,] inputArray)
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

void DoublePrint2DArray(double[,] inputArray)
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

int Get1DArraySumm(int[] inArr)
{
    int summ = 0;

    for (int i = 0; i < inArr.GetLength(0); i++)
    {
        summ += inArr[i];
    }

    return summ;
}

double[,] MatrixMultiplication(int[,] aArray, int[,] bArray)
{
    // create new matrix
    double[,] answerArray = new double[2, 2];

    // MatrixMultiplication
    for (int collumI = 0; collumI < answerArray.GetLength(0); collumI++)
    {
        for (int rowI = 0; rowI < answerArray.GetLength(1); rowI++)
        {
            // answerArray[collumI, rowI] = (collumI1.1 + collumI2.1) * (rowI1.1 + rowI1.2);

            answerArray[collumI, rowI] =
                    Get1DArraySumm(Slice2DArrayCollum(aArray, collumI))
                  * Get1DArraySumm(Slice2DArrayRow(aArray, rowI));
        }
    }



    return answerArray;
}





int[,] theAArray = new int[2, 2];
theAArray = Fill2DArrayWithRandomNumbers(theAArray);
IntPrint2DArray(theAArray);

Console.WriteLine();

int[,] theBArray = new int[2, 2];
theBArray = Fill2DArrayWithRandomNumbers(theBArray);
IntPrint2DArray(theBArray);

Console.WriteLine();
Console.WriteLine(" ^^^ - create arrays + fill ---------------------");
Console.WriteLine();

DoublePrint2DArray(MatrixMultiplication(theAArray, theBArray));

Console.WriteLine();
Console.WriteLine(" ^^^ -IntPrint2DArray(SolveTask54(theArray));---------------------");
Console.WriteLine();


