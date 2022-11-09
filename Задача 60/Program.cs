

/* 
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая 

будет построчно выводить массив, добавляя индексы каждого элемента.

Массив размером 2 x 2 x 2

66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
 */


int[,,] Fill3DArrayWithSeedNumbers(int[,,] inputArray)
{
    int step = 0;
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            for (int k = 0; k < inputArray.GetLength(2); k++)
            {
                inputArray[i, j, k] = step;
                step += 1;
            }
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

void IntPrint3DArray(int[,,] inputArray)
{
    for (int rows = 0; rows < inputArray.GetLength(0); rows++)
    {
        for (int collums = 0; collums < inputArray.GetLength(1); collums++)
        {
            for (int zDimention = 0; zDimention < inputArray.GetLength(2); zDimention++)
            {
                Console.Write($"{inputArray[rows, collums, zDimention]} ({rows},{collums},{zDimention})  ");
            }
            Console.WriteLine();
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




int[,,] theAArray = new int[2, 3, 4];
theAArray = Fill3DArrayWithSeedNumbers(theAArray);
IntPrint3DArray(theAArray);

