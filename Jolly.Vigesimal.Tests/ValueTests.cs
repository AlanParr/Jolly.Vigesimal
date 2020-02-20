using Xunit;

namespace Jolly.Vigesimal.Tests
{
    public class ValueTests
    {
        [Theory]
        [ClassData(typeof(TestData))]
        public void HasCorrectValueWhenConstructedFromInt(string vigesimalValue, int intValue)
        {
            var result = new Vigesimal(intValue);
            Assert.Equal(vigesimalValue, result.Value);
        }

        [Theory]
        [ClassData(typeof(TestData))]
        public void HasCorrectValueWhenConstructedFromVigesimal(string vigesimalValue, int intValue)
        {
            var result = new Vigesimal(vigesimalValue);
            Assert.Equal(intValue, result.IntValue);
        }

        [Fact]
        public void TestToStringIsCorrect()
        {
            var result = new Vigesimal("22E");
            Assert.Equal("22E", result.ToString());
        }
    }
}