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

        [Route("api/country/insertCountry")]
        [HttpPost]
        public string insertCountry([FromBody] Countries objCountries)
        {
            if (objCountries.countryName == null || objCountries.countryCode == null || objCountries.continent == null)
            {
                return "Conutry Name, Country Code and Continent are requried.";
            }
            else
            {
                DBHandler objDBHandler = new DBHandler();
                return objDBHandler.addCountry(objCountries);
            }
        }

        [Route("api/country/updateCountry")]
        [HttpPost]
        public string updateCountry([FromBody] Countries objCountries)
        {
            if (objCountries.countryName == null || objCountries.countryCode == null || objCountries.continent == null)
            {
                return "Conutry Name, Country Code and Continent are requried.";
            }
            else
            {
                DBHandler objDBHandler = new DBHandler();
                return objDBHandler.updateCountry(objCountries);
            }
        }

        [Route("api/country/getCountryById")]
        [HttpGet]
        public Countries getCountryById(int countryId)
        {
            DBHandler objDBHandler = new DBHandler();
            return objDBHandler.getCountryById(countryId);
        }

        [Route("api/country/deleteCountryById")]
        [HttpGet]
        public string deleteCountryById(int countryId)
        {
            DBHandler objDBHandler = new DBHandler();
            return objDBHandler.delectCountryById(countryId);
        }
    }
}
