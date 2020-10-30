using System.Collections.Generic;

namespace LeetCode.Challenges
{
    public class NumberOfLongestIncreasingSubsequenceSolution
    {
        public int FindNumberOfLIS(int[] nums)
        {
            var length = nums.Length;
            var arr = new int[length, length];

            for (var y = 0; y < length; y++)
            {
                for (var x = 0; x < length; x++)
                {
                    if (x < y) arr[y, x] = -1;
                    else if (x == y) arr[y, x] = 0;
                    else
                        arr[y, x] = nums[x] > nums[y]
                            ? 1
                            : 0;
                }
            }

            var seqs = new List<int>[length];
            for (var i = 0; i < length; i++)
            {
                seqs[i] = new List<int>();
            }

            for (var y = length - 1; y >= 0; y--)
            {
                seqs[y].Add(1);

                for (int x = 0; x < length; x++)
                {
                    if (arr[y, x] != 1) continue;
                    foreach (var seq in seqs[x])
                    {
                        seqs[y].Add(seq + 1);
                    }
                }
            }

            var maxLength = 0;
            var count = 0;
            foreach (var seq in seqs)
            {
                foreach (var currentLength in seq)
                {
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                        count = 1;
                    }
                    else if (currentLength == maxLength)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}