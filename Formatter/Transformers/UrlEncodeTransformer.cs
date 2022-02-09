using System;

namespace Formatter.Transformers
{
    class UrlEncodeTransformer : ITransformer
    {
        public string Transform(string text)
        {
            var transformed = Uri.EscapeDataString(text);
            return transformed;
        }
    }
}
