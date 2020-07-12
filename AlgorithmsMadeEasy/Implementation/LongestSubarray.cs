using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmsMadeEasy.Implementation
{
    class LongestSubarray
    {
        public int LongSubarray(int[] numsInArray, int k)
        {
            int result = -1;
            int ArrayLength = numsInArray.Length;
            int sum = 0;
            int start = 0;
            int end = 0;
            //sort the array by ascending order.
            int[] sortedCopy = numsInArray.OrderBy(c => c).ToArray();


            if (numsInArray.Length == 0)
            {
                return result;
            }
            else
            {
                for (int i = 0; i < ArrayLength; i++)
                {
                    //sum up each number from the array and register the index in end.
                    sum += sortedCopy[i];
                    end = i;

                    while (sum > k)
                    {
                        //substract using the last registered index.
                        sum -= sortedCopy[end];
                        start++;

                        if (sum <= k)
                        {
                            //get the number of values that make up the sum.
                            result = end - start + 1;

                            return result;
                        }

                        //deduct the index by 1 to pick the trailing index.
                        end--;
                    }

                    
                }

                if (sum <= k)
                {
                    result = end + 1;

                    return result;
                }
            }

            return result;
        }
    }
}
