using System;
using System.Collections.Generic;

namespace LeetCode.Problems
{
    // https://leetcode.com/problems/two-sum/
    public class TwoSumSolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                var complement = target - nums[i];
                if (dict.TryGetValue(complement, out var index)) return new[] {i, index};

                dict.TryAdd(nums[i], i);
            }

            throw new ArgumentException();
        }
    }
}