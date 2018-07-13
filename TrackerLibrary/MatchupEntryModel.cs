﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents One team in the match Up
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        
        /// <summary>
        /// Represents the score for this perticular team
        /// </summary>
        public double Score { get; set; }
        
        /// <summary>
        /// Represents the matchup that this team came 
        /// from as the winner
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }

       
        public MatchupEntryModel(double initialScore)
        {
            Console.WriteLine();
        }
    }
}