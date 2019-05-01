using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// Represents the first name of a team member.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Represents the last name of a team member.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Represents the email address of a team member,
        /// where the tournament results will be send.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Represents the cell phone number of a team member, 
        /// where a SMS with the tournament results could be send.
        /// </summary>
        public string CellPhoneNumber { get; set; }
    }
}
