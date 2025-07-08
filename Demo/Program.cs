namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Arrays

            #region 1D Arrays
            #region Example 01
            //int[] numbers;

            //numbers = new int[3];

            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);

            //numbers[0] = 10;
            //numbers[1] = 20;
            //numbers[2] = 30;

            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);

            //Console.WriteLine($"Size of Array => {numbers.Length}, Dimentions of Array => {numbers.Rank}");

            ////for (int i = 0; i < numbers.Length; i++)
            ////{
            ////    Console.WriteLine(numbers[i]);
            ////}

            //foreach(int i in numbers)
            //    Console.WriteLine(i);

            #endregion

            #region Array Creation Ways
            //int[] numbers = new int[3];
            //int[] numbers2 = new int[3] { 1, 2, 3 };
            //int[] numbers3 = new int[] { 1, 2, 3 };
            //int[] numbers4 = { 1, 2, 3 };

            #endregion
            #endregion

            #region 2D Arrays [Rectangular]

            //int[,] marks = new int[2, 5];
            ////{
            ////    {10, 20, 30, 40, 50 },
            ////    { 10, 20, 30, 40, 50 }  
            ////};

            ////marks[0,0] = 10;
            ////marks[0,1] = 20;
            ////marks[0,2] = 30;
            ////marks[0,3] = 40;
            ////marks[0,4] = 50;
            ////marks[1,0] = 10;
            ////marks[1,1] = 20;
            ////marks[1,2] = 30;
            ////marks[1,3] = 40;
            ////marks[1,4] = 50;

            ////Console.WriteLine($"Size of Array => {marks.Length}, Dimentions of Array => {marks.Rank}");

            ////Input From User
            //for (int i = 0; i < marks.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Marks Of Student Number {i+1}: ");
            //    for (int j = 0; j < marks.GetLength(1); /*j++*/)
            //    {
            //        Console.WriteLine($"The Grade Of Subject {j + 1}: ");
            //        bool isParsed = int.TryParse(Console.ReadLine(), out marks[i,j]);
            //        if (isParsed)
            //            ++j;
            //    }
            //    Console.WriteLine("=========================================");
            //}

            ////Print
            //for (int i = 0; i < marks.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Grades Of Student Number {i+1}: ");
            //    for (int j = 0; j < marks.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"The Grade Of Subject {j + 1} => {marks[i,j]} ");
            //    }
            //    Console.WriteLine("=========================================");
            //}

            #endregion

            #region Jagged Array
            //int[][] jaggedArray = new int[4][]
            //{
            //    [1,4,5,6 ],
            //    [2,3 ],
            //    [1,2,3 ],
            //    [4,5,6,2,1,4]
            //};

            //jaggedArray[0] = [1, 4, 5, 6];
            #endregion

            #region Array Methods
            //int[] numbers = { 1, 5, 3, 10, 5, 6, 7, 8, 9, 2, 6 };

            ////Array.Sort(numbers);
            ////Array.Reverse(numbers);
            ////Array.Clear(numbers);
            ////Array.Clear(numbers, 3 ,2);
            ////Console.WriteLine(Array.IndexOf(numbers, 6));
            ////Console.WriteLine(Array.LastIndexOf(numbers, 6));

            ////Array.Resize(ref numbers, 6);
            //int[] numbers2 = new int[5];
            //Array.Copy(numbers, numbers2, 5);

            ////foreach (int i in numbers)
            ////{
            ////    Console.WriteLine(i);
            ////}

            //foreach (int i in numbers2)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #endregion
        }
    }
}
