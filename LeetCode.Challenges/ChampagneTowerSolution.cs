using System;

namespace LeetCode.Challenges
{
    public class ChampagneTowerSolution
    {
        private double[,] _fill;

        public double ChampagneTower(int poured, int queryRow, int queryGlass)
        {
            var (width, height) = GetWidthAndHeight(queryRow, queryGlass);
            var array = new double[height, width];
            FillFill(width, height);
            for (int i = 0; i < poured; i++)
            {
                for (int y = height - 1; y >= 0; y--)
                {
                    for (int x = width - 1; x >= 0; x--)
                    {
                        array[y, x] += Fill(array, x, y);
                        if (array[height - 1, width - 1] == 1) return 1;
                    }
                }
            }

            return array[height - 1, width - 1];
        }

        private void FillFill(int width, int height)
        {
            var helper = new double[height, width];
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (x == 0 && y == 0) helper[y, x] = 1;
                    if (x > 0) helper[y, x] += helper[y, x - 1];
                    if (y > 0) helper[y, x] += helper[y - 1, x];
                }
            }

            _fill = new double[height, width];
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    var pow = Math.Pow(2, y + x + 1);
                    _fill[y, x] = helper[y, x] / pow;
                }
            }
        }

        // ReSharper disable CompareOfFloatsByEqualityOperator
        private double Fill(double[,] array, in int x, in int y)
        {
            if (x == 0 && y == 0) return 1;

            var fill = 0.0;
            if (x != 0 && array[y, x - 1] == 1) fill += _fill[y, x - 1];
            if (y != 0 && array[y - 1, x] == 1) fill += _fill[y - 1, x];

            return fill;
        }

        private (int, int) GetWidthAndHeight(in int queryRow, in int queryGlass)
        {
            return (queryGlass + 1, queryRow - queryGlass + 1);
        }
    }
}