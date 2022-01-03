using CountriesAPI.Database;
using CountriesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CountriesAPI.Controllers
{
    public class CountryController : ApiController
    {
        [HttpGet]
        public List<Countries> AllCountry()
        {
            DBHandler objDBHandler = new DBHandler();
            
            return objDBHandler.selectAll();
        }

        [HttpPost]
        public string insertCountry([FromBody] Countries objCountries)
        {
            if(objCountries.countryName == null || objCountries.countryCode == null || objCountries.continent == null)
            {
                return "Conutry Name, Country Code and Continent are requried.";
            }
            else
            {
                //DBHandler objDBHandler = new DBHandler();
                //objDBHandler.addCountry();
                return "insert done !!";
            }
        }
    }
}
