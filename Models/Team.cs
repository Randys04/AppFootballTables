using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppFootballTables.Models
{
    public class Team
    {
        public int TeamID { get; set; }
        public string? Name { get; set; }
        public string? City { get; set; }
        public int? UserID { get; set; }
        public ICollection<RankingTableContent>? RankingTableLink { get; set; }
    }
}