using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsMadeEasy.Implementation
{
    public class BillDivision
    {
        // Complete the bonAppetit function in the editor below. It should print Bon Appetit if the bill is fairly split. 
        //Otherwise, it should print the integer amount of money that Brian owes Anna.bonAppetit has the following parameter(s):
        // bill: an array of integers representing the cost of each item ordered
        // k: an integer representing the zero-based index of the item Anna doesn't eat
        // b: the amount of money that Anna contributed to the bill
        // 1
        // 3 10 2 9
        // 12
        public void BonAppetit(List<int> bill, int k, int b)
        {
            try
            {
                var totalAggregate = bill.Aggregate((p,x) => p + x);
                var actualAggregate = totalAggregate - bill[k];
                if(b == (totalAggregate/2))
                {
                    var result = (totalAggregate/2) - (actualAggregate/2);
                    //return result;
                }else if (b == (actualAggregate/2))
                {
                    var result = "Bon Appetit";
                    Console.WriteLine(result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}