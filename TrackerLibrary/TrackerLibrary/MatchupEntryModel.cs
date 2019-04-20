using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents one team in the matchup.
        /// </summary>
        public TeamModel TeamCompeteng { get; set; }

        /// <summary>
        /// Represents the score for this particular team.
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Represents the matchup that this team came 
        /// from as the winner.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }

        public MatchupEntryModel(double initialScore)
        {
            Console.WriteLine();
        }
    }
}
