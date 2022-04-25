using System;

namespace C_Sharp_Lesson_3_Homework
{
    public class Homework
    {
        public void GetCentralElementFromMatrix(int[,] matrixOfIntegers)
        {
            /*print to console the central element from matrixOfIntegers, if not exist print: "This matrix doesn't have a central element"
             * |   input           | result             |
             * |-------------------|--------------------|
             * | {                 |                    |
             * |  { 1,   3,  5},   |    The central     |
             * |  {-1, 100, 11},   |  element is 100    |
             * |  { 2,  15, 44}    |                    |
             * |  }                |                    |
             * |----------------------------------------|
             * |{                  |                    |
             * | { 1,  6, 21,  8 },| This matrix doesn't|
             * | { 5, -4,  5,  7 },| have a central     |
             * | {77,  5,  0, 74 } |  element           |
             * | }                 |                    |
             * ------------------------------------------
             *    
             */
            int rows = matrixOfIntegers.GetLength(0);
            int columns = matrixOfIntegers.GetLength(1);
            
            if (rows == columns && rows % 2 == 1)
            {
                Console.WriteLine("The central element is " + matrixOfIntegers[rows / 2, rows / 2]);
            }
            else { Console.WriteLine("This matrix doesn't have a central element"); }
        }

        public void GetSummOfDiagonalsElements(int[,] matrixOfIntegers)
        {
            /*print to console the central element from matrixOfIntegers, if not exist print: "This matrix doesn't have a central element"
             * |   input           | result              |
             * |-------------------|---------------------|
             * | {                 |                     |
             * |  { 1,   3,  5},   | First diagonal: 145 |
             * |  {-1, 100, 11},   | Second diagonal: 107|
             * |  { 2,  15, 44}    |                     |
             * |  }                |                     |
             * |-----------------------------------------|
             * |{                  |                     |
             * | { 1,  6, 21,  8 },| This matrix doesn't |
             * | { 5, -4,  5,  7 },| have a diagonals    |
             * | {77,  5,  0, 74 } |                     |
             * | }                 |                     |
             * ------------------------------------------
             *    
             */
            int rows = matrixOfIntegers.GetLength(0);
            int columns = matrixOfIntegers.GetLength(1);
            int summFirstDiagonal = 0;
            int summSecondDiagonal = 0;

            if (rows == columns && rows % 2 == 1)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (i == j)
                        {
                            summFirstDiagonal += matrixOfIntegers[i, j];
                        }
                        if (i + j == rows - 1)
                        {
                            summSecondDiagonal += matrixOfIntegers[i, j];
                        }
                    }
                }
                Console.WriteLine("First diagonale: " + summFirstDiagonal);
                Console.WriteLine("Second diagonale: " + summSecondDiagonal);
            }
            else { Console.WriteLine("This matrix doesn't have a diagonals"); }
        }

        public void StarPrinter(int triangleHight)
        {
            /* Write a programm that will print a triagle of stars  with hight = triangleHight
             *  Example: triangleHight = 3;
             *  Result:   *
             *           * *
             *          * * * 
             */
            if (triangleHight > 0)
            {
                int rows = triangleHight;
                int columns = rows * 2 - 1;
                int min = rows - 1;
                int max = rows - 1;
                char[,] triangle = new char[rows, columns];
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        switch (rows % 2)
                        {
                            case 1:
                                if (i + j >= min && i + j <= max && (i + j) % 2 == 0)
                                {
                                    triangle[i, j] = '*';
                                }
                                else { triangle[i, j] = ' '; }
                                break;
                            default:
                                if (i + j >= min && i + j <= max && (i + j) % 2 == 1)
                                {
                                    triangle[i, j] = '*';
                                }
                                else { triangle[i, j] = ' '; }
                                break;
                        }
                    }
                    max += 2;
                }
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write(triangle[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            else { Console.WriteLine("The height of the triangle must be greater than 0"); }
        }

        public void SortList(IList<int> listOfNumbers)
        {
            //Print to console elements of  listOfNumbers in ascending order
            int[] numbers = listOfNumbers.ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int temp = numbers[i];
                    int min = numbers[j];
                    if (min < temp)
                    {
                        numbers[i] = min;
                        numbers[j] = temp;
                    }
                }
            }

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }

        public static void Main(string[] args)
        {
            Homework homework = new();
            IList<int> list = new List<int>() { -5, 8, -7, 0, 44, 121, -7 };
            int[,] matrix = new int[3, 3] {
                { 1,   3,   5 },
                { 2,   3,   5 },
                {100, 56,  -54} };
            int[,] matrix2 = new int[3, 4] {
                { 1,   3,  5,   6},
                { 2,   3,  5,  78},
                {100, 56 , -54, 6} };

            homework.GetCentralElementFromMatrix(matrix);
            homework.GetCentralElementFromMatrix(matrix2);
            homework.GetSummOfDiagonalsElements(matrix);
            homework.GetSummOfDiagonalsElements(matrix2);
            homework.StarPrinter(15);
            homework.SortList(list);
        }

    }
}