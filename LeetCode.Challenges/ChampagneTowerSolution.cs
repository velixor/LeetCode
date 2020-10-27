using System;

namespace LeetCode.Challenges
{
    public class ChampagneTowerSolution
    {
        // https://leetcode.com/explore/challenge/card/october-leetcoding-challenge/562/week-4-october-22nd-october-28th/3508/
        public double ChampagneTower(int poured, int queryRow, int queryGlass)
        {
            var (height, width) = GetHeightAndWidth(queryRow, queryGlass);
            var tower = new double[height, width];

            tower[0, 0] += poured;
            for (var y = 0; y < height; y++)
            {
                for (var x = 0; x < width; x++)
                {
                    if (tower[y, x] <= 1) continue;

                    var half = (tower[y, x] - 1) / 2;
                    tower[y, x] = 1;

                    if (y + 1 < height) tower[y + 1, x] += half;

                    if (x + 1 < width) tower[y, x + 1] += half;

                    // ReSharper disable once CompareOfFloatsByEqualityOperator
                    if (tower[height - 1, width - 1] == 1) return 1;
                }
            }

            var answer = tower[height - 1, width - 1];
            return Math.Min(answer, 1);
        }

        private (int, int) GetHeightAndWidth(in int queryRow, in int queryGlass)
        {
            return (queryRow - queryGlass + 1, queryGlass + 1);
        }
    }
}