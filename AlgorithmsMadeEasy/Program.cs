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


            //Console.WriteLine("Hello World!");
        }

        
    }
}
