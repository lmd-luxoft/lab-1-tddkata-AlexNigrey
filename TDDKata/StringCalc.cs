// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System;

namespace TDDKata
{
    internal class StringCalc
    {
        internal int Sum(string input)
        {
            if (input != null)
            {
                if (input.Length == 0)
                    return 0;

                int sum = 0;
                string[] values = GetSplitedString(input);

                foreach (var value in values)
                {
                    if (int.TryParse(value, out var number))
                    {
                        sum += (number <= 1000)? number : 0;
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

        private string[] GetSplitedString(string input)
        {
            string[] splitedChars = new string[] { ",", "\n" };

            if (input.StartsWith("//") && input[3] == '\n')
            {
                var splitedChar = input[2].ToString();
                splitedChars = new string[] { splitedChar };
                input = input.Substring(4);
            }

            return input.Split(splitedChars, StringSplitOptions.None);
        }
    }
}