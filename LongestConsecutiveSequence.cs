using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace Leetcode
{
    class LongestConsecutiveSequence
    {
        public int LongestConsecutive(int[] nums) {


            if(nums.Length == 0){
                return 0;
            }


            HashSet<int> ints = new HashSet<int>(nums);
            int max = 1;


            foreach (int number in ints)
            {
                if(ints.Contains(number - 1)){
                    continue;
                }
                                    int counter = 1; 
                    int y = number;

                    while(ints.Contains(y+1)){
                        counter++;
                        y = y + 1;
                    }
                    if(counter >= max){
                        max = counter;
                    }
            }
            return max;
        }

        
    }
}
