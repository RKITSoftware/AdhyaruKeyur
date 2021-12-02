using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Rank { get; set; }

        public string Distributor { get; set; }
    }
}