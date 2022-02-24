using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class MatchUpEntryModel
    {
        public TeamModel TeamCompeting { get; set; }
        public double Score { get; set; }
        public MatchUpModel ParentMatchup { get; set; }

    }
}
