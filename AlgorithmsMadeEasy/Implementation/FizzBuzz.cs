namespace AlgorithmsMadeEasy.Implementation
{
    public class FizzBuzz
    {
        public void FizzBuzz()
        {
            int count = 5;
            var numbers = Enumerable.Range(1,count);
            var results = new string[count];
            var results2 = new int[count];

            numbers.AsParallel().ForAll(x => {
                if(x % 3 == 0 && x % 5 == 0)
                {
                    results[x - 1] = "FizzBuzz";
                }
                else if (x % 3 == 0)
                {
                    results[x - 1] = "Fizz";
                }
                else if (x % 5 == 0)
                {
                    results[x - 1] = "Buzz";
                }
                else{
                    results[x - 1] = x.ToString();
                }
            });

            foreach (var item in results)
            {
                Console.Write($"{item}\t");
            }
        }


        
    }

    
}