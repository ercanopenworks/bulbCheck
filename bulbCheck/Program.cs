using System;
using System.Collections.Generic;
using System.Linq;

namespace bulbCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine().TrimEnd().Split(',').ToList().Select(a => Convert.ToInt32(a)).ToList();
            solution(arr.ToArray());

        }

        public static int solution(int[] A)
        {
            int res = 0;

            HashSet<int> passedBulb = new HashSet<int>();
            HashSet<int> shinedBulb = new HashSet<int>();

            for (int i = 0; i < A.Length; i++)
            {
                if (!shinedBulb.Contains(i + 1) && i + 1 != A[i])
                    passedBulb.Add(i + 1);
                if (i + 1 < A[i])
                    shinedBulb.Add(A[i]);
                else
                    passedBulb.Remove(A[i]);

                if (passedBulb.Count == 0)
                    res++;
    

            }


            return res;

        }
    }
}
