using System.Runtime.Serialization;

namespace CountriesAPI.Models
{
    public class ResponseModel
    {
        /// <summary>
        /// Status Message Display the Response Message
        /// </summary>
        public string statusMessage { get; set; } 

        /// <summary>
        /// result - Response Sub Model.
        /// </summary>
        public dynamic result { get; set; }
    }
}