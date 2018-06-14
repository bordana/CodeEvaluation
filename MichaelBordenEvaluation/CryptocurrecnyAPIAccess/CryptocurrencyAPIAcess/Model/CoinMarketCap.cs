using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CryptocurrencyAPIAccess.Model
{
    public class APIData
    {
        public Datum[] data { get; set; }
        public Metadata metadata { get; set; }
    }

    public class Metadata
    {
        public int timestamp { get; set; }
        public int num_cryptocurrencies { get; set; }
        public object error { get; set; }
    }

    public class Datum
    {
        public int id { get; set; }
        public string name { get; set; }
        public string symbol { get; set; }
        public string website_slug { get; set; }
    }

    public class CryptoName
    {
        public string name { get; set; }
    }

    

}
