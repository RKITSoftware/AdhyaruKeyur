using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountriesAPI.Models
{
    public class Countries
    {
        public int countryId { get; set; }

        public int phone { get; set; }

        public string countryName { get; set; }

        public string countryCode { get; set; }

        public string capital { get; set; }

        public string currency { get; set; }

        public string continent { get; set; }

        public string continentCode { get; set; }
    }
}