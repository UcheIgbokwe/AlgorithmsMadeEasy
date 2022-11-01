using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlgorithmsMadeEasy.Implementation
{
    public class JobCityTest
    {
        public static int FindMaxx(int[] space, int x)
        {
            int chunks = 1, item = 1;
            var loaded = new List<int>();

            while(item < space.Length)
            {
                if ((item < x) && (space[item] < space[GetLastItem(loaded)]))
                {
                    if(loaded.Count > 0)
                    {
                        loaded.RemoveAt(loaded.Count - 1);
                    }
                    loaded.Add(item);
                }
                else
                {
                    var lastItem = GetLastItem(loaded);
                    if (lastItem >= chunks)
                    {
                        if(space[item] < space[lastItem])
                        {
                            loaded.Add(item);
                        }else{
                            loaded.Add(lastItem);
                        }
                    }
                    else
                    {
                        loaded.Add(item);
                        int j = 0;
                        for(int k = chunks; j++ < x; k++)
                        {
                            if (space[k] < space[GetLastItem(loaded)])
                            {
                                if(loaded.Count > 0)
                                {
                                    loaded.RemoveAt(loaded.Count - 1);
                                }
                                loaded.Add(k);
                            }
                        }
                    }
                    chunks++;
                }
                item++;
            }
            if(loaded.Count > 0)
            {
                return loaded.Max(c => space[c]);
            }else{
                return 0;
            }
        }

        private static int GetLastItem(List<int> arrayList)
        {
            if(arrayList.Count > 0)
            {
                return arrayList.Last();
            }else{
                return 0;
            }
        }
    }
}