using System.Text.RegularExpressions;

namespace Formatter
{
    static class Utils
    {
        public static string[] GetLines(this string str)
        {
            return Regex.Split(str, "\r\n|\r|\n");
        }
    }
}
