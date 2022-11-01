using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsMadeEasy.Implementation
{
    public class Andela
    {
        public static long CarParkingRoof(List<long> cars, int k)
        {
            cars.Sort();

            int windowStart = 0;
            long minLength = long.MaxValue;
            for(int windowEnd = 0; windowEnd < cars.Count; windowEnd++)
            {
                if(windowEnd < k-1)
                {
                    continue;
                }
                long currentRoofLength = cars[windowEnd] - cars[windowStart++] + 1;

                minLength = Math.Min(minLength, currentRoofLength);
            }
            return minLength;
        }

        public static int NumPlayers(int k, List<int> scores)
        {
            var ranks = new List<int>();
            var groups = scores.Where(f => f != 0).OrderByDescending(f => f).GroupBy(g => g).ToList();

            var rank = 1;
            foreach (var item in groups)
            {
                var count = groups.Count;
                for(var i = 0; i < count; i++)
                {
                    ranks.Add(rank);
                }
                rank += count;
            }
            return ranks.Count(r => r <= k);
        }
    }
}