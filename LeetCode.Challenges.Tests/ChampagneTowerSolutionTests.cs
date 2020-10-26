using NUnit.Framework;

namespace LeetCode.Challenges.Tests
{
    [TestFixture]
    public class ChampagneTowerSolutionTests
    {
        [Test]
        [TestCase(2, 1, 1, 0.5)]
        [TestCase(1, 1, 1, 0)]
        [TestCase(100000009, 33, 17, 1)]
        public void ChampagneTower(int poured, int queryRow, int queryGlass, double answer)
        {
            var solution = new ChampagneTowerSolution();

            Assert.That(solution.ChampagneTower(poured, queryRow, queryGlass), Is.EqualTo(answer));
        }
    }
}