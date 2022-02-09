using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formatter.Transformers
{
    class Base64DecodeTransformer : ITransformer
    {
        public string Transform(string text)
        {
            var data = Convert.FromBase64String(text);
            var decodedString = Encoding.UTF8.GetString(data);
            return decodedString;
        }
    }
}
