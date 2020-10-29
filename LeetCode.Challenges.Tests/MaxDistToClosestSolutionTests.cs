using NUnit.Framework;

namespace LeetCode.Challenges.Tests
{
    [TestFixture]
    public class MaxDistToClosestSolutionTests
    {
        [Test]
        [TestCase(new[] {1, 0, 0, 1}, 1)]
        [TestCase(new[] {1, 0, 0, 0, 1, 0, 1}, 2)]
        [TestCase(new[] {1, 0}, 1)]
        [TestCase(new[] {1, 0, 0}, 2)]
        public void MaxDistToClosest(int[] seats, int dist)
        {
            var solution = new MaxDistToClosestSolution();
            Assert.That(solution.MaxDistToClosest(seats), Is.EqualTo(dist));
        }
    }
}