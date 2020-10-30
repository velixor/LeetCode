using NUnit.Framework;

namespace LeetCode.Challenges.Tests
{
    [TestFixture]
    public class NumberOfLongestIncreasingSubsequenceSolutionTests
    {
        [Test]
        [TestCase(new[] {1, 3, 2, 4}, 2)]
        [TestCase(new[] {1, 3, 5, 4, 7}, 2)]
        [TestCase(new[] {2, 2, 2}, 3)]
        public void Name(int[] nums, int answer)
        {
            var solution = new NumberOfLongestIncreasingSubsequenceSolution();

            Assert.That(solution.FindNumberOfLIS(nums), Is.EqualTo(answer));
        }
    }
}