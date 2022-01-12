using CountriesAPI.BL;
using CountriesAPI.Models;
using System.Web.Http;

namespace CountriesAPI.Controllers
{
    public class CountryController : ApiController
    {
        #region Public Members

        BLCountry objBLCountry = new BLCountry();

        #endregion Public Members

        #region Public Methods

        /// <summary>
        /// Get All Country Data.
        /// </summary>
        /// <returns>
        /// return a Country Data.
        /// </returns>
        [Route("api/country/AllCountry")]
        [HttpGet]
        public IHttpActionResult AllCountry()
        {            
            return Ok(objBLCountry.SelectAll());
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
        [Route("api/country/InsertCountry")]
        [HttpPost]
        public IHttpActionResult InsertCountry([FromBody] Countries objCountries)
        {
              return Ok(objBLCountry.AddCountry(objCountries));
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
        [Route("api/country/UpdateCountry")]
        [HttpPost]
        public IHttpActionResult UpdateCountry([FromBody] Countries objCountries)
        {
            return Ok(objBLCountry.UpdateCountry(objCountries));
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
        [Route("api/country/GetCountryById")]
        [HttpGet]
        public IHttpActionResult GetCountryById(int countryId)
        {
            return Ok(objBLCountry.GetCountryById(countryId));
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
        [Route("api/country/DeleteCountryById")]
        [HttpGet]
        public IHttpActionResult DeleteCountryById(int countryId)
        {
            return Ok(objBLCountry.DelectCountryById(countryId));
        }

        #endregion Public Methods
    }
}
