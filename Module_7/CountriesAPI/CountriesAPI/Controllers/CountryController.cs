using CountriesAPI.BL;
using CountriesAPI.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace CountriesAPI.Controllers
{
    public class CountryController : ApiController
    {
        /// <summary>
        /// Get All Country Data.
        /// </summary>
        /// <returns>
        /// return a Country Data.
        /// </returns>
        [Route("api/country/allCountry")]
        [HttpGet]
        public List<Countries> AllCountry()
        {
            BLCountry objBLCountry = new BLCountry();
            
            return objBLCountry.selectAll();
        }

        /// <summary>
        /// Insert Country Data.
        /// </summary>
        /// <param name="objCountries">
        /// Countries Model Fields - phone, countryName, countryCode, capital, currency, continent, continentCode.
        /// </param>
        /// <returns>
        /// return a string messages.
        /// </returns>
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
                BLCountry objBLCountry = new BLCountry();
                return objBLCountry.addCountry(objCountries);
            }
        }

        /// <summary>
        /// Update the Country Data
        /// </summary>
        /// <param name="objCountries">
        /// Countries Model Fields - phone, countryName, countryCode, capital, currency, continent, continentCode.
        /// </param>
        /// <returns>
        /// return a string messages.
        /// </returns>
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
                BLCountry objBLCountry = new BLCountry();
                return objBLCountry.updateCountry(objCountries);
            }
        }

        /// <summary>
        /// Get the country data base on Id.
        /// </summary>
        /// <param name="countryId">
        /// countryId Pass using this field.
        /// </param>
        /// <returns>
        /// return a Country Model object.
        /// </returns>
        [Route("api/country/getCountryById")]
        [HttpGet]
        public Countries getCountryById(int countryId)
        {
            BLCountry objBLCountry = new BLCountry();
            return objBLCountry.getCountryById(countryId);
        }

        /// <summary>
        /// Delete the Country of given Id.
        /// </summary>
        /// <param name="countryId">
        /// countryId Pass using this field.
        /// </param>
        /// <returns>
        /// return a string messages.
        /// </returns>
        [Route("api/country/deleteCountryById")]
        [HttpGet]
        public string deleteCountryById(int countryId)
        {
            BLCountry objBLCountry = new BLCountry();
            return objBLCountry.delectCountryById(countryId);
        }
    }
}
