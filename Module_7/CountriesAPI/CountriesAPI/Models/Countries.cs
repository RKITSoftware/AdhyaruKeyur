using System.ComponentModel.DataAnnotations;

namespace CountriesAPI.Models
{
    public class Countries
    {
        #region Public variables

        /// <summary>
        /// primary key - country id. 
        /// </summary>
        [Key]
        public int countryId { get; set; }

        /// <summary>
        /// Phone Field
        /// </summary>
        [StringLength(4,ErrorMessage = "Phone Number must be max four character.")]
        [Required (ErrorMessage = "Phone Field is Required.")]
        public int phone { get; set; }

        /// <summary>
        /// Country Name
        /// </summary>
        [StringLength(20, ErrorMessage = "Country Name must be max 20 character.")]
        [Required(ErrorMessage = "Country Name Field is Required.")]
        public string countryName { get; set; }

        /// <summary>
        /// Country Code
        /// </summary>
        [StringLength(4, ErrorMessage = "Country Code must be max four character.")]
        [Required(ErrorMessage = "Country Code Field is Required.")]
        public string countryCode { get; set; }

        /// <summary>
        /// Capital
        /// </summary>
        [StringLength(20, ErrorMessage = "capital must be max 20 character.")]
        public string capital { get; set; }

        /// <summary>
        /// Currency
        /// </summary>
        [StringLength(4, ErrorMessage = "currency must be max four character.")]
        [Required(ErrorMessage = "currency Field is Required.")]
        public string currency { get; set; }

        /// <summary>
        /// continent
        /// </summary>
        [StringLength(20, ErrorMessage = "continent must be max 20 character.")]
        [Required(ErrorMessage = "continent Field is Required.")]
        public string continent { get; set; }

        /// <summary>
        /// continent Code
        /// </summary>
        [StringLength(4, ErrorMessage = "continent Code must be max four character.")]
        public string continentCode { get; set; }
        
        #endregion Public variables
    }
}