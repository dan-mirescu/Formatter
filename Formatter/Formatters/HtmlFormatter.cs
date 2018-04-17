using TidyManaged;

namespace Formatter.Formatters
{
    class HtmlFormatter : IFormatter
    {
        public string Format(string text)
        {
            using (var doc = Document.FromString(text))
            {
                doc.OutputBodyOnly = AutoBool.Yes;
                doc.Quiet = true;
                doc.IndentBlockElements = AutoBool.Yes;
                doc.CleanAndRepair();
                var cleanHtml = doc.Save();

                return cleanHtml;
            }
        }
    }
}
