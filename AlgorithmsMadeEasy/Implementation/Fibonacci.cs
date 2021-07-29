namespace AlgorithmsMadeEasy.Implementation
{
    public class Fibonacci
    {
        public void Fibonacci()
        {
            int n = 8;
            int firstNumber = 0 ; int secondNumber = 1; int result = 0;

            if(n == 0) Console.WriteLine($"{n}");
            if (n == 1)
            {
                Console.WriteLine($"{n}");
            }
            else
            {
                Console.WriteLine($"{firstNumber}");
                Console.WriteLine($"{secondNumber}");
                for (int i = 2; i <= n; i++)
                {
                    result = firstNumber + secondNumber;
                    firstNumber = secondNumber;
                    secondNumber = result;
                    Console.WriteLine($"{result}");
                }
            }

        }
    }
}