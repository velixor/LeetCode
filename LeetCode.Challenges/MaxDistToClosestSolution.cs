namespace LeetCode.Challenges
{
    public class MaxDistToClosestSolution
    {
        // https://leetcode.com/explore/challenge/card/october-leetcoding-challenge/563/week-5-october-29th-october-31st/3512/
        public int MaxDistToClosest(int[] seats)
        {
            int maxDist = 0, emptySeat = 0;

            for (var i = 0; i < seats.Length; i++)
            {
                if (seats[i] == 0)
                {
                    emptySeat++;
                }
                else
                {
                    if (emptySeat == i)
                        maxDist = i;
                    else if ((emptySeat + 1) / 2 > maxDist)
                        maxDist = (emptySeat + 1) / 2;

                    emptySeat = 0;
                }
            }

            if (emptySeat > maxDist)
                maxDist = emptySeat;

            return maxDist;
        }
    }
}