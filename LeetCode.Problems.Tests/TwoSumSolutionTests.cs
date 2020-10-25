using NUnit.Framework;

namespace LeetCode.Problems.Tests
{
    [TestFixture]
    public class TwoSumSolutionTests
    {
        [Test]
        [TestCase(new[] {1, 2, 3}, 5, new[] {1, 2})]
        [TestCase(new[] {3, 1, 5}, 6, new[] {1, 2})]
        [TestCase(new[] {3, 3}, 6, new[] {1, 0})]
        public void TwoSum(int[] nums, int target, int[] answer)
        {
            var twoSumV1 = new TwoSumSolution();
            Assert.That(twoSumV1.TwoSum(nums, target), Is.EquivalentTo(answer));
        }
    }
}