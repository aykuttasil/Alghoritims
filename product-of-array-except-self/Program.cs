﻿using System;
using System.Collections.Generic;

/*
Given an array nums of n integers where n > 1,  
return an array output such that output[i] is equal to the product of all the elements of nums except nums[i].

Example:

Input:  [1,2,3,4]
Output: [24,12,8,6]
Constraint: It's guaranteed that the product of the elements of any prefix or suffix of the array (including the whole array) fits in a 32 bit integer.

Note: Please solve it without division and in O(n).

Follow up:
Could you solve it with constant space complexity? 
(The output array does not count as extra space for the purpose of space complexity analysis.)
*/
namespace product_of_array_except_self
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static int[] ProductExceptSelf(int[] nums)
        {
            int[] result = new int[nums.Length];

            result[nums.Length - 1] = 1;
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                result[i] = result[i + 1] * nums[i + 1];
            }

            int left = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = result[i] * left;
                left = left * nums[i];
            }

            return result;
        }

    }
}
