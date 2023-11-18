using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifeanyi_algorithm_solutions.algorithms.arrays
{
    public class two_sum
    {
        public static int[] two_sum_solution(int[] nums, int target)
        {
            int[] returnValue = new int[2];
            var numbers1 = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int isEqual = target - nums[i];

                if (numbers1.Contains(isEqual))
                {
                    returnValue[0] = Array.IndexOf(nums, isEqual);
                    returnValue[1] = i;
                    break;
                }
                else
                {
                    numbers1.Add(nums[i]);
                }
            }

            return returnValue;
        }

        public static bool two_sum_solution_bool(int[] nums, int target)
        {
            bool returnValue = false;
            var numbers1 = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int isEqual = target - nums[i];

                if (numbers1.Contains(isEqual))
                {
                    returnValue = true;
                    break;
                }
                else
                {
                    numbers1.Add(nums[i]);
                }
            }

            return returnValue;
        }
    }
}
