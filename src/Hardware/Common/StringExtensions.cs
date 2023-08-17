using System;
using System.Text;

namespace Common
{
    public static class StringExtensions
    {
        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }

        public static string Replace(this string source, char find, char replace)
        {
            var result = new StringBuilder();
            foreach (char character in source)
            {
                result.Append(character == find ? replace : character);
            }
            return result.ToString();
        }
    }
}
