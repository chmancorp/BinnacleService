//@relj
//praxis 2017
namespace BinnacleService.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// /Entity Class Binnacle
    /// </summary>
    public class Binnacle
    {
        /// <summary>
        /// Id 
        /// </summary>
        public Guid BinnacleId { get; set; }
        /// <summary>
        /// Id from Catalogs
        /// </summary>
        public int? ActionTypeId { get; set; }
        /// <summary>
        /// Details form the movement
        /// </summary>
        public string Details { get; set; }
        /// <summary>
        /// Transaction Date
        /// </summary>
        public DateTime? DateBinnacle { get; set; }
        /// <summary>
        /// Person Id from Users services
        /// </summary>
        public Guid PersonId { get; set; }
   
    }
}
