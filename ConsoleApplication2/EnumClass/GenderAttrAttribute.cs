using System;

namespace EnumClass
{
    class GenderAttr: Attribute
    {
        public string code { get; set; }

        public string text { get; set; }

        internal GenderAttr(string code, string text)
        {
            this.code = code;
            this.text = text;
        }
    }
}