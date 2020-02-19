using Xunit;

namespace Jolly.Vigesimal.Tests
{
    public class EqualityTests
    {
        [Theory]
        [ClassData(typeof(TestData))]
        public void ObjectsWithSameValueShouldBeEqual(string vigesimalValue, int intValue)
        {
            var obj1 = new Vigesimal(vigesimalValue);
            var obj2 = new Vigesimal(vigesimalValue);

            //Check they are equal (they should be).
            Assert.Equal(intValue, obj1.IntValue);
            Assert.Equal(intValue, obj2.IntValue);

            //Make sure equality operator agrees in both directions.
            Assert.True(obj1 == obj2);
            Assert.True(obj2 == obj1);
        }

        [Theory]
        [InlineData("A2","1")]
        public void ObjectsWithDifferentValueNotEqual(string obj1Value, string obj2Value)
        {
            var obj1 = new Vigesimal(obj1Value);
            var obj2 = new Vigesimal(obj2Value);

            Assert.False(obj1 == obj2);
        }

        [Fact]
        public void NotEqualToNull()
        {
            var obj1 = new Vigesimal(854);
            Assert.False(obj1 == null);
        }
    }
}