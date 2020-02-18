using System.Collections.Generic;

namespace Jolly.Vigesimal
{
    public struct Vigesimal
    {
        private static readonly char[] _vigesimalCharacters = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };

        private static readonly Dictionary<char, int> _vigesimalCharacterMap = new Dictionary<char, int>{
            { '0', 0 }, {'1',1 }, {'2',2 }, {'3',3 }, {'4',4 }, {'5',5 },{'6',6 }, {'7', 7 }, {'8', 8 }, {'9', 9 },
            {'A',10 }, {'B',11 }, {'C',12 }, {'D',13 }, {'E',14 }, {'F',15 }, {'G',16 }, {'H',17 }, {'I',18 }, {'J',19 } };

        private const int _targetBase = 20;

        public string Value { get; private set; }
        public int IntValue { get; private set; }

        public Vigesimal(int value)
        {
            IntValue = value;
            string result = null;

            do
            {
                result = _vigesimalCharacters[value % _targetBase] + result;
                value /= _targetBase;
            }
            while (value > 0);

            Value = result;
        }

        public Vigesimal(string vigesimalValue)
        {
            Value = vigesimalValue;

            IntValue = 0;
            for (int i = 0; i < vigesimalValue.Length; i++)
            {
                var val = _vigesimalCharacterMap[vigesimalValue[i]];

                if (i == vigesimalValue.Length - 1)
                {
                    //If last one, just add it.
                    IntValue += val;
                }
                else
                {
                    IntValue = (IntValue + val) * _targetBase;
                }
            }
        }

        public override string ToString() => Value;

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is Vigesimal c)) return false;
            return c.IntValue == IntValue;
        }

        public override int GetHashCode() => IntValue.GetHashCode();

        public static bool operator ==(Vigesimal left, Vigesimal right) => left.Equals(right);

        public static bool operator !=(Vigesimal left, Vigesimal right) => !(left == right);
    }
}