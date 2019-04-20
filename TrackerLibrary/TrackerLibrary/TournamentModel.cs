using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// Represents the Tournament name and will store its value.
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// This property represents the entry fee.
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// Represents the number of entered teams.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// Represents the entered prizes.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// Represents the tournament rounds.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
