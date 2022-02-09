using System;

namespace Formatter.Transformers
{
    class UrlDecodeTransformer : ITransformer
    {
        public string Transform(string text)
        {
            var transformed = Uri.UnescapeDataString(text);
            return transformed;
        }
    }
}
