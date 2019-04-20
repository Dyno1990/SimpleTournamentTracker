using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Represents the place number of the team.
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Represents the place name of the team.
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Represents the prize amount.
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Represents the prize percentage of the team.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
