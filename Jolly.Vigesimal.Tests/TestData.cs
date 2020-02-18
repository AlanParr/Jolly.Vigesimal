using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jolly.Vigesimal.Tests
{
    public class TestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { "1", 1 };
            yield return new object[] { "22E", 854 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
