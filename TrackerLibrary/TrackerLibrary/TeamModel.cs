using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class TeamModel
    {
        /// <summary>
        /// Represents the list of team members.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        /// <summary>
        /// Represents the team name and will store its value.
        /// </summary>
        public string TeamName { get; set; }

        //Before C# 6.0 constructor
    /*    public TeamModel()
        {
            TeamMembers = new List<PersonModel>();
        }
    */
    }
}
