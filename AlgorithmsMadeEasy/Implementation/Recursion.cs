using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlgorithmsMadeEasy.Implementation
{
    public class Recursion
    {
        public void PrintNext(int i)
        {
            if (i > 100) return;
            Console.Write(i + " ");
            PrintNext(i + 1);
        }
    }
}