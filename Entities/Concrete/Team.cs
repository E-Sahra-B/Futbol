using Core.Entities.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Team : IEntity
    {
        [Key]
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public int LeagueId { get; set; }
        public League Leagues { get; set; }
        public virtual ICollection<Match> HomeMatches { get; set; }
        public virtual ICollection<Match> AwayMatches { get; set; }
    }
}
