using Newtonsoft.Json;

namespace Formatter.Formatters
{
    class JsonFormatter : IFormatter
    {
        public string Format(string text)
        {
            var obj = JsonConvert.DeserializeObject<dynamic>(text);
            var json = JsonConvert.SerializeObject(obj, Formatting.Indented);
            return json;
        }
    }
}
