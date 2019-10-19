using System;
using System.Collections.Generic;


namespace Indexers
{
    public class HittCookie
    {
        private readonly Dictionary<string, string> _dictionary;
        public DateTime Expiry { get; set; }

        public HittCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        public void SetItem(string key, string value)
        {

        }
        public string GetItem(string key)
        {

        }
        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
    }
}
