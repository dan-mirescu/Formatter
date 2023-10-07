namespace Formatter.Transformers
{
    class UnescapeTransformer : ITransformer
    {
        public string Transform(string text)
        {
            var transformed = System.Text.RegularExpressions.Regex.Unescape(text);
            return transformed;
        }
    }
}
