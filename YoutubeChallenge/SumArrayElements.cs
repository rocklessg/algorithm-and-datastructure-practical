using System;

namespace YoutubeChallenge
{
    public class SumArrayElements
    {
        public static int SumArray(int[] arr)
        {
            int holder, sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                holder = arr[i];
                sum += holder;
            }
            return sum;
        }
    }
}
