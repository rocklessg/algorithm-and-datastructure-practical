using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeChallenge
{
    public class SearchingArray
    {
        public static string LinearSearch(int[] arr, int numberToSearch)
        {
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                if (arr[i] == numberToSearch) 
                    return $"{numberToSearch} is found at position {i} of the array";
            }
            return $"{numberToSearch} is not present in the array";
        }
    }
}
