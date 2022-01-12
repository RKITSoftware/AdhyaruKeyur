using System;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

namespace CountriesAPI.Models
{
    public class State
    {
        /// <summary>
        /// state id
        /// </summary>
        [Key]
        public int stateid { get; set; }

        /// <summary>
        /// State Name
        /// </summary>
        [StringLength(50,ErrorMessage = "State Name must be max 50 character.")]
        [Required(ErrorMessage = "State Name Field is Required.")]
        public string stateName { get; set; }

        /// <summary>
        /// Country Id - FK of Country 
        /// </summary>
        [Range(0,9999, ErrorMessage = "Country Id must be max 4 character.")]
        [Required(ErrorMessage = "Country Id Field is Required.")]
        public int countryId { get; set; }
    }
}