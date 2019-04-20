using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// Represents the Entries for the Team.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// Represent the Winner from a tournament.
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Represents the round.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
