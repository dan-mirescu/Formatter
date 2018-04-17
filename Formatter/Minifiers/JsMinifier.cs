namespace Formatter.Minifiers
{
    class JsMinifier : IMinifier
    {
        public string Minify(string text)
        {
            var minifier = new Microsoft.Ajax.Utilities.Minifier();
            var minifiedString = minifier.MinifyJavaScript(text);
            return minifiedString;
        }
    }
}
