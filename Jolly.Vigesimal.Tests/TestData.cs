using System.Collections;
using System.Collections.Generic;

namespace Jolly.Vigesimal.Tests
{
    public class TestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { "1", 1 };
            yield return new object[] { "12", 22 };
            yield return new object[] { "1G", 36 };
            yield return new object[] { "22E", 854 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}