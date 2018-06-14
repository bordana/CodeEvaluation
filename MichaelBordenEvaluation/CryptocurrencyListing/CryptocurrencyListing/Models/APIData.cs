using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CryptocurrencyListing.Models
{    
    public class Rootobject
    {
        public Crypto[] crypto { get; set; }
    }

    public class Crypto
    {
        public string name { get; set; }
    }
}
