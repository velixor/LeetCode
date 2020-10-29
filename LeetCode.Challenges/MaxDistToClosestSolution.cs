using System;

namespace LeetCode.Challenges
{
    public class MaxDistToClosestSolution
    {
        // https://leetcode.com/explore/challenge/card/october-leetcoding-challenge/563/week-5-october-29th-october-31st/3512/
        public int MaxDistToClosest(int[] seats)
        {
            var left = -1;
            var right = 0;
            var maxDist = 0;

            while (right < seats.Length)
            {
                if (seats[right] == 1)
                {
                    maxDist = left < 0
                        ? Math.Max(maxDist, CornerCase(left, right))
                        : Math.Max(maxDist, MiddleCase(left, right));
                    left = right;
                }

                right++;
            }

            maxDist = Math.Max(maxDist, CornerCase(left, right));

            return maxDist;
        }

        private int CornerCase(int l, int r) => r - l - 1;
        private int MiddleCase(int l, int r) => (int) Math.Ceiling(CornerCase(l, r) / 2.0);
    }
}