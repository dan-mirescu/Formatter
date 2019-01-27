using System.Linq;

namespace Formatter.Converters
{
    class LinesToArrayConverter : IConverter
    {
        public string Convert(string text)
        {
            var lines = text.GetLines().Select(l => l.Replace("\"", "\\\""));
            var result = "[ \"" + string.Join("\", \"", lines) + "\" ]";
            return result;
        }
    }
}