using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppFootballTables.Models
{
    public class RankingTable
    {
        public int RankingTableID { get; set;} 
        public string? RankingTableName { get;}
        public string? TournamentName { get;}
        public string? TwoLegged { get;}
        public string? CurrentMatchday { get;}
        public int? UserID { get; set;}
        public ICollection<RankingTableContent>? TeamsLink { get; set; }
        
    }
}