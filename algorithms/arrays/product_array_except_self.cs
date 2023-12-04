﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifeanyi_algorithm_solutions.algorithms.arrays
{
    public class product_array_except_self
    {
        public static int[] ProductArrayExceptSelf(int[] nums)
        {
            int n = nums.Length;

            // Initialize arrays to store products to the left and right of each element
            int[] leftProducts = new int[n];
            int[] rightProducts = new int[n];

            // Initialize result array
            int[] result = new int[n];

            // Calculate products to the left of each element
            leftProducts[0] = 1;
            for (int i = 1; i < n; i++)
            {
                leftProducts[i] = leftProducts[i - 1] * nums[i - 1];
            }

            // Calculate products to the right of each element
            rightProducts[n - 1] = 1;
            for (int i = n - 2; i >= 0; i--)
            {
                rightProducts[i] = rightProducts[i + 1] * nums[i + 1];
            }

            // Calculate the final result
            for (int i = 0; i < n; i++)
            {
                result[i] = leftProducts[i] * rightProducts[i];
            }

            return result;
        }

    }
}
