using Core.Entities.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class League:IEntity
    {
        [Key]
        public int LeagueId { get; set; }
        public string LeagueName { get; set; }
        public List<Team> Teams { get; set; }
    }
}

