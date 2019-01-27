using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Formatter.Formatters
{
    class XmlFormatter : IFormatter
    {
        public string Format(string text)
        {
            try
            {
                XDocument doc = XDocument.Parse(text);
                return doc.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot format: " + ex);
                return text;
            }
        }
    }
}
