using Jsbeautifier;
using System;

namespace Formatter.Formatters
{
    class JsFormatter : IFormatter
    {
        public string Format(string text)
        {
            var beautifier = new Beautifier();
            var result = beautifier.Beautify(text);
            return result;
        }
    }
}
