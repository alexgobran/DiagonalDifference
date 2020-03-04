using System;
using System.Collections.Generic;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

                int n = Convert.ToInt32(Console.ReadLine().Trim());

                List<List<int>> arr = new List<List<int>>();

                for (int i = 0; i < n; i++)
                {
                    arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
                }

                int result = Result.diagonalDifference(arr);

                textWriter.WriteLine(result);

                textWriter.Flush();
                textWriter.Close();
            }
            


        }
        public static int DiagonalDifference(List<List<int>> arr,int n)
        {
            int D1 = 0, D2 = 0;
            for(int=0;int< n)
            D1 = +[i][i];



            return Math.Abs(D1-D2);
        }
        
    }
}
