using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsMadeEasy.Implementation
{
    class FindingDuplicate
    {
        #region UcheIgbokwe
        //20200827
        //Write a function to find duplicate number among an array.
        //Floyd's algorithm consists of two phases and uses two pointers, usually called tortoise and hare.
        //In phase 1, hare = nums[nums[hare]] is twice as fast as tortoise = nums[tortoise].
        //Since the hare goes fast, it would be the first one who enters the cycle and starts to run around the cycle.
        //At some point, the tortoise enters the cycle as well, and since it's moving slower the hare catches the tortoise up at some intersection point. Now phase 1 is over, and the tortoise has lost.
        //In phase 2, we give the tortoise a second chance by slowing down the hare, so that it now moves with the speed of tortoise: tortoise = nums[tortoise], hare = nums[hare]. 
        //The tortoise is back at the starting position, and the hare starts from the intersection point.
        #endregion
        public int findDuplicate(int[] nums)
        {
            int tortoise = nums[0];
            int hare = nums[0];

            while (true)
            {
                tortoise = nums[tortoise];
                hare = nums[nums[hare]];

                if (tortoise == hare)
                {
                    break;
                }
            }

            //Phase 2
            int ptr1 = nums[0];
            int ptr2 = tortoise;

            while (ptr1 != ptr2)
            {
                ptr1 = nums[ptr1];
                ptr2 = nums[ptr2];
            }

            return ptr1;

        }

    }
}
