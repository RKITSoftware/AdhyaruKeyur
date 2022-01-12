using CountriesAPI.BL;
using CountriesAPI.Models;
using System.Web.Http;

namespace CountriesAPI.Controllers
{
    public class StateController : ApiController
    {
        #region Public Members

        BLState objBLState = new BLState();

        #endregion Public Members

        #region Public Methods
        /// <summary>
        /// Get All State Details
        /// </summary>
        /// <returns>
        /// List of State with Country Id.
        /// </returns>
        [Route("api/state/getallstate")]
        [HttpGet]
        public IHttpActionResult GetAllState()
        {
            return Ok(objBLState.SelectAll());
        }

        /// <summary>
        /// Get the State data base on Country Id.
        /// </summary>
        /// <param name="countryId">
        /// countryId Pass using this field.
        /// </param>
        /// <returns>
        /// return a State Model object.
        /// </returns>
        [Route("api/state/getStateByCountryId")]
        [HttpGet]
        public IHttpActionResult GetStateByCountryId(int countryId)
        {
            return Ok(objBLState.GetStateByCountryId(countryId));
        }

        /// <summary>
        /// Get the State data base on Id.
        /// </summary>
        /// <param name="countryId">
        /// stateyId Pass using this field.
        /// </param>
        /// <returns>
        /// return a state Model object.
        /// </returns>
        [Route("api/state/getStateById")]
        [HttpGet]
        public IHttpActionResult GetStateById(int countryId)
        {
            return Ok(objBLState.GetStateById(countryId));
        }

        /// <summary>
        /// Insert Country Data.
        /// </summary>
        /// <param name="objState">
        /// State Model Fields - stateid, state_name, countryId.
        /// </param>
        /// <returns>
        /// return a string messages.
        /// </returns>
        [Route("api/state/insertState")]
        [HttpPost]
        public IHttpActionResult InsertState([FromBody] State objState)
        {
            return Ok(objBLState.AddState(objState));
        }

        /// <summary>
        /// Update the State Data
        /// </summary>
        /// <param name="objState">
        /// State Model Fields - stateId, state_name, countryid.
        /// </param>
        /// <returns>
        /// return a string messages.
        /// </returns>
        [Route("api/state/UpdateState")]
        [HttpPost]
        public IHttpActionResult UpdateCountry([FromBody] State objState)
        {
            return Ok(objBLState.UpdateState(objState));
        }

        #endregion Public Methods
    }
}
