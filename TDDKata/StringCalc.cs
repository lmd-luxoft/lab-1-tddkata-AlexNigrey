// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation

namespace TDDKata
{
    internal class StringCalc
    {
        internal int Sum(string s)
        {
            if (s != null)
            {

                if (s.Length == 0)
                {
                    return 0;
                }

                int sum = 0;
                string[] values = s.Split(',');

                foreach (var value in values)
                {
                    if (int.TryParse(value, out var number))
                    {
                        sum += number;
                    }
                    else
                    {
                        return -1;
                    }
                }

                return sum;
            }

            return -1;
        }
    }
}