using AlgorithmsMadeEasy.Implementation;
using System;

namespace AlgorithmsMadeEasy
{
    class Program
    {
        static void Main(string[] args)
        {
            #region LongestPrefix

            LongestCommonPrefix classFile = new LongestCommonPrefix();
            string[] sampleWords = new string[3] { "fly", "flask", "fletcher" };
            var longestPrefix = classFile.LongestPrefix(sampleWords);

            Console.WriteLine($"LongestPrefix = {longestPrefix}");
            #endregion

            #region LongestSubarray

            LongestSubarray classFile2 = new LongestSubarray();
            int[] sampleNumbers = new int[3] { 1, 2, 3 };
            var longestSubarray = classFile2.LongSubarray(sampleNumbers, 1);

            Console.WriteLine($"LongestSubarray = {longestSubarray}");
            #endregion
            
        }


    }
}
