using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AppRevisionliteratura
{
    public class Token
    {
        private string _type;
        private string _value;


        public string Type { get => _type; set => _type = value; }
        public string Value { get => _value; set => _value = value; }

        public Token()
        {
        }

        public Token(string token, string type, string value)
        {
            Type = type;
            Value = value;
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
