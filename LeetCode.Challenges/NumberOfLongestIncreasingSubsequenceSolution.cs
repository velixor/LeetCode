using System.Linq;

namespace LeetCode.Challenges
{
    public class NumberOfLongestIncreasingSubsequenceSolution
    {
        public int FindNumberOfLIS(int[] nums)
        {
            var length = nums.Length;
            if (length <= 1) return length;

            var sequences = new Sequence[length];
            for (var i = 0; i < length; i++)
            {
                sequences[i].Count = 1;
            }

            for (var right = 0; right < length; ++right)
            {
                for (var left = 0; left < right; ++left)
                {
                    if (nums[left] >= nums[right]) continue;
                    if (sequences[left].Length >= sequences[right].Length)
                    {
                        sequences[right].Length = sequences[left].Length + 1;
                        sequences[right].Count = sequences[left].Count;
                    }
                    else if (sequences[left].Length + 1 == sequences[right].Length)
                    {
                        sequences[right].Count += sequences[left].Count;
                    }
                }
            }

            var longest = sequences.Select(x => x.Length).Max();
            var ans = sequences.Where(x => x.Length == longest).Sum(x => x.Count);

            return ans;
        }

        private struct Sequence
        {
            public int Length;
            public int Count;
        }
    }
}