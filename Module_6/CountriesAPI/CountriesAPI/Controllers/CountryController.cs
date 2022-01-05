using CountriesAPI.BL;
using CountriesAPI.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace CountriesAPI.Controllers
{
    public class CountryController : ApiController
    {
        #region Public Methods

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
                //BLCountry objBLCountry = new BLCountry();
                //objBLCountry.addCountry(objCountries);
                return "Insert Done !!";
            }
        }

        #endregion Public Methods
    }
}
