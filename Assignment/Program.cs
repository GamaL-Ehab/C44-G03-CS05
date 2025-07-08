using System.Drawing;
using System.Transactions;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            ////Q1
            //Console.WriteLine("Enter the size of the matrix: ");
            //int n;

            //while (!int.TryParse(Console.ReadLine(), out n))
            //{
            //    Console.WriteLine("Enter the size of the matrix: ");
            //}

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write("0 ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Q2
            ////Q2
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}

            //Console.WriteLine(sum);
            #endregion

            #region Q3
            ////Q3
            //int[] array1 = { 1, 3, 5, 7 };
            //int[] array2 = { 2, 4, 6, 8 };

            //int size = array1.Length;
            //int[] mergedArray = new int[size * 2];

            //for (int i = 0; i < size; i++)
            //{
            //    mergedArray[i] = array1[i];
            //    mergedArray[i + size] = array2[i];
            //}

            //for (int i = 0; i < mergedArray.Length - 1; i++)
            //{
            //    for (int j = 0; j < mergedArray.Length - i - 1; j++)
            //    {
            //        if (mergedArray[j] > mergedArray[j + 1])
            //        {
            //            int temp = mergedArray[j];
            //            mergedArray[j] = mergedArray[j + 1];
            //            mergedArray[j + 1] = temp;
            //        }
            //    }
            //}

            //Console.WriteLine("Merged and sorted array in ascending order:");
            //foreach (int i in mergedArray)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine();
            #endregion

            #region Q4
            ////Q4
            //int[] numbers = { 2, 4, 2, 6, 6, 8, 9, 10, 30, 59, 58 };
            //int min = numbers[0];
            //int max = 0;


            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > max)
            //    {
            //        max = numbers[i];
            //    }

            //    if (numbers[i] < min)
            //    {
            //        min = numbers[i];
            //    }

            //}

            //Console.WriteLine($"Max is: {max}");
            //Console.WriteLine($"Min is: {min}");

            #endregion

            #region Q5
            ////Q5
            //int[] numbers = { 2, 58, 2, 6, 57, 8, 9, 10, 30, 59, 55 };
            //int max = 0;
            //int secondMax = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > max)
            //    {
            //        secondMax = max;
            //        max = numbers[i];
            //    }
            //}

            //Console.WriteLine($"Second Largest Number: {secondMax}");


            #endregion

            #region Q6
            ////Q6
            //int length;
            //Console.WriteLine("Enter The Number of Array Elements: ");
            //while (!int.TryParse(Console.ReadLine(), out length) || length <= 0)
            //{
            //    Console.WriteLine("Enter Valid Number: ");
            //}

            //int[] numbers = new int[length];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine($"Enter Element Number {i+1}: ");
            //    while (!int.TryParse(Console.ReadLine(), out numbers[i]))
            //    {
            //        Console.WriteLine("Enter Valid Number: ");
            //    }
            //}


            //int maxDistance = 0;

            //for (int i = 0; i < length - 1; i++)
            //{
            //    for (int j = length - 1; j > i; j--)
            //    {
            //        if (numbers[i] == numbers[j])
            //        {
            //            int distance = j - i - 1;
            //            if (distance > maxDistance)
            //            {
            //                maxDistance = distance;
            //            }
            //            break;
            //        }
            //    }
            //}

            //if (maxDistance >= 0)
            //    Console.WriteLine("Longest distance between two equal cells: " + maxDistance);
            //else
            //    Console.WriteLine("No equal elements found.");

            #endregion

            #region Q7
            ////Q7
            //Console.WriteLine("Enter Sentence To Reverse: ");
            //string sentence = Console.ReadLine();
            //string[] words = sentence.Split(' ');

            //for (int i = words.Length -1; i >= 0; i--)
            //{
            //    Console.Write($"{words[i]} ");
            //}
            #endregion

            #region Q8
            //int rows;
            //int columns;
            //int value;

            //Console.WriteLine("Enter The Number Of The Rows: ");
            //while (!int.TryParse(Console.ReadLine(), out rows))
            //{
            //    Console.WriteLine("Enter Valid Number Of The Rows: ");
            //}

            //Console.WriteLine("Enter The Number Of The Columns: ");
            //while (!int.TryParse(Console.ReadLine(), out columns))
            //{
            //    Console.WriteLine("Enter Valid Number Of The Columns: ");
            //}

            //int[,] array1 = new int[rows, columns];

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.WriteLine($"Enter value For Cell [{i+1}, {j+1}]: ");
            //        while (!int.TryParse(Console.ReadLine(), out value))
            //        {
            //            Console.WriteLine($"Enter valid value For Cell [{i + 1}, {j + 1}]: ");
            //        }
            //        array1[i, j] = value;
            //    }
            //}

            ////Copy to the second array
            //int[,] array2 = new int[rows,columns];
            //Array.Copy(array1, array2, array1.Length);

            ////print
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.Write($"{array2[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Q9
            ////Q9
            //int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };

            //for (int i = array.Length -1; i >= 0; i--)
            //{
            //    Console.WriteLine(array[i]);
            //}
            #endregion
        }
    }
}
