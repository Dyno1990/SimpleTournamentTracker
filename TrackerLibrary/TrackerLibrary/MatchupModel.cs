using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        public List<MatchupEntrtModel> MyProperty { get; set; } = new List<MatchupEntrtModel>();
        public TeamModel Winner { get; set; }
        public int MatchupRound { get; set; }
    }
}
