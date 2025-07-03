using SumFinderLibrary;

namespace SumFinderTests
{
    public class FinderTests
    {
        [Theory]
        [InlineData(new uint[] { 0, 1, 2, 3, 4, 5, 6, 7 }, 11, 5, 7)]
        [InlineData(new uint[] { 4, 5, 6, 7 }, 18, 1, 4)]
        [InlineData(new uint[] { 1, 2, 3, 4, 5 }, 100, 0, 0)]
        [InlineData(new uint[] { 10, 20, 30 }, 60, 0, 3)]
        public void TestFindElements(uint[] arr, ulong sum, int expectedStart, int expectedEnd)
        {
            var finder = new SumFinder();
            var list = new List<uint>(arr);
            finder.FindElementsForSum(list, sum, out int start, out int end);

            Assert.Equal(expectedStart, start);
            Assert.Equal(expectedEnd, end);
        }
    }
}