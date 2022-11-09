

/* 
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
 */


// как мне это без знания классов делать? если одна функция может возвращать только один элемент???

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

int[,] Fill2DArrayWithSeedNumbers(int[,] inputArray)
{
    int step = 0;
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            inputArray[i, j] = step;
            step += 1;
        }
    }
    return inputArray;
}



bool keep = false;
int[,] theBoard = new int[12, 24];
theBoard = Fill2DArrayWithSeedNumbers(theBoard);
IntPrint2DArray(theBoard);

int[] l = { 0, 0 };



for (int i = 0; i < 15; i++)
{
    // go right
    if (theBoard[l[0], (l[1] + 1)] != 1)
    {
        theBoard[l[0], (l[1] + 1)] = 1;
        l[0] = theBoard[l[0], (l[1] + 1)];
        l[1] = theBoard[l[0], (l[1] + 1)];
    }
    x


    IntPrint2DArray(theBoard);
}









/* while (keep == true)
{
    Go(theBoard, l);

    IntPrint2DArray(theBoard);
} */